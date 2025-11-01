using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VALIDACION;
namespace GUI
{
    public partial class Logeo : Form
    {
        public Logeo()
        {
            InitializeComponent();
        }
        Validar_Persona VP = new Validar_Persona(); 
        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_Contraseña.Text;
                string contrasenia = txt_Contraseña.Text;

                VP.Validar_Nombre(nombre);
                VP.Validar_Mail(contrasenia);



            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
