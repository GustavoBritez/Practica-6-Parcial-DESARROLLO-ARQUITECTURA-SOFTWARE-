namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class Producto
    {
        public Producto(string id) { codigo_prod = id; }
        
        public Producto(object[] ItemArray)
        {
            codigo_prod = ItemArray[0].ToString();
            ID_Empleado = Convert.ToInt32(ItemArray[1]);
            nombre = ItemArray[2].ToString();
            precio_venta = Convert.ToDecimal(ItemArray[3]);
            stock_actual = Convert.ToInt32(ItemArray[4]);
        }

        public string codigo_prod { get; set; }
        public int ID_Empleado { get; set; }
        public string nombre { get; set; }
        public decimal precio_venta { get; set; }
        public int stock_actual { get; set; }
    }
}