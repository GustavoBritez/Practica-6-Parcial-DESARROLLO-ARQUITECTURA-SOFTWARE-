using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    internal class HabitacionBLL
    {
        
        private readonly HabitacionDAL _habitacionDAL;

        public HabitacionBLL()
        {
            _habitacionDAL = new HabitacionDAL();
        }

        public void AgregarHabitacion(HabitacionBE HBE)
        {
            ValidarEntidad(HBE);
            _habitacionDAL.AgregarHabitacion(HBE);
        }

        public void EliminarHabitacion(HabitacionBE HBE)
        {
            ValidarEntidad(HBE);
            _habitacionDAL.EliminarHabitacion(HBE);
        }

        public void ModificarHabitacion(HabitacionBE HBE)
        {
            ValidarEntidad(HBE);
            _habitacionDAL.ModificarHabitacion(HBE);
        }

        private static void ValidarEntidad( HabitacionBE HBE )
        {
            if (HBE is null)
                throw new ArgumentNullException(nameof(HBE));

            var context = new ValidationContext(HBE);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(HBE,context,results))
            {
                throw new ValidationException(results[0].ErrorMessage);
            }
        }
    }
}
