using BE;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System;


namespace ORM
{
    public class ORM_Productos
    {
        private Access acceso = new Access();
        private List<ProductoBE> listaProducts;
        private string storedProcedure = "SP_PRODUCTO_CRUD";

        private string codigo_prod = "@CODIGO_PROD";
        private string nombre = "@NOMBRE";
        private string precio_venta = "@PRECIO_VENTA";  
        private string stock_actual = "@STOCK_ACTUAL";  

        public ORM_Productos()
        {
            listaProducts = Obtener_Productos_ROM();
        }

        public List<ProductoBE> Obtener_lista_Productos()
        {
            List<ProductoBE> listaOriginal = Cargar_Productos_Grilla();
            return listaOriginal;
        }

        private List<ProductoBE> Obtener_Productos_ROM()
        {
            List<ProductoBE> productos = new List<ProductoBE>();
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ACCION", System.Data.SqlDbType.NVarChar) { Value = "OBTENER"  }
            };

            DataTable dt = acceso.Leer(storedProcedure, sp);

            foreach (DataRow dr in dt.Rows) {

                ProductoBE mapeo = new ProductoBE(
                    dr["CODIGO_PROD"].ToString(), // En la columna DB ? se llama asi ?
                    dr["Nombre"].ToString(),  // En la columna DB ? se llama asi ?
                    Convert.ToDecimal(dr["Precio_Venta"]),  // En la columna DB ? se llama asi ?
                    Convert.ToDecimal(dr["Stock_Actual"]) // En la columna DB ? se llama asi ?
                    );
                productos.Add( mapeo );
            }
            return productos;
        }

        public List<ProductoBE> Cargar_Productos_Grilla()
        {
            return listaProducts;
        }

        public void Agregar_Producto(ProductoBE nuevoProducto)
        {
            try
            {
                    SqlParameter[] sp = new SqlParameter[]
                    {
                        new SqlParameter("@ACCION", "AGREGAR"),
                        new SqlParameter(codigo_prod, SqlDbType.NVarChar) { Value = nuevoProducto.Id_Producto},
                        new SqlParameter(nombre, SqlDbType.NVarChar) { Value = nuevoProducto.Nombre },
                        new SqlParameter(precio_venta, SqlDbType.Decimal) { Value = nuevoProducto.Precio},
                        new SqlParameter(stock_actual, SqlDbType.Int) { Value = Convert.ToInt32(nuevoProducto.Cantidad)},
                    };
                    acceso.Escribir(storedProcedure,sp);

            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Eliminar_Producto( int id_producto)
        {
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@ACCION","ELIMINAR" ),
                    new SqlParameter(codigo_prod, SqlDbType.Int) { Value = id_producto },
                };
                acceso.Escribir(storedProcedure,sp);
            }
            catch(Exception ex )
            { 
                throw new Exception(ex.Message);
            }
        }

        public void Modificar_Producto( ProductoBE producto_modificado)
        {

            var productoOriginal = this.listaProducts.FirstOrDefault(c => c.Id_Producto == producto_modificado.Id_Producto);
            
            productoOriginal.Precio = producto_modificado.Precio;
            productoOriginal.Cantidad = producto_modificado.Cantidad;
            productoOriginal.Nombre = producto_modificado.Nombre;

            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ACCION","MODIFICAR"),
                new SqlParameter(codigo_prod, SqlDbType.Int) {Value = productoOriginal.Id_Producto},
                new SqlParameter(nombre, SqlDbType.NVarChar) { Value = productoOriginal.Nombre},
                new SqlParameter(precio_venta,SqlDbType.Decimal) { Value = productoOriginal.Precio},
                new SqlParameter(stock_actual,SqlDbType.Int) { Value = productoOriginal.Cantidad}
            };

            acceso.Escribir(storedProcedure,sp);

        }
    }
}