using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ORM
{

    public class Access
    {
        private SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=STOCK;Integrated Security=True;Trust Server Certificate=True");

        private SqlTransaction transaction;

        public void Open()
        {
            conn.Open();
        }
        public void Close()
        {
            conn.Close();
        }
        public void Start_TX()
        {
            transaction = conn.BeginTransaction();
        }
        public void Commit_TX()
        {
            transaction.Commit();
        }
        public void Stop_TX()
        {
               
        }

        public DataTable Leer ( string Query , SqlParameter[] sp = null , string nombre_tabla = null )
        {
            DataTable dt = new(nombre_tabla);
            
            try
            {
                Open();
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    if (sp != null)
                        cmd.Parameters.AddRange(sp);

                    using (SqlDataAdapter adapter = new(cmd))
                    {
                        adapter.Fill(dt);
                    }

                }
                Close();
                
            }
            catch ( Exception ex )
            {
                Stop_TX();
                Close();
                throw new Exception($"Error al leer datos usando : {Query}" + ex.Message);
            }

            return dt;
        }


        public int Escribir( string Query , SqlParameter[] sp )
        {
            int filas_afectadas = 0;    
            try
            {
                Open();
                Start_TX();
                using ( SqlCommand cmd = new SqlCommand( Query , conn ) )
                {
                    cmd.Transaction = transaction;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if ( sp != null )
                        cmd.Parameters.AddRange( sp );

                    filas_afectadas = cmd.ExecuteNonQuery(); // Ejecuta la consulta y devuelve el número de filas afectadas

                    if ( filas_afectadas == -1 )
                    {
                        Commit_TX();
                    }
                }
            }
            catch( Exception ex )
            {
                Stop_TX();
                Close();
                return -1;
            }
            finally
            {
                Close();
            }
            return filas_afectadas;
        }

    }
}
