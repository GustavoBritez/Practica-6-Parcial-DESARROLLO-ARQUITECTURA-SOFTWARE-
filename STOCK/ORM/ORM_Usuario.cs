using BE;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ORM
{
    public class ORM_Usuario
    {
        Access access = new Access();   
        public ORM_Usuario()
        { 
            
        }
        public ClienteBE ValidarUsuario(string mail)
        {
            SqlParameter[] SP = new SqlParameter[] {

                new SqlParameter("ACCION", System.Data.SqlDbType.VarChar) { Value = mail },

            };
            DataTable dt = access.Leer("SP_VALIDAR_USUARIO",SP);    
            
            DataRow dr = dt.Rows[0];

            ClienteBE newCliente = new ClienteBE
            (
                Convert.ToInt32(dr["Id_Cliente"]),
                dr["Nombre"].ToString(),
                dr["Telefono"].ToString(),
                dr["Email"].ToString()
            );
            return newCliente;

        }
    }
}
