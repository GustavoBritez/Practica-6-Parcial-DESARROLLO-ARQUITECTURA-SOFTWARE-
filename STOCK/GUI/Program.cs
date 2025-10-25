using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ix0oFS8QJAw9HSQvXkVhQlBad1hJXGJWfFFpR2Nbek55flVHallVVBYiSV9jS3tSdkdgW35fd3BSQmlZWU91Xg ==");

            Application.Run(new Form1());
        }
    }
}
