using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClienteBE : PersonaBE
    {
        private int id_cliente;

        public int Id_Cliente { get => id_cliente; set => id_cliente = value; } 

        public ClienteBE(int id_cliente, string nombre ,string telefono , string mail ) : base(nombre,telefono,mail) 
        {
            this.id_cliente = id_cliente;
        }
    }
}
