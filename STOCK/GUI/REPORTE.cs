using BE;
using BLL;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class REPORTE : Form
    {
        private BLL_SYNC SYNC = new BLL_SYNC();

        private string rutaaplicacion = Application.StartupPath;
        private string nombreArchivo = "Reporte_Ventas_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf";

        string rutacompleta = System.IO.Path.Combine(
            Application.StartupPath,
            "Reporte_Ventas_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");

        public REPORTE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            List<ProductoBE> ver_DATOS = Lista_S.ListaClientesCarritos.SelectMany(s => s.Retonar_Productos()).ToList();

            var datos_Agrupados = ver_DATOS
                .GroupBy(v => v.Nombre)
                .Select( 
                prod => new
                {
                    Nombre_Producto = prod.Key,
                    Cantiad_Producto = prod.Sum ( p => p.Cantidad )
                }
                ).ToList();

            /// Hay que pasar los datos de la LISTA PRODUCTOS a esta tabla 
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre",typeof(string));
            dt.Columns.Add("Total Venta", typeof(decimal));

            foreach ( var newP in datos_Agrupados )
            {
                dt.Rows.Add( newP.Nombre_Producto , newP.Cantiad_Producto );
            }

            MemoryStream MS = SYNC.GenerarReportes_BARRA(dt);

            File.WriteAllBytes(rutacompleta,MS.ToArray());

            MessageBox.Show($"Se genero con EXITO el reporte en {rutacompleta}");

            if (pdfDocumentView1 != null && !pdfDocumentView1.IsDisposed )
            {
                pdfDocumentView1.Unload();
                pdfDocumentView1.Load(MS);
                pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ProductoBE> ver_DATOS = Lista_S.ListaClientesCarritos.SelectMany(s => s.Retonar_Productos()).ToList();

            var datos_Agrupados = ver_DATOS
                .GroupBy(v => v.Nombre)
                .Select(
                prod => new
                {
                    Nombre_Producto = prod.Key,
                    Cantiad_Producto = prod.Sum(p => p.Cantidad)
                }
                ).ToList();

            /// Hay que pasar los datos de la LISTA PRODUCTOS a esta tabla 
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Total Venta", typeof(decimal));

            foreach (var newP in datos_Agrupados)
            {
                dt.Rows.Add(newP.Nombre_Producto, newP.Cantiad_Producto);
            }

            MemoryStream MS = SYNC.GenerarReporte_TORTA(dt);

            File.WriteAllBytes(rutacompleta, MS.ToArray());

            MessageBox.Show($"Se genero con EXITO el reporte en {rutacompleta}");

            if (pdfDocumentView1 != null && !pdfDocumentView1.IsDisposed)
            {
                pdfDocumentView1.Unload();
                pdfDocumentView1.Load(MS);
                pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            }

        }
    }
}
