using ORM;
using BE;
using System.IO.MemoryMappedFiles;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Producto
    {
        private ORM_Productos mapper = new ORM_Productos();

        public void Agregar_Producto( ProductoBE newP )
        {
            mapper.Agregar_Producto(newP);
        }

        public void Eliminar_Producto( int id_producto )
        {
            mapper.Eliminar_Producto( id_producto );
        }

        public List<ProductoBE> Obtener_Productos()
        {
            return mapper.Obtener_lista_Productos();
        }
    }
}