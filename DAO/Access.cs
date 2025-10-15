using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Access
    {
        public SqlConnection conn = new("AGREGAR DATASOURCE BD");
        public SqlTransaction transaction;

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
        public void Stop_TX()
        {
            transaction.Rollback();
        }
        public void Commit_TX()
        {
            transaction.Commit();
        }

        public void Sincronizar(DataTable tabla, string SelectQuery)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(SelectQuery,conn))
            {
                using (SqlCommandBuilder builder = new(adapter))
                {
                    adapter.Update(tabla);
                }
            }
        }
        public int Escribir( string Query , SqlParameter[] sp = null )
        {
            int filasAfectadas = 0; 
            try
            {
                conn.Open();
                Start_TX();
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if ( sp is not null )
                        cmd.Parameters.AddRange(sp);
                    
                    filasAfectadas = cmd.ExecuteNonQuery();

                }

                Commit_TX();

                return filasAfectadas;
            }
            catch( Exception ex )
            {
                Stop_TX();
                throw;
            }
        }
        public DataTable Leer( string Query , SqlParameter[] sp )
        {
            try
            {
                DataTable dt = new DataTable();
                Open();
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    if (sp is not null)
                        cmd.Parameters.AddRange(sp);

                    using (SqlDataAdapter adapter = new(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
