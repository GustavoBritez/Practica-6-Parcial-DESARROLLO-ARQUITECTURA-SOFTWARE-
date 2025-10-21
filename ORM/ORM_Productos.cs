using BE;
using Microsoft.EntityFrameworkCore;
using ORM;

namespace ORM_Productos
{
    public class ORM_Productos
    {
        
        // No tenemos aqui un ACTUALIZAR si usamos ORM
        public List<ProductoBE> Obtener_Productos_ORM()
        {
             List<ProductoBE> listnew = new List<ProductoBE>();

            
            return listnew;
        }
        public void AgregarProducto(ProductoBE producto)
        {
           
        }
        public void EliminarProducto(ProductoBE producto)
        {
           
        }
 
    }
}