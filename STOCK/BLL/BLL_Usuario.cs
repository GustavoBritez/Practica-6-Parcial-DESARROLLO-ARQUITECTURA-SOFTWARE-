using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Usuario
    {
        public ORM_Usuario mapper = new ORM_Usuario();

        public void ValidarUsuario(string mail)
        {
            mapper.ValidarUsuario(mail);
        }
    }
}
