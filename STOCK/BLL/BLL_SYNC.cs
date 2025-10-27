using System;
using System.Data;
using System.IO;
using Syncfusion.Pdf;
using System.Linq;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Tables;

namespace BLL
{
    public class BLL_SYNC
    {

        public MemoryStream GenerarReporte(DataTable table)
        {
            try
            {
                PdfDocument pdfDocument = new PdfDocument();

                PdfPage page = pdfDocument.Pages.Add();

                PdfGraphics Graficos = page.Graphics;

                PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);

                Graficos.DrawString(
                "SYNCFUSION",
                titleFont,
                PdfBrushes.Red,
                new PointF(20, 20));

                PdfLightTable pdfTable = new PdfLightTable();

                pdfTable.DataSource = table;

                pdfTable.Style.DefaultStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica , 10);

                pdfTable.Draw(page,new PointF(20,60) );

                MemoryStream streamer = new MemoryStream();
                pdfDocument.Save(streamer);
                return streamer;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public MemoryStream GenerarReportes(DataTable table)
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
                System.Drawing.PointF chartOrigin = new System.Drawing.PointF(20, 100);

                // --- 1. ENCABEZADO (Funciona correctamente) ---
                PdfFont fontTitulo = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
                PdfFont fontLabel = new PdfStandardFont(PdfFontFamily.Helvetica, 8);

                Graficos.DrawString("SYNCFUSION", fontTitulo, PdfBrushes.Red, new System.Drawing.PointF(20, 20));

                // Título Manual del Gráfico
                // Esto funciona correctamente, ya que PdfStandardFont es una clase concreta
                Graficos.DrawString("Distribución de Ventas por Cliente",
                    new Syncfusion.Pdf.Graphics.PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold),
                    PdfBrushes.Black,
                    new System.Drawing.PointF(20, 60)
                );
                // ------------------------------------------

                // 2. CÁLCULO DE ESCALA Y DATOS

                // Extraer valores y calcular el máximo para la escala Y
                var valores = table.AsEnumerable()
                                   .Select(row => Convert.ToDecimal(row["Total Venta"]))
                                   .ToList();

                decimal maxValor = valores.Any() ? valores.Max() : 100m;

                // Mapeo: 400 unidades de ancho del gráfico / MaxValor de ventas
                float escalaHorizontal = chartAreaWidth / (float)maxValor;
                float barHeight = 20f; // Altura fija de cada barra
                float currentY = chartOrigin.Y + 40; // Empezar un poco más abajo

                // Colores para las barras (manual)
                PdfBrush[] brushes = { PdfBrushes.Blue, PdfBrushes.Green, PdfBrushes.Orange, PdfBrushes.Purple, PdfBrushes.Brown };
                int colorIndex = 0;

                // 3. DIBUJAR BARRAS Y ETIQUETAS

                foreach (DataRow row in table.Rows)
                {
                    string nombre = row["Nombre"].ToString();
                    float valor = (float)Convert.ToDecimal(row["Total Venta"]);

                    // a) Calcular el Ancho de la Barra
                    float barWidth = valor * escalaHorizontal;

                    // b) Definir el Rectángulo (Barra)
                    System.Drawing.RectangleF rectBarra = new System.Drawing.RectangleF(
                        chartOrigin.X,
                        currentY,
                        barWidth,
                        barHeight
                    );

                    // c) Dibujar la Barra (sin usar PdfChart, se usa DrawRectangle)
                    Graficos.DrawRectangle(brushes[colorIndex % brushes.Length], rectBarra);

                    // d) Dibujar la Etiqueta del Valor (ej: 1500)
                    Graficos.DrawString(
                        $"${valor:N0}",
                        fontLabel,
                        PdfBrushes.Black,
                        new System.Drawing.PointF(chartOrigin.X + barWidth + 5, currentY + 5)
                    );

                    // e) Dibujar la Etiqueta del Nombre del Cliente
                    Graficos.DrawString(
                        nombre,
                        fontLabel,
                        PdfBrushes.Black,
                        new System.Drawing.PointF(chartOrigin.X - 60, currentY + 5) // Desplazado a la izquierda
                    );

                    currentY += barHeight + 5f; // Mover a la siguiente posición
                    colorIndex++;
                }

                // 4. FINALIZAR
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