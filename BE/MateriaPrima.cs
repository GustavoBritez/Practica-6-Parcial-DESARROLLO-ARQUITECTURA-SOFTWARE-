namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class MateriasPrima
    {
        public MateriasPrima(int x) { ID = x;}

        public MateriasPrima(object[] pItemArray, Proveedores P)
        {
            ID = Convert.ToInt32(pItemArray[0]);
            Nombre = pItemArray[1].ToString();
            CantStock = Convert.ToInt32(pItemArray[2]);
            CostoUni = Convert.ToInt32(pItemArray[3]);
            Prove = P;
        }

        public int ID {get; set;}
        public string Nombre {get;set;}
        public int CantStock {get;set;}
        public int CostoUni {get;set;}
        public Proveedores Prove {get;set;}
    }
}