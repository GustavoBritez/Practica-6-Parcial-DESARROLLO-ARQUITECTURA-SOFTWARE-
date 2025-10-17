using BE;
using Microsoft.EntityFrameworkCore;
using ORM;

namespace ORM_OrdenProduccion
{
    public class ORM_OrdenProduccion
    {
        private miDbContext _context = new();
        public List<OrdenProduccionBE> Ver_Estado_De_Orden()
        {
            return _context.Ordenes_Produccion.ToList();
        }

        public void Abrir_Orden_Produccion(OrdenProduccionBE ordenproduccion)
        {
            try
            {
                _context.Ordenes_Produccion.Add(ordenproduccion);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Cancelar_Orden_Produccion(OrdenProduccionBE ordenproduccion)
        {
            try
            {
                var entity = _context.Ordenes_Produccion.Find(ordenproduccion.Id_Orden);
                if (entity != null)
                {
                    _context.Ordenes_Produccion.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Modificar_Estado_Orden(OrdenProduccionBE ordenproduccionmodificado)
        {
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
        }
    }
}
