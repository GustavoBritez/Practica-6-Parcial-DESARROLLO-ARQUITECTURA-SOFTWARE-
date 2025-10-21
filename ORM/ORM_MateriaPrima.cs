using BE;
using ORM;

namespace ORM_MateriaPrima
{
    public class ORM_MateriaPrima
    {
<<<<<<< HEAD
        /*private miDbContext miDbContext = new();

=======
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
        public List<MateriasPrimaBE> Obtener_Materias_Primas_ORM()
        {
           List<MateriasPrimaBE> listnew = new List<MateriasPrimaBE>();

            
            return listnew;
        }
        public void Agregar_MP(MateriasPrimaBE materiaprima)
        {
            
        }
        public void Eliminar_MP(MateriasPrimaBE materiaprima)
        {
<<<<<<< HEAD
            try
            {
                var entity = miDbContext.Materias_Primas.Find(materiaprima.Id_Materia);
                if (entity != null)
                {
                    miDbContext.Materias_Primas.Remove(entity);
                    miDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
=======
           
        }
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
    }
}
