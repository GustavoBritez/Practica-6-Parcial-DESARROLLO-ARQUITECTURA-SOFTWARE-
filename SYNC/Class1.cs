using Microsoft.Data.SqlClient;
using ORM;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Grid;
using System.Data;
namespace SYNC
{
    public class Class1
    {
        private Access acceso = new();
        private string storedprocedure = "SP_CLIENTE_CRUD";

        public PdfDocument Generar_Reporte()
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ACCION" , "OBTENER"),
            };

            DataTable dt = acceso.Leer(storedprocedure, sp);

            PdfDocument doc = new();

            PdfPage page = doc.Pages.Add();

            PdfGrid gridtest = new PdfGrid();

            gridtest.DataSource = dt;   
            gridtest.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);

            gridtest.Draw(page, new PointF(10, 10));

            doc.Save("Reporte_Clientes.pdf");

            doc.Close(true);

            return doc;

        }
    }
}