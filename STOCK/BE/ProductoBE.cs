using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBE
    {
        private string id_producto;
        private string nombre;
        private decimal precio;
        private decimal cantidad;

        public string Id_Producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Cantidad { get => cantidad; set => cantidad = value; }


        public ProductoBE(string id_producto, string nombre, decimal precio, decimal cantidad)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
    }
}
