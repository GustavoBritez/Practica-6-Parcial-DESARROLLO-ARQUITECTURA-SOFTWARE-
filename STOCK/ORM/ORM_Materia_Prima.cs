using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ORM_Materia_Prima
    {
        public List<Materia_PrimaBE> Materia_Prima;
        Access acceso = new Access();

        private string storedProcedure = "SP_MATERIA_CRUD";

        private string materia_prima = "@ID_MATERIA_PRIMA";
        private string nombre = "@NOMBRE";
        private string precio_venta = "@PRECIO_VENTA";
        private string stock_actual = "@STOCK_ACTUAL";
        private string id_proveedor_ = "@ID_PROVEEDOR";  

        public ORM_Materia_Prima()
        {
            /// Auto invocacion
            Materia_Prima = Obtener_Materia_Prima_ORM();
        }
        /// Cargamos la grilla con la materia prima de la lista
        public List<Materia_PrimaBE> Cargar_Materia_Prima_Grilla()
        {
            return Materia_Prima;
        }

        /// Mapeo de la tabla a la lista de objetos Materia_PrimaBE 
        public List<Materia_PrimaBE> Obtener_Materia_Prima_ORM()
        {
            List<Materia_PrimaBE> listaMateria_Prima = new List<Materia_PrimaBE>();
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter ( "@ACCION" , "OBTENER" )
            };

            DataTable dt = acceso.Leer(storedProcedure,sp);

            foreach( DataRow dr in dt.Rows )
            { 
                Materia_PrimaBE mapeo = new Materia_PrimaBE(
                    Convert.ToInt32 ( dr["Id_Materia_Prima"] ),
                    dr["Nombre"].ToString(),
                    Convert.ToDecimal ( dr["Precio"] ),
                    Convert.ToInt32 ( dr["Stock_Actual"] )
                    );
                listaMateria_Prima.Add( mapeo );

            }

            return listaMateria_Prima;
        }


        public void Alta_Materia_Prima ( Materia_PrimaBE nuevaMateria_Prima, int id_proveedor )
        {
            try
            {
                nuevaMateria_Prima.Id_Materia_Prima = this.Materia_Prima.Max( m => m.Id_Materia_Prima +1 );
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter ( "@ACCION" , "AGREGAR" ),
                    new SqlParameter ( materia_prima , SqlDbType.Int ) { Value = nuevaMateria_Prima.Id_Materia_Prima },
                    new SqlParameter ( id_proveedor_ , SqlDbType.Int ) { Value = id_proveedor },
                    new SqlParameter ( nombre , SqlDbType.NVarChar , 100 ) { Value = nuevaMateria_Prima.Nombre },
                    new SqlParameter ( precio_venta , SqlDbType.Decimal ) { Value = nuevaMateria_Prima.Cantidad},
                    new SqlParameter ( stock_actual , SqlDbType.Int ) { Value = nuevaMateria_Prima.Precio}
                };
                acceso.Escribir(storedProcedure, sp);
                // Actualizamos la lista en memoria
                Materia_Prima.Add( nuevaMateria_Prima );
            }
            catch ( Exception ex )
            {
                throw new Exception ( "Error al agregar materia prima: " + ex.Message );
            }
        }

        public void Baja_Materia_Prima( int id_materia )
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter ( "@ACCION" , "ELIMINAR" ),
                new SqlParameter ( materia_prima , SqlDbType.Int ) { Value = id_materia }
            };

            acceso.Escribir(storedProcedure,sp);
        }



    }
}
