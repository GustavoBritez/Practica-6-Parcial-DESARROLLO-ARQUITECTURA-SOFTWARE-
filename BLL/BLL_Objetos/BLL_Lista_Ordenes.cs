namespace BLL
{
    public class BLL_Lista_Ordenes : Iabmc<ListaOrdenesBE>
    {
        ORM_ListaOrdenes MP;

        public BLL_Lista_Ordenes()
        { MP = new ORM_ListaOrdenes(); }

        public void VerOrdenes(ListaOrdenesBE mp)
        {
            MP.Alta(mp);
        }
    }
}