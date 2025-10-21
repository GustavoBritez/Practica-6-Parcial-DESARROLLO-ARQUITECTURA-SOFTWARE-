using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace ORM
{
    public class ORM_Empleado
    {
        /*private miDbContext _context = new();

        public List<EmpleadoBE> Obtener_Empleados_ORM()
        {
            return _context.Empleados.ToList();
        }   
        public void Alta(EmpleadoBE empleado)
        {
            try
            {
                _context.Empleados.Add(empleado);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }   
        public void Baja(EmpleadoBE empleado)
        {
            try
            {
                var entity = _context.Empleados.Find(empleado.Id_Empleado);
                if (entity != null)
                {
                    _context.Empleados.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }
        public void modificar( EmpleadoBE empleadomodificado )
        {
            var entity = _context.Empleados.Find(empleadomodificado.Id_Empleado);
            if ( entity != null )
            {
                entity.Nombre = empleadomodificado.Nombre;
                entity.Telefono = empleadomodificado.Telefono;
                entity.Mail = empleadomodificado.Mail; 
                _context.SaveChanges();
            }
        }   */
    }
}
