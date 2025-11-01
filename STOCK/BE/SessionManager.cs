using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SessionManager
    {

        private static SessionManager _instance;
        public Usuario _Usuario {  get; set; }
        private SessionManager() { }

        public static readonly object _Lock = new Object();

        public static void Login( Usuario usuario )
        {
            lock (_Lock)
            {
                if (_instance == null)
                {
                    _instance = new SessionManager();
                    _instance._Usuario = usuario;
                }
            }
        }
        public static void Logout()
        {
            lock (_Lock)
            {
                if (_instance != null)
                {
                    _instance = null;
                }
                else
                {
                    throw new Exception("Sesion No Iniciada");
                }
            }
        }

        public static SessionManager GetInstance
        {
            get
            {
                if (_instance == null) throw new Exception("Sesion No Iniciada");
                return _instance;
            }
        }



    }
}
