using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VALIDACION
{
    public class Validar_MP
    {
        /// El nombre debe tener entre 3 y 15 caracteres y no debe contener numeros
        public void Validar_Nombre(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
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

        /// Stock no puede ser negativo
        public void Validar_Stock( int cantidad )
        {
            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa");

        }

        /// Costo de venta no puede ser negativo
        public void Validar_Costo_Venta( decimal precio )
        {
            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo");
        }
    }
}
