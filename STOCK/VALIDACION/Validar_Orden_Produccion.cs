using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALIDACION
{
    public class Validar_Orden_Produccion
    {
        public void Validar_Fecha_Orden(DateTime fecha)
        {
            if (fecha < DateTime.Now )
                throw new ArgumentException("La fecha no puede ser anterior a la actual");
        }

        public void Validar_Cantidad_Usada(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero");
        }

        public void Validar_Cantidad_Prod( int cantidad )
        {
            if ( cantidad <= 0 )
                throw new ArgumentException("La cantidad a producir debe ser mayor a cero");
        }

        public void Validar_Costo_Total_Orden( decimal cantidad )
        {
            if ( cantidad <= 0 )
                throw new ArgumentException("El costo total de la orden debe ser mayor a cero");    
        }

        public void Validar_Estado( string estado )
        {
            if ( string.IsNullOrEmpty(estado) )
                throw new ArgumentNullException("El estado no puede estar vacio");

            if ( estado != "En Proceso" && estado != "Finalizada" && estado != "Cancelada" )
                throw new ArgumentException("El estado debe ser 'En Proceso', 'Finalizada' o 'Cancelada'");
        }
    }
}
