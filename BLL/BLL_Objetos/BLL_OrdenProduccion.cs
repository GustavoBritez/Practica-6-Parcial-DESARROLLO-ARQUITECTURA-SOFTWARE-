namespace BLL
{
    public class BLL_OrdenProduccion : Iabmc<Orden_Produccion> 
    {
        ORM_OrdenProduccion MP;

        public BLL_OrdenProduccion()
        { MP = new ORM_OrdenProduccion(); }

        public void Abrir_Orden_produccion(Orden_Produccion mp)
        {
            MP.Abrir_Orden_produccion(mp);
        }

        public void Cancelar_Orden_Produccion(Orden_Produccion mp)
        {
            MP.Cancelar_Orden_Produccion(mp);
        }

        public void Modificar_Estado_Orden(Orden_Produccion mp)
        {
            MP.Modificar_Estado_Orden(mp);
        }
        public void Ver_Estado_Orden(Orden_Produccion mp)
        {
            MP.Ver_Estado_Orden(mp);
        }
    }
}