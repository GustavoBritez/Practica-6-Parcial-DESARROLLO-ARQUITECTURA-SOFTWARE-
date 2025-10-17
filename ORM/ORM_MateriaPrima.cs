using BE;
using ORM;

namespace ORM_MateriaPrima
{
    public class ORM_MateriaPrima
    {
        private miDbContext miDbContext = new();

        public List<MateriasPrimaBE> Obtener_Materias_Primas_ORM()
        {
            return miDbContext.Materias_Primas.ToList();
        }
        public void Agregar_MP(MateriasPrimaBE materiaprima)
        {
            try
            {
                miDbContext.Materias_Primas.Add(materiaprima);
                miDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar_MP(MateriasPrimaBE materiaprima)
        {
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
        }
    }
}
