using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VALIDACION
{
    public class Validar_Producto
    {
        public void Validar_Codigo( string codigo )
        {
            if ( string.IsNullOrEmpty(codigo) )
                throw new ArgumentNullException("El codigo no puede estar vacio");

            Regex rgx = new Regex(@"^P-[1-9]{3}");

            if (!rgx.IsMatch(codigo))
                throw new ArgumentException("El codigo debe ser P-XXX");
        }  

        public void Validar_Nombre( string nombre )
        {
            if ( string.IsNullOrEmpty(nombre) )
                throw new ArgumentNullException("El nombre no puede estar vacio");
            try
            {
                Regex rgx = new Regex(@"^[a-z]{3,15}$", RegexOptions.IgnoreCase);
                if (!rgx.IsMatch(nombre))
                    throw new ArgumentException("El nombre debe tener entre 3 y 15 caracteres y no debe contener numeros");
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public void Validar_Precio_Venta( decimal precio )
        {
            if ( precio < 0 )
                throw new ArgumentException("El precio no puede ser negativo");
        }

        public void Validar_Stock_Actual( int cantidad )
        {
            if ( cantidad < 0 )
                throw new ArgumentException("La cantidad no puede ser negativa");
        }   

    }
}
