using BE;
using Microsoft.EntityFrameworkCore;
using ORM;

namespace ORM_Productos
{
    public class ORM_Productos
    {
        private  miDbContext _context = new();

        // No tenemos aqui un ACTUALIZAR si usamos ORM
        public List<ProductoBE> Obtener_Productos_ORM()
        {
            return _context.Productos.ToList();
        }
        public void AgregarProducto(ProductoBE producto)
        {
            try
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EliminarProducto(ProductoBE producto)
        {
            try
            {
                var entity = _context.Productos.Find(producto.Codigo_Prod);
                if (entity != null)
                {
                    _context.Productos.Remove(entity);
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