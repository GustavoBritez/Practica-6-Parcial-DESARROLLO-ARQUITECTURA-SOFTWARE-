using System.Formats.Tar;

namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class OrdenProduccion
    {
        public OrdenProduccion(int id)
        { ID = id; }

        public OrdenProduccion(object[] pItemArray)
        {
            ID = Convert.Toint32(pItemArray[0]);
            FechaOrden = Convert.ToDateTime(pItemArray[1]);
            ID_Producto = Convert.ToInt32(pItemArray[2]);
            CantProducto = Convert.ToInt32(pItemArray[3]);
        }

        public int ID {get;set;}
        public date FechaOrden {get;set;}
        public int ID_Producto {get;set;}
        public int CantProducto {get;set;}
    }
}