
using BE;
using ORM;

namespace ORM_Dueño
{
<<<<<<< HEAD
    public class ORM_Dueño
    {
/*<<<<<<< HEAD
        DataSet DS;
        Dueño_DAL AC;
        public ORM_Dueño() { AC = new Access(); DS = AC.TablaDueño();  }

        public void Alta(Dueño mp)
=======
        /// <summary>
        ///  Esta porqueria no la puedo instalar en la compu de la universidad, pero hay que instalar el NUGET
        ///  
        ///  using [     Microsoft.EntityFrameworkCore      ]
        ///  
        ///  Para que funcione el DbContext, fijate que cree una clase "miDbContext.cs" y debe heredar de DbContext
        ///  
        /// </summary>
        private miDbContext _context = new();
=======
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472

        public List<DueñoBE> Obtener_Dueños_ORM()
        {
            List<DueñoBE> listnew = new List<DueñoBE>();

            
            return listnew;
        }

        public void Alta(DueñoBE dueño)
        {
           
        }

        public void Baja(DueñoBE dueño)
        {
            
        }   

        public void Modificar( DueñoBE dueñomodificado )
        {
<<<<<<< HEAD
            var entity = _context.Dueños.Find(dueñomodificado.Id_Admin);
            if ( entity != null )
            {
                entity.Nombre = dueñomodificado.Nombre;
                entity.Telefono = dueñomodificado.Telefono;
                entity.Mail = dueñomodificado.Mail; 
            }
        }*/
    }
=======
            
        }
        
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
}

