namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class Orden_Produccion
    {
        public Orden_Produccion(int orden)
        {
            ID_Orden = orden;
        }

        public Orden_Produccion(object[] pItemArray)
        {
            ID_Orden = Convert.ToInt32(pItemArray[0]);
            ID_Cliente = Convert.ToInt32(pItemArray[1]);
            ID_Materia = Convert.ToInt32(pItemArray[2]);
            Codigo_Prod = pItemArray[3].ToString();
            Cantidad_Prod = Convert.ToInt32(pItemArray[4]);
            Cantidad_Usada = Convert.ToInt32(pItemArray[5]);
            Fecha_Orden = Convert.ToDateTime(pItemArray[6]);
            Costo_Total_Orden = Convert.ToDecimal(pItemArray[7]);
            Estado = pItemArray[8].ToString();
        }

        public int ID_Orden {get; set;}
        public int ID_Materia{get;set;}
        public int ID_Cliente {get;set;}
        public string Codigo_Prod {get;set;}
        public int Cantidad_Usada {get;set;}
        public DateTime Fecha_Orden { get; set; }
        public int Cantidad_Prod { get; set; }
        public decimal Costo_Total_Orden { get; set; }
        public string Estado { get; set; }

    }
}