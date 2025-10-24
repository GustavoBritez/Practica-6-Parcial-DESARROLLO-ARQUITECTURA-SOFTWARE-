using System.ComponentModel.DataAnnotations.Schema;
namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    [Table("PRODUCTO")]
    public class ProductoBE
    {
        private int id_producto;
        private string nombre;
        private decimal precio;
        private int cantidad;

        public int Id_Producto { get => this.id_producto; set => this.id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public ProductoBE(int codigo_prod, string nombre, decimal precio_venta, int cantidad_)
        {
            this.id_producto = codigo_prod;
            this.nombre = nombre;
            this.precio = precio_venta;
            this.cantidad = cantidad_;
        }
    }
}
