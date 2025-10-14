namespace BLL
{
    public class BLL_Producto : Iabmc<Producto>
    {
        ORM_Producto MP;

        public BLL_Producto()
        { MP = new ORM_Producto(); }

        public void Alta(Producto mp)
        {
            MP.Alta(mp);
        }

        public void Baja(Producto mp)
        {
            MP.Baja(mp);
        }

        public void Update(Producto mp)
        {
            MP.Update(mp);
        }
    }
}