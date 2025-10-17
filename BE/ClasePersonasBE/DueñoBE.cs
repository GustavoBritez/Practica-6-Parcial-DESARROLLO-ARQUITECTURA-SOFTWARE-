using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    [Table("DUEÑO")]
    public class DueñoBE : PersonaBE
    {
        private int id_admin;

        public int Id_Admin { get => id_admin; set => id_admin = value; }

        public DueñoBE(int Id_Admin, string nombre, string telefono, string mail) : base(nombre, telefono, mail)
        {
            this.id_admin = Id_Admin;
        }
    }
}
