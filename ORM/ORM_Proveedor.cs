using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace ORM
{
    public class ORM_Proveedor
    {
       /* private miDbContext _context = new();   

        public List<ProveedorBE> Obtener_Proveedores_ORM()
        {
            return _context.Proveedor.ToList();
        }   
        public void Alta(ProveedorBE proveedor)
        {
            try
            {
                _context.Proveedor.Add(proveedor);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void Baja(ProveedorBE proveedor)
        {
            try
            {
                var entity = _context.Proveedor.Find(proveedor.Id_Proveedor);
                if (entity != null)
                {
                    _context.Proveedor.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }   

        public void Modificar( ProveedorBE proveedormodificado )
        {
            var entity = _context.Proveedor.Find(proveedormodificado.Id_Proveedor);
            if ( entity != null )
            {
                entity.Nombre = proveedormodificado.Nombre;
                entity.Telefono = proveedormodificado.Telefono;
                entity.Mail = proveedormodificado.Mail; 
                _context.SaveChanges();
            }
        }   */
    }
}
