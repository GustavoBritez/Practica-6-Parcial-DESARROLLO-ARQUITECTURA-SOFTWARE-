using BLL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class REPORTE : Form
    {
        private BLL_SYNC SYNC = new BLL_SYNC();

        public REPORTE()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();


            /// Hay que pasar los datos de la LISTA PRODUCTOS a esta tabla 
            dt.Columns.Add("Producto");
            dt.Columns.Add("Cantidad");

            MemoryStream MS = SYNC.GenerarReportes(dt);

            if (pdfDocumentView1 != null && !pdfDocumentView1.IsDisposed )
            {
                pdfDocumentView1.Unload();
                pdfDocumentView1.Load(MS);
                pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitPage;
            }



        }
    }
}
