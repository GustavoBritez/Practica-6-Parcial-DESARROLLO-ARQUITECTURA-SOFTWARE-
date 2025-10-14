using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VALIDACION
{
    public class Validar_Persona
    {
        public void Validar_Nombre(string nombre)
        {
            if ( string.IsNullOrEmpty(nombre))
                throw new ArgumentNullException("El nombre no puede estar vacio");
            try
            {
                Regex rgx = new Regex(@"^[a-z]{3,15}$",RegexOptions.IgnoreCase);
                if ( !rgx.IsMatch(nombre) )
                    throw new ArgumentException("El nombre debe tener entre 3 y 15 caracteres y no debe contener numeros");
            }
            catch( Exception ex )
            {
                throw new ArgumentException(ex.Message);    
            }

        }
    }
}
