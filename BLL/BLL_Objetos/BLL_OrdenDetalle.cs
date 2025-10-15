using ORM;
using BE;

namespace BLL
{
    public class BLL_OrdenDetalle 
    {
        ORM_OrdenDetalle MP;

        public BLL_OrdenDetalle()
        { MP = new ORM_OrdenDetalle(); }

        public void Generar_Orden_Detalle(OrdenDetalleBE mp)
        {
            MP.Generar_Orden_Detalle(mp);
        }

    }
}