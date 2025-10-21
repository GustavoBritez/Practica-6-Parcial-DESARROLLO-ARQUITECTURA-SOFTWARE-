using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VALIDACION
{
    public class Validar_Persona
    {
        /// El nombre debe tener entre 3 y 15 caracteres y no debe contener numeros
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

        /// Los telefonos deben tener 8 digitos y no deben contener letras
        public void Validar_Telefono( string telefono )
        {
            if (string.IsNullOrEmpty(telefono))
                throw new ArgumentNullException("El telefono no puede estar vacio");

                Regex tgx = new Regex(@"^\d{8}$");

                if ( !tgx.IsMatch(telefono))
                        throw new ArgumentException("El telefono debe tener 8 digitos y no debe contener letras");

        }

        /// El correo debe tener entre 3 y 25 caracteres y debe ser de gmail.com
        public void Validar_Mail( string correo )
        {
            if (string.IsNullOrEmpty(correo))
                throw new ArgumentException("El correo es NULL");

            Regex rxg = new Regex(@"^[a-z0-9\.]{3,25}@gmail\.com$",RegexOptions.IgnoreCase);

            if (!rxg.IsMatch(correo))
                throw new ArgumentException("El correo debe tener entre 3 y 25 caracteres y debe ser de gmail.com");

        }
    }
}
