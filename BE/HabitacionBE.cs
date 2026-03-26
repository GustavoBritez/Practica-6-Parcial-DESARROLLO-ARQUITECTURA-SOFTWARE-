using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BE
{
    public class HabitacionBE
    {

        private int numero;
        private double precioBase;
        private int capacidad;
        private bool disponibilidad;

        [Key]
        public int Numero { get { return numero; } set { numero = value; } }

        [Range(0.1, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        public double PrecioBase { get { return precioBase; } set { precioBase = value; } }

        [Range(1, int.MaxValue, ErrorMessage = "La capacidad debe ser mayor a 0")]
        public int Capacidad { get { return capacidad; } set { capacidad = value; } }

        [Required]
        public bool Disponibilidad { get {return disponibilidad;} set { disponibilidad = value;} }

    }
}
