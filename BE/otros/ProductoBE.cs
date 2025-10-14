namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class ProductoBE
    {
        private string codigo_prod;
        private int id_empleado;
        private string nombre;
        private decimal precio_venta;
        private int stock_actual;

        public string Codigo_Prod { get => codigo_prod; set => codigo_prod = value; }
        public int Id_Empleado { get => id_empleado; set => id_empleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio_Venta { get => precio_venta; set => precio_venta = value; }
        public int Stock_Actual { get => stock_actual; set => stock_actual = value; }

        public ProductoBE(string codigo_prod, int id_empleado, string nombre, decimal precio_venta, int stock_actual)
        {
            this.codigo_prod = codigo_prod;
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.precio_venta = precio_venta;
            this.stock_actual = stock_actual;
        }
    }
}
