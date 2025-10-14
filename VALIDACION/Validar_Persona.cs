using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        ///  option = "Edad" La fecha no puede ser mayor a la actual menos 18 años
        ///  option = "Produccion" La fecha no puede ser anterior a la actual
        public void Validar_Fecha( DateTime fecha , string option)
        {
            if (string.IsNullOrEmpty(fecha.ToString()))
                throw new ArgumentNullException("El nombre no puede estar vacio");
            try
            {
                switch(option)
                {
                    case "Edad":
                        if ( fecha > DateTime.Now.AddYears(-18) )
                            throw new ArgumentException("La fecha no puede ser mayor a la actual menos 18 años");
                        break;
                    case "Produccion":
                        if ( fecha < DateTime.Now )
                            throw new ArgumentException("La fecha no puede ser anterior a la actual");
                        break;
                    default:
                        throw new ArgumentException("Opcion no valida");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
