using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace GUI
{
    public partial class Control_Personalizado_Fecha : UserControl
    {
        private ClienteBE newCliente {  get; set; }
        
        public string Nombre
        {
            get => Label_Nombre.Text;
            set => Label_Nombre.Text = value;
        }

        public string Descripcion
        {
            get => RTB_Descripcion.Text;
            set => RTB_Descripcion.Text = value;
        }

        public string Telefono
        {
            get => Label_Dni.Text;
            set => Label_NRO_Dni.Text = value;
        }

        public Control_Personalizado_Fecha()
        {
            InitializeComponent();
        }

        public void setInformacionPokemon()
        {
            Label_Descripcion.Text = "testeamos la descripcion";
            Label_Nombre.Text = newCliente.Nombre;
            Label_NRO_Dni.Text = newCliente.Id_Cliente.ToString();
        }
    }
}
