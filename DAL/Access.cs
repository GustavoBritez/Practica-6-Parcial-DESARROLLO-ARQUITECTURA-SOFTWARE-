using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace DAL
{
    internal class Access 
    {
        private readonly string conectionString ="Server=localhost;Database=Library;Trusted_Connection=True;";
        private bool _disposed;

        public Access()
        {

        }
        public DataTable Leer(string Query, SqlParameter[]? sp = null, string? nombre_Tabla = null)
        {
            var dt = new DataTable(nombre_Tabla);
            try
            {
                using var conn = new SqlConnection(conectionString);

                conn.Open();

                using var cmd = new SqlCommand(Query, conn)
                {
                    CommandType = CommandType.StoredProcedure

                };

                if (sp != null)
                    cmd.Parameters.AddRange(sp);

                using var da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public int Escribir( string Query , SqlParameter[]? sp = null )
        {
            try
            {
                using var conn = new SqlConnection(conectionString);

                conn.Open();

                using var transaction = conn.BeginTransaction();

                using var cmd = new SqlCommand(Query, conn, transaction)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (sp != null && sp.Length > 0)
                    cmd.Parameters.AddRange(sp);

                var filasAfectadas = cmd.ExecuteNonQuery();

                transaction.Commit();
                return filasAfectadas;
            }
            catch
            {
                throw;
            }
        }

    }
}

