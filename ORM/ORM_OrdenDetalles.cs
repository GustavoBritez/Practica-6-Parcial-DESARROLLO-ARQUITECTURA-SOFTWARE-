
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

=======
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
        public List<OrdenDetalleBE> Obtener_Ordenes_Detalles_ORM()
        {
            List<OrdenDetalleBE> listnew = new List<OrdenDetalleBE>();

            
            return listnew;
        }
        public void Alta(OrdenDetalleBE ordendetalle)
        {
        }
        public void Baja(OrdenDetalleBE ordendetalle)
        {
<<<<<<< HEAD
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