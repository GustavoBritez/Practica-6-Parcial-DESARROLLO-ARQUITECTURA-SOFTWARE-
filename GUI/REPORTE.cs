using SYNC;
using Syncfusion.Pdf;
using System.Diagnostics;

namespace GUI
{
    public partial class REPORTE : Form
    {
        private PdfDocument newPDF = new();

        public REPORTE()
        {
            InitializeComponent();
        }

        private void BTN_REPORT_CLIENTE_Click(object sender, EventArgs e)
        {
            Class1 reporte = new Class1();
           
            PdfDocument doc = reporte.Generar_Reporte();


            Process.Start("Reporte_Clientes.pdf");
        }
    }
}
