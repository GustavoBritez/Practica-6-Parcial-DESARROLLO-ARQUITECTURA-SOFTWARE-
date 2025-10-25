using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Materia_PrimaBE
    {
        private int id_materia_prima;
        private int id_proveedor;
        private string nombre;
        private decimal costo;
        private int cantidad;
        public int Id_Materia_Prima { get => id_materia_prima; set => id_materia_prima = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => costo; set => costo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public Materia_PrimaBE(int id_materia_prima, string nombre, decimal precio, int cantidad)
        {
            this.id_materia_prima = id_materia_prima;
            this.nombre = nombre;
            this.costo = precio;
            this.cantidad = cantidad;
        }
    }
}
