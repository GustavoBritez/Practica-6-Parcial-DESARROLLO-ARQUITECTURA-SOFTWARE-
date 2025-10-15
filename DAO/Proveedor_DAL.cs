using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Proveedor_DAL
    {
        private Access acceso = new Access();

        public DataTable Obtener_Proveedores()
        {
            DataTable dt = new DataTable();

            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@ACCION", SqlDbType.VarChar) { Value = "OBTENER" }
            };
            return dt = acceso.Leer("SP_PROVEEDOR_CRUD", sp);

        }

        public void Sincronizar_Proveedores(DataTable proveedores)
        {
            acceso.Sincronizar(proveedores , "SELECT * FROM PROVEEDOR"); // VER MAL
        }

    }
}
