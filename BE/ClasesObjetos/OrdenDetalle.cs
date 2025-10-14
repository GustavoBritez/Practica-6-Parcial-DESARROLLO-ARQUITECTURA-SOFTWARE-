namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class OrdenDetalle
    {
        public OrdenDetalle(int orden)
        {
            ID_Detalle = orden;
        }

        public OrdenDetalle(object[] pItemArray)
        {
            ID_Detalle = Convert.ToInt32(pItemArray[0]);
            ID_Dueño = Convert.ToInt32(pItemArray[1]);
            ID_Orden = Convert.ToInt32(pItemArray[2]);
        }

        public int ID_Detalle {get; set;}
        public int ID_Dueño {get;set;}
        public int ID_Orden {get;set;}
    }
}