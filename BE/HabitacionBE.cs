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

        public int Numero { get { return numero; } set { numero = value; } }
        public double PrecioBase { get { return precioBase; } set { precioBase = value; } }
        public int Capacidad { get { return capacidad; } set { capacidad = value; } }
        public bool Disponibilidad { get {return disponibilidad;} set { disponibilidad = value;} }

    }
}
