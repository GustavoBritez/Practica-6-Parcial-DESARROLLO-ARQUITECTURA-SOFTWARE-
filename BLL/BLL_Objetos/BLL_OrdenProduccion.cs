using ORM;
using BE;

namespace BLL
{
    public class BLL_OrdenProduccion 
    {
        ORM_OrdenProduccion MP;

        public BLL_OrdenProduccion()
        { MP = new ORM_OrdenProduccion(); }

        public void Abrir_Orden_produccion(Orden_ProduccionBE mp)
        {
            MP.Abrir_Orden_produccion(mp);
        }

        public void Cancelar_Orden_Produccion(Orden_ProduccionBE mp)
        {
            MP.Cancelar_Orden_Produccion(mp);
        }

        public void Modificar_Estado_Orden(Orden_ProduccionBE mp)
        {
            MP.Modificar_Estado_Orden(mp);
        }
        public void Ver_Estado_Orden(Orden_ProduccionBE mp)
        {
            MP.Ver_Estado_Orden(mp);
        }
    }
}