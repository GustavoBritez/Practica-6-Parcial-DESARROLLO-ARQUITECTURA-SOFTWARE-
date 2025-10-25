using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System.IO;
using System.Drawing;
using System.Data;
using Microsoft.Data.SqlClient;
using ORM; 
using BE; 
using System.Reflection; 

namespace Syncfusion
{
    internal class Report
    {
        Access acceso = new Access();
        string storedProcedure = "SP_CLIENTE_CRUD";

        public MemoryStream GenerarReporteClientes() // Renombramos a algo más descriptivo
        {
            // 1. Obtener datos de la base de datos (Tu código)
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter ( "@ACCION" , "OBTENER" )
            };
            DataTable dtClientes = acceso.Leer(storedProcedure, sp);

            // 2. Generar el PDF
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;

                // Título
                PdfFont titleFont = new PdfStandardFont(PdfFontFamily.Helvetica, 18, PdfFontStyle.Bold);
                graphics.DrawString("Reporte de Clientes", titleFont, PdfBrushes.DarkBlue, new PointF(10, 10));

                // Dibujar la Tabla
                PdfLightTable pdfTable = new PdfLightTable();

                // Mapeo: Usamos el DataTable directamente como DataSource (¡lo más fácil!)
                pdfTable.DataSource = dtClientes;

                // Estilos básicos
                pdfTable.Style.DefaultStyle.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                pdfTable.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);

                // Dibuja la tabla en la página (iniciando en Y=50)
                pdfTable.Draw(page, new PointF(10, 50));

                // 3. Guardar en MemoryStream y devolver
                MemoryStream stream = new MemoryStream();
                document.Save(stream);
                stream.Position = 0; // Resetear la posición para que el visor lo lea

                return stream;
            }
        }
    }
}
