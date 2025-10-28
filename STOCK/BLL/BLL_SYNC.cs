using System;
using System.Windows;
using System.Data;
using System.IO;
using Syncfusion.Pdf;
using System.Linq;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Tables;
using System.Security.Policy;

namespace BLL
{
    public class BLL_SYNC
    {

        public MemoryStream GenerarReporte_TORTA(DataTable table)
        {
            try
            {
                /// recordar q el grafico tiene que estar siemopre detnro de pdfDOCUMENT y luego agregamos este OBJ
                /// a la page para luego usar page. grapics
                /// 1. - INSTANCIAR OBVJETOS 
                #region Instanciamos obj
                PdfDocument pdfDocument = new PdfDocument();
                PdfPage page = pdfDocument.Pages.Add();
                PdfGraphics Graficos = page.Graphics;

                PdfFont fontTitulo = new PdfStandardFont(PdfFontFamily.Helvetica, 40, PdfFontStyle.Bold);
                PdfFont fontLabel = new PdfStandardFont(PdfFontFamily.Helvetica, 15);
                PdfFont fontAlumnos = new PdfStandardFont(PdfFontFamily.Helvetica , 20);

                #endregion


                // Tenemos que averiguar como hacer la colocacion de textos mas dinamic
                // Esto al tuntun es una kagada


                #region Posicionamiento y dibujo de los objetos
                //  ----------- fontTitulo
                Graficos.DrawString("SYNCFUSION", fontTitulo, PdfBrushes.Red, new PointF(20, 20));

                //  ---------- fontLabel
                Graficos.DrawString("Distribución de Productos Más Vendidos (Grafico de Torta)",
                    fontLabel,
                    PdfBrushes.Black,
                    new PointF(20, 70)
                );

                //  --------- fontAlumnos

                Graficos.DrawString(" Britez Alvarenga Gustavo Daniel y Midon Joaquin ",
                                fontAlumnos,
                                PdfBrushes.Black,
                                new PointF(20,730));

                // ---------- FONT pROFESOR
                #endregion

                #region Calculo de datos y porcentajes 
                var data = table.AsEnumerable()
                                .Select(row => new
                                {
                                    Nombre = row["Nombre"].ToString(),
                                    Valor = Convert.ToDecimal(row["Total Venta"])
                                }).ToList();


                decimal ventaTotal = data.Sum(d => d.Valor);
                float X = 250f; // Posición X central del gráfico
                float Y = 280f; // Posición Y central del gráfico
                float radius = 120f;      // Radio del gráfico
                float currentAngle = 0f;  // Ángulo de inicio
                float legendY = 150f;     // Posición de inicio de la leyenda

                // Averiguar como poner mas colores, en caso de que se pasen los prouctos
                PdfBrush[] brushes = { PdfBrushes.Blue, PdfBrushes.Green, PdfBrushes.Orange, PdfBrushes.Purple, PdfBrushes.Brown, PdfBrushes.DarkRed, PdfBrushes.AliceBlue , PdfBrushes.Coral, PdfBrushes.DarkGoldenrod, PdfBrushes.NavajoWhite };
                int colorIndex = 0;

                #endregion

                #region Dibujar el grafico de torta y leyenda 

                foreach (var item in data)
                {
                    float porcentaje = (float)(item.Valor / ventaTotal);
                    float angulodeBarrido = porcentaje * 360f; // 360 grados totales

                    PdfBrush currentBrush = brushes[colorIndex % brushes.Length];

                    Graficos.DrawPie(
                        new PdfPen(Color.Black, 0.5f), // Borde de la porción
                        currentBrush, // Relleno de la porción
                        X - radius, // Posición X 
                        Y - radius, // Posición Y 
                        radius * 2, // Ancho 
                        radius * 2, // Alto 
                        currentAngle, // Ángulo de inicio
                        angulodeBarrido // Ángulo de la porción
                    );

                    float percentageX = X + radius + 30;


                    /// ref
                    Graficos.DrawRectangle(
                        currentBrush,
                        new RectangleF(percentageX, legendY, 10, 10)
                    );

                    
                    string legendText = $"{item.Nombre}: {porcentaje:P1}";// Texto de la leyenda 
                    Graficos.DrawString(
                        legendText,
                        fontLabel,
                        PdfBrushes.Black,
                        new PointF(percentageX + 15, legendY)
                    );

                    currentAngle += angulodeBarrido;
                    legendY += 15f;
                    colorIndex++;
                }
                #endregion
                MemoryStream streamer = new MemoryStream();
                pdfDocument.Save(streamer);
                return streamer;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al generar el gráfico de torta manual: " + ex.Message, ex);
            }
        }

        public MemoryStream GenerarReportes_BARRA(DataTable table)
        {
            try
            {


                #region Definimos los obj
                PdfDocument pdfDocument = new PdfDocument();
                PdfPage page = pdfDocument.Pages.Add();
                PdfGraphics Graficos = page.Graphics;

                // --- Variables de Dibujo Manual ---
                // Definimos el área donde irá el gráfico
                float chartAreaWidth = 400f;
                float chartAreaHeight = 250f;

                PointF chartOrigin = new PointF(20, 100);

                // --- 1. ENCABEZADO
                PdfFont fontTitulo = new PdfStandardFont(PdfFontFamily.Helvetica, 50, PdfFontStyle.Bold);
                PdfFont fontLabel = new PdfStandardFont(PdfFontFamily.Helvetica, 8);
                #endregion

                #region TEXTOS

                Graficos.DrawString("SYNCFUSION", fontTitulo, PdfBrushes.Red, new PointF(20, 20));

                // Título Manual del Gráfico
                // Esto funciona correctamente, ya que PdfStandardFont es una clase concreta

                Graficos.DrawString("Productos Mas Vendidos",
                    new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold),
                    PdfBrushes.Black,
                    new PointF(20, 70)
                );

                #endregion


                #region Calculo de escala y datos

                var valores = table.AsEnumerable()
                                   .Select(row => Convert.ToDecimal(row["Total Venta"]))
                                   .ToList();

                decimal maxValor = valores.Any() ? valores.Max() : 100m;

                float escalaHorizontal = chartAreaWidth / (float)maxValor;
                float alto = 20f; 
                float Y = chartOrigin.Y + 40; 

                PdfBrush[] brushes = { PdfBrushes.Firebrick, PdfBrushes.Green, PdfBrushes.Orange, PdfBrushes.Purple, PdfBrushes.Brown, PdfBrushes.Moccasin};
                int colorIndex = 0;

                #endregion


                #region Dibujar Barras y ETIQUETAS 

                foreach (DataRow row in table.Rows)
                {
                    string nombre = row["Nombre"].ToString();
                    float valor = (float)Convert.ToDecimal(row["Total Venta"]);


                    float ANCHO = valor * escalaHorizontal;

                    RectangleF rectBarra = new RectangleF(
                        chartOrigin.X +80 ,
                        Y,
                        ANCHO,
                        alto
                    );

                    // c) Dibujar la Barra (sin usar PdfChart, se usa DrawRectangle)
                    /// No lo pudimos instalar, es compatible con .NET 6.1 A 9 pero el visor es compatible con 
                    /// .NET FRAMEWORK 4.7.8 y nosotros queremos el VISOR para mostrarlo antes de guardarlo
                    Graficos.DrawRectangle(brushes[colorIndex % brushes.Length], rectBarra);

                    // d) Dibujar la Etiqueta del Valor de la barra
                    Graficos.DrawString(
                        $"{valor:N0}",
                        fontLabel,
                        PdfBrushes.Black,
                        new PointF(chartOrigin.X + ANCHO + 5, Y + 5) // Osea al lado
                    );

                    // e) Dibujar la Etiqueta del Nombre del producto
                    Graficos.DrawString(
                        nombre,
                        fontLabel,
                        PdfBrushes.Black,
                        new PointF(chartOrigin.X, Y +5) 
                    );

                    Y += alto + 5f;
                    colorIndex++;
                }

                #endregion
                MemoryStream streamer = new MemoryStream();
                pdfDocument.Save(streamer);
                return streamer;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al generar el gráfico de barras manual: " + ex.Message, ex);
            }
        }

    }
}