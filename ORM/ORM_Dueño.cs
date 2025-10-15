
using BE;
using ORM;

namespace ORM_Dueño
{
    public class ORM_Dueño
    {
        /// <summary>
        ///  Esta porqueria no la puedo instalar en la compu de la universidad, pero hay que instalar el NUGET
        ///  
        ///  using [     Microsoft.EntityFrameworkCore      ]
        ///  
        ///  Para que funcione el DbContext, fijate que cree una clase "miDbContext.cs" y debe heredar de DbContext
        ///  
        /// </summary>
        private miDbContext _context = new();

        public List<DueñoBE> Obtener_Dueños_ORM()
        {
            return _context.Dueños.ToList();
        }

        public void Alta(DueñoBE dueño)
        {
            try
            {
                _context.Dueños.Add(dueño);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public void Baja(DueñoBE dueño)
        {
            try
            {
                var entity = _context.Dueños.Find(dueño.Id_Admin);
                if (entity != null)
                {
                    _context.Dueños.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }   

        public void Modificar( DueñoBE dueñomodificado )
        {
            var entity = _context.Dueños.Find(dueñomodificado.Id_Admin);
            if ( entity != null )
            {
                entity.Nombre = dueñomodificado.Nombre;
                entity.Telefono = dueñomodificado.Telefono;
                entity.Mail = dueñomodificado.Mail; 
            }
        }
    }
}
