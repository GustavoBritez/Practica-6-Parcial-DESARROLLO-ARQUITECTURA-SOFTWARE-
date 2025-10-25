using ORM;
using BE;
using System.IO.MemoryMappedFiles;

namespace BLL
{
    public class BLL_Producto
    {
        private ORM_Productos maper = new();

        public List<object> Retornar_Lista_productos()
        {
            return maper.Obtener_lista_Productos();
        }

        public void Agregar_Productos( ProductoBE nuevoproducto )
        {
            maper.Agregar_Producto(nuevoproducto);
        }
        public void Eliminar_Producto( int id_producto )
        {
            maper.Eliminar_Producto(id_producto);
        }
        public void Modificar_Producto( ProductoBE producto_modificado )
        {
            maper.Modificar_Producto(producto_modificado);
        }
    }
}