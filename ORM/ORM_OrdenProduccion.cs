using BE;
using ORM;

namespace ORM_OrdenProduccion
{
    public class ORM_OrdenProduccion
    {
<<<<<<< HEAD
        /*private miDbContext _context = new();
=======
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
        public List<OrdenProduccionBE> Ver_Estado_De_Orden()
        {
            List<OrdenProduccionBE> listnew = new List<OrdenProduccionBE>();

            
            return listnew;
        }

        public void Abrir_Orden_Produccion(OrdenProduccionBE ordenproduccion)
        {
            
        }
        public void Cancelar_Orden_Produccion(OrdenProduccionBE ordenproduccion)
        {
            
        }

        public void Modificar_Estado_Orden(OrdenProduccionBE ordenproduccionmodificado)
        {
<<<<<<< HEAD
            var entity = _context.Ordenes_Produccion.Find(ordenproduccionmodificado.Id_Orden);
            if ( entity != null)
            {
                entity.Id_Materia = ordenproduccionmodificado.Id_Materia;
                entity.Id_Cliente = ordenproduccionmodificado.Id_Cliente;
                entity.Codigo_Prod = ordenproduccionmodificado.Codigo_Prod;
                entity.Fecha_Orden = ordenproduccionmodificado.Fecha_Orden;
                entity.Cantidad_Usada = ordenproduccionmodificado.Cantidad_Usada;
                entity.Cantidad_Prod = ordenproduccionmodificado.Cantidad_Prod;
                entity.Costo_Total_Orden = ordenproduccionmodificado.Costo_Total_Orden;
                entity.Estado = ordenproduccionmodificado.Estado;

                _context.SaveChanges();
            }
        }*/
=======
            
        }
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
    }
}
