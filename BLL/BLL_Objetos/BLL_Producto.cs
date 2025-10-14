namespace BLL
{
    public class BLL_Producto : Iabmc<ProductoBE>
    {
        ORM_Productos MP;

        public BLL_Producto()
        { MP = new ORM_Producto(); }

        public void Alta(ProductoBE mp)
        {
            MP.Alta(mp);
        }

        public void Baja(ProductoBE mp)
        {
            MP.Baja(mp);
        }

        public void Update(ProductoBE mp)
        {
            MP.Update(mp);
        }
    }
}