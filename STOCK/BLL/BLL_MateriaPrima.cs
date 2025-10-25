using ORM;
using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BLL
{
    public class BLL_MateriaPrima 
    {
        ORM_Materia_Prima mapper = new ORM_Materia_Prima();
        public void Agregar_MateriaPrima(Materia_PrimaBE newMateriaPrima, int id_proveedor)
        {
            try
            {
                mapper.Alta_Materia_Prima(newMateriaPrima, id_proveedor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar_MateriaPrima(int id_materiaPrima)
        {
            try
            {
                mapper.Baja_Materia_Prima(id_materiaPrima);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Materia_PrimaBE> ObtenerMateriaPrimas()
        {
            try
            {
                return mapper.Cargar_Materia_Prima_Grilla();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
