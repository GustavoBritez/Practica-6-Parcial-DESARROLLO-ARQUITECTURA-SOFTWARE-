namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class Producto
    {
        public Producto(int id)
        { ID = id;}

        public Producto(object[] pItemArray)
        {
            ID = Convert.Toint32(pItemArray[0]);
            Nombre = pItemArray[1].ToString();
            PrecioUniVenta = Convert.ToDecimal(pItemArray[2]);
            CantStock = Convert.ToDecimal(pItemArray[3]);
        }

        public int id {get;set;}
        public string Nombre {get;set;}
        public decimal PrecioUniVenta {get;set;}
        public decimal CantStock {get;set;}
    }
}
