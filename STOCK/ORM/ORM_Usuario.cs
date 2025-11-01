using BE;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            access.Leer("SP_VALIDAR_USUARIO",SP);    
            


        }
    }
}
