using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class EmpleadoBE
    {
        private int id_materia;
        private int id_proveedor;
        private string nombre;
        private int stock;
        private decimal costo_venta;

        public int Id_Materia { get => id_materia; set => id_materia = value; }
        public int Id_Proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal Costo_Venta { get => costo_venta; set => costo_venta = value; }
    }
}
