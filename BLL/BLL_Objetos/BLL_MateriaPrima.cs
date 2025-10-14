namespace BLL
{
    public class BLL_MateriaPrima : Iabmc<MateriaPrimaBE> 
    {
        ORM_MateriaPrima MP;

        public BLL_MateriaPrima()
        { MP = new ORM_MateriaPrima(); }

        public void Alta(MateriaPrimaBE mp)
        {
            MP.Alta(mp);
        }

        public void Baja(MateriaPrimaBE mp)
        {
            MP.Baja(mp);
        }
    }
}
