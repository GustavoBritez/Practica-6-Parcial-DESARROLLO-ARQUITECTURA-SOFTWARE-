using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    [Table("EMPLEADO")]
    public class EmpleadoBE : PersonaBE
    {
        private int id_empleado;

        public int Id_Empleado { get => id_empleado; set => id_empleado = value; }

        public EmpleadoBE( int Id_Empleado , string nombre ,string telefono, string mail) : base(nombre, telefono, mail)
        {
            this.id_empleado = Id_Empleado;
        }
    }
}
