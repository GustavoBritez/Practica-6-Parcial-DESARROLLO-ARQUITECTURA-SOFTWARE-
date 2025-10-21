
using BE;
using ORM;
namespace ORM_OrdenDetalle
{
    public class ORM_OrdenDetalle
    {
       /* private miDbContext _context = new();


        /// <summary>
        /// ADS
        /// Composicion
        ///  No hay un correlato de ciclos de vida por que el usuario,
        ///  
        /// Agregacion, debe poner un constructor al usuario que cuando lo instancie se instancie el otro objeto dentro de ese constructor
        /// 
        /// Asociacion, si el usuario usa perfiles con 0...1 
        /// </summary>
        /// <returns></returns>

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
        }   */

    }
}