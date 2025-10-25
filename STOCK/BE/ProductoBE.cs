using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBE
    {
        private int id_producto;
        private string nombre;
        private decimal precio;
        private int cantidad;

        public int Id_Producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }


        public ProductoBE(int id_producto, string nombre, decimal precio, int cantidad)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
