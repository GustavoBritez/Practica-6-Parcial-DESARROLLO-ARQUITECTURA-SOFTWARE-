namespace BLL
{
    public class BLL_MateriaPrima : Iabmc<OrdenDetalleBE>
    {
        ORM_OrdenDetalle MP;

        public BLL_MateriaPrima()
        { MP = new ORM_OrdenDetalle(); }

        public void Alta(OrdenDetalleBE mp)
        {
            MP.Generar_Orden_Detalle(mp);
        }

    }
}