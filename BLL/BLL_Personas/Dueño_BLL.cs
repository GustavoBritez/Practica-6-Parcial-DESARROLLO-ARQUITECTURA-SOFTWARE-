using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM;
using BE;

namespace BLL.BLL_Personas
{
    public class Dueño_BLL
    {
        ORM_Dueño mapper = new ORM_Dueño();
        public void Agregar_Dueño(DueñoBE newDueño)
        {
            try
            {
                mapper.Alta_Dueño(newDueño);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar_Dueño(int id_dueño)
        {
            try
            {
                mapper.Bajar_dueño(id_dueño);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Modificar_Dueño(DueñoBE dueño)
        {
            try
            {
                mapper.Modificar_Dueño(dueño);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DueñoBE> ObtenerDueños()
        {
            try
            {
                return mapper.Cargar_Dueños_Grilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
