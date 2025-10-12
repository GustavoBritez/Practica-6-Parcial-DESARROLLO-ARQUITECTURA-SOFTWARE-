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
            ID_Materia = Convert.Toint32(pItemArray[1]);
            ID_Cliente = Convert.Toint32(pItemArray[2]);
            FechaOrden = Convert.ToDateTime(pItemArray[3]);
            CantProducto = Convert.ToInt32(pItemArray[4]);
            CantTotal = Convert.ToInt32(pItemArray[5]);
            Estado = pItemArray[6].ToString();
        }

        public int ID { get; set; }
        public int ID_Materia { get; set; }
        public int ID_Cliente { get; set; }
        public date FechaOrden {get;set;}
        public int CantProducto { get; set; }
        public decimal CantTotal { get; set; }
        public string Estado { get; set; }
    }
}