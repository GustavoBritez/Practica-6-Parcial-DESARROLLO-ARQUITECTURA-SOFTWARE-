using Microsoft.EntityFrameworkCore;
using BE;
using ORM;
namespace ORM_OrdenDetalle
{
    public class ORM_OrdenDetalle
    {
        private miDbContext _context = new();

        public List<OrdenDetalleBE> Obtener_Ordenes_Detalles_ORM()
        {
            return _context.OrdenDetalle.ToList();
        }
        public void Alta(OrdenDetalleBE ordendetalle)
        {
            try
            {
                _context.OrdenDetalle.Add(ordendetalle);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Baja(OrdenDetalleBE ordendetalle)
        {
            try
            {
                var entity = _context.OrdenDetalle.Find(ordendetalle.Id_Detalle);
                if (entity != null)
                {
                    _context.OrdenDetalle.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   

    }
}