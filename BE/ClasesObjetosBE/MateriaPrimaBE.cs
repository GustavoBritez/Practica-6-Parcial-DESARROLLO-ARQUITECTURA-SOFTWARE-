namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class MateriasPrimaBE
    {
        public MateriasPrimabE(int x) 
        { ID = x; }

        public MateriasPrimaBE(object[] pItemArray)
        {
            ID = Convert.ToInt32(pItemArray[0]);
            Nombre = pItemArray[1].ToString();
            CantStock = Convert.ToInt32(pItemArray[2]);
            CostoUni = Convert.ToDecimal(pItemArray[3]);
            ID_Prove = Convert.ToInt32(pItemArray[4]);
        }

        public int ID { get => ID; set => ID = value; }
        public string Nombre { get => Nombre; set => Nombre = value; }
        public int CantStock { get => CantStock; set => CantStock = value; }
        public int CostoUni { get => CostoUni; set => CostoUni = value; }
        public int ID_Prove { get => ID_Prove; set => ID_Prove = value; }


        private int ID;
        private string Nombre;
        private int CantStock;
        private decimal CostoUni;
        private int ID_Prove;
    }
}