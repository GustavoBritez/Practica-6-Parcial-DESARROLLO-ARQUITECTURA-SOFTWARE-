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

                PdfDocument pdfDocument = new PdfDocument();
                PdfPage page = pdfDocument.Pages.Add();
                PdfGraphics Graficos = page.Graphics;

                PdfFont fontTitulo = new PdfStandardFont(PdfFontFamily.Helvetica, 40, PdfFontStyle.Bold);
                PdfFont fontLabel = new PdfStandardFont(PdfFontFamily.Helvetica, 10);


                // Tenemos que averiguar como hacer la colocacion de textos mas dinamic
                // Esto al tuntun es una kagada
                Graficos.DrawString("SYNCFUSION", fontTitulo, PdfBrushes.Red, new PointF(20, 20));

                Graficos.DrawString("Distribución de Productos Más Vendidos (Grafico de Torta)",
                    new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold),
                    PdfBrushes.Black,
                    new PointF(20, 70)
                );

                // 2. CALCULO DE DATOS Y PORCENTAJES

                // Evitamos usar la LISTA_S
                var data = table.AsEnumerable()
                                .Select(row => new
                                {
                                    Nombre = row["Nombre"].ToString(),
                                    Valor = Convert.ToDecimal(row["Total Venta"])
                                }).ToList();


                decimal ventaTotal = data.Sum(d => d.Valor);
                float chartCenterX = 250f; // Posición X central del gráfico
                float chartCenterY = 280f; // Posición Y central del gráfico
                float radius = 120f;      // Radio del gráfico
                float currentAngle = 0f;  // Ángulo de inicio
                float legendY = 150f;     // Posición de inicio de la leyenda

                // Colores para las porciones y averiguar como poner mas colores, en caso de que se pasen los prouctos
                PdfBrush[] brushes = { PdfBrushes.Blue, PdfBrushes.Green, PdfBrushes.Orange, PdfBrushes.Purple, PdfBrushes.Brown, PdfBrushes.DarkRed, PdfBrushes.AliceBlue , PdfBrushes.Coral, PdfBrushes.DarkGoldenrod, PdfBrushes.NavajoWhite };
                int colorIndex = 0;

                // 3. DIBUJAR EL GRÁFICO DE TORTA Y LA LEYENDA

                foreach (var item in data)
                {
                    float porcentaje = (float)(item.Valor / ventaTotal);
                    float sweepAngle = porcentaje * 360f; // 360 grados totales

                    PdfBrush currentBrush = brushes[colorIndex % brushes.Length];

                    Graficos.DrawPie(
                        new PdfPen(Color.Black, 0.5f), // Borde de la porción
                        currentBrush, // Relleno de la porción
                        chartCenterX - radius, // Posición X 
                        chartCenterY - radius, // Posición Y 
                        radius * 2, // Ancho 
                        radius * 2, // Alto 
                        currentAngle, // Ángulo de inicio
                        sweepAngle // Ángulo de la porción
                    );

                    float percentageX = chartCenterX + radius + 30;

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

                    currentAngle += sweepAngle;
                    legendY += 15f;
                    colorIndex++;
                }

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
                PdfDocument pdfDocument = new PdfDocument();
                PdfPage page = pdfDocument.Pages.Add();
                PdfGraphics Graficos = page.Graphics;

                // --- Variables de Dibujo Manual ---
                // Definimos el área donde irá el gráfico (ancho fijo, alto fijo)
                float chartAreaWidth = 400f;
                float chartAreaHeight = 250f;

                PointF chartOrigin = new PointF(20, 100);

                // --- 1. ENCABEZADO (Funciona correctamente) ---
                PdfFont fontTitulo = new PdfStandardFont(PdfFontFamily.Helvetica, 50, PdfFontStyle.Bold);
                PdfFont fontLabel = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

                Graficos.DrawString("SYNCFUSION", fontTitulo, PdfBrushes.Red, new PointF(20, 20));

                // Título Manual del Gráfico
                // Esto funciona correctamente, ya que PdfStandardFont es una clase concreta

                Graficos.DrawString("Productos Mas Vendidos",
                    new PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold),
                    PdfBrushes.Black,
                    new PointF(20, 70)
                );

                // 2. CÁLCULO DE ESCALA Y DATOS
                var valores = table.AsEnumerable()
                                   .Select(row => Convert.ToDecimal(row["Total Venta"]))
                                   .ToList();

                decimal maxValor = valores.Any() ? valores.Max() : 100m;

                // Mapeo: 400 unidades de ancho del gráfico / MaxValor de ventas
                float escalaHorizontal = chartAreaWidth / (float)maxValor;
                float barHeight = 20f; 
                float currentY = chartOrigin.Y + 40; 

                // Colores para las barras 
                PdfBrush[] brushes = { PdfBrushes.Firebrick, PdfBrushes.Green, PdfBrushes.Orange, PdfBrushes.Purple, PdfBrushes.Brown, PdfBrushes.Moccasin};
                int colorIndex = 0;

                // 3. DIBUJAR BARRAS Y ETIQUETAS

                foreach (DataRow row in table.Rows)
                {
                    string nombre = row["Nombre"].ToString();
                    float valor = (float)Convert.ToDecimal(row["Total Venta"]);


                    float barWidth = valor * escalaHorizontal;

                    RectangleF rectBarra = new RectangleF(
                        chartOrigin.X +80 ,
                        currentY,
                        barWidth,
                        barHeight
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
                        new PointF(chartOrigin.X + barWidth + 5, currentY + 5) // Osea al lado
                    );

                    // e) Dibujar la Etiqueta del Nombre del producto
                    Graficos.DrawString(
                        nombre,
                        fontLabel,
                        PdfBrushes.Black,
                        new PointF(chartOrigin.X, currentY +5) 
                    );

                    currentY += barHeight + 5f;
                    colorIndex++;
                }
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