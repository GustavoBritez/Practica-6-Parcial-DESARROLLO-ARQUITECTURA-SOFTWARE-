namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class MateriasPrima
    {
        public MateriasPrima(int x) 
        { ID = x; }

        public MateriasPrima(object[] pItemArray)
        {
            ID = Convert.ToInt32(pItemArray[0]);
            Nombre = pItemArray[1].ToString();
            CantStock = Convert.ToInt32(pItemArray[2]);
            CostoUni = Convert.ToInt32(pItemArray[3]);
            ID_Prove = Convert.ToInt32(pItemArray[4]);
        }

        public int ID {get; set;}
        public string Nombre {get;set;}
        public int CantStock {get;set;}
        public int CostoUni {get;set;}
        public int ID_Prove {get;set;}
    }
}