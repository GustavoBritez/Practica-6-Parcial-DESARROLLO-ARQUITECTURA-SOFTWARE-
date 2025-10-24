using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.PdfViewer;

namespace GUI
{
    public partial class REPORTE : Form
    {
        public REPORTE()
        {
            InitializeComponent();
        }

        public void TEST_PDF_VIEWER()
        {
            MONTOTO.BeginInvoke(new Action(() =>
            {
                PdfDocumentView pdfViewer = new PdfDocumentView();
                pdfViewer.Dock = DockStyle.Fill;
                this.Controls.Add(pdfViewer);
                pdfViewer.Load(@"C:\REPORTE.pdf");
            }));
        }
    }
}
