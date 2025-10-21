using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace ORM
{
    public class ORM_Proveedor
<<<<<<< HEAD
    {
       /* private miDbContext _context = new();   
=======
    {  
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472

        public List<ProveedorBE> Obtener_Proveedores_ORM()
        {
             List<ProveedorBE> listnew = new List<ProveedorBE>();

            
            return listnew;
        }   
        public void Alta(ProveedorBE proveedor)
        {
           
        }

        public void Baja(ProveedorBE proveedor)
        {
            
        }   

        public void Modificar( ProveedorBE proveedormodificado )
        {
<<<<<<< HEAD
            var entity = _context.Proveedor.Find(proveedormodificado.Id_Proveedor);
            if ( entity != null )
            {
                entity.Nombre = proveedormodificado.Nombre;
                entity.Telefono = proveedormodificado.Telefono;
                entity.Mail = proveedormodificado.Mail; 
                _context.SaveChanges();
            }
        }   */
=======
            
        }   
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
    }
}
