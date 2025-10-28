using BE;
using BLL;
using Syncfusion.Windows.Forms.PdfViewer;
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
        string rutacompleta = Path.Combine(
            Application.StartupPath,
            "Reporte_Ventas_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf");

        private MemoryStream reportestream = null;

        public REPORTE()
        {
            InitializeComponent();
        }

        private DataTable ObtenerTablaProductosAgrupados()
        {
            // Lógica de SelectMany y GroupBy
            List<ProductoBE> ver_DATOS = Lista_S.ListaClientesCarritos.SelectMany(s => s.Retonar_Productos()).ToList();

            var datos_Agrupados = ver_DATOS
                .GroupBy(v => v.Nombre)
                .Select(
                prod => new
                {
                    Nombre_Producto = prod.Key,
                    Cantiad_Producto = prod.Sum(p => p.Cantidad)
                })
                .ToList();

            // Creación del DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Total Venta", typeof(decimal));

            foreach (var newP in datos_Agrupados)
            {
                dt.Rows.Add(newP.Nombre_Producto, newP.Cantiad_Producto);
            }
            return dt;
        }

        private void button2_Click(object sender, EventArgs e) 
        {

            /// Hay que pasar los datos de la LISTA PRODUCTOS a esta tabla 
            DataTable dt = ObtenerTablaProductosAgrupados();

            reportestream = SYNC.GenerarReportes_BARRA(dt);

            
            if (pdfDocumentView1 != null && !pdfDocumentView1.IsDisposed )
            {
                pdfDocumentView1.Unload();
                pdfDocumentView1.Load(reportestream);
                pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /// Hay que pasar los datos de la LISTA PRODUCTOS a esta tabla 
            DataTable dt = ObtenerTablaProductosAgrupados();

            reportestream = SYNC.GenerarReporte_TORTA(dt);

            if (pdfDocumentView1 != null && !pdfDocumentView1.IsDisposed)
            {
                pdfDocumentView1.Unload();
                pdfDocumentView1.Load(reportestream);
                pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            }

        }

        private void BTN_GUARDAR_PDF_Click(object sender, EventArgs e)
        {

            string rutaCarpeta = Application.StartupPath;
            string nombreArchivoUnico = "Reporte_Ventas_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivoUnico);

            try
            {
                reportestream.Position = 0;

                File.WriteAllBytes(rutaCompleta, reportestream.ToArray());

                MessageBox.Show($"Se generó con ÉXITO el reporte en:\n{rutaCompleta}", "Guardado Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en disco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}