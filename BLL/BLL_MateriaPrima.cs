namespace BLL
{
    public class BLL_MateriaPrima : Iabmc<MateriaPrima> 
    {
        ORM_MateriaPrima MP;

        public BLL_MateriaPrima()
        { MP = new ORM_MateriaPrima(); }

        public void Alta(MateriaPrima mp)
        {
            MP.Alta(mp);
        }

        public void Baja(MateriaPrima mp)
        {
            MP.Baja(mp);
        }
    }
}
