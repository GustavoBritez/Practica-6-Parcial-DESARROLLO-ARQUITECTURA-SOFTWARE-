using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class HabitacionDAL
    {
        private readonly Access _access;

        public HabitacionDAL()
        {
            _access = new Access();
        }

        public bool AgregarHabitacion(HabitacionBE HBE)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@OPTION", "ADD"),
                new SqlParameter("@NUMERO", HBE.Numero),
                new SqlParameter("@PRECIOBASE",HBE.PrecioBase),
                new SqlParameter("@CAPACIDAD", HBE.Capacidad),
                new SqlParameter("@DISPONIBILIDAD", HBE.Disponibilidad)
            };

            int valida = _access.Escribir("SP_CRUD", parametros);

            return valida > 0;
        }

        public bool EliminarHabitacion(HabitacionBE HBE)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@OPTION", "REMOVE"),
                new SqlParameter("@NUMERO", HBE.Numero)
            };

            int valida = _access.Escribir("SP_CRUD", parametros);
            return valida > 0;
        }

        public bool ModificarHabitacion(HabitacionBE HBE)
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@OPTION", "MOD"),
                new SqlParameter("@NUMERO", HBE.Numero),
                new SqlParameter("@PRECIOBASE",HBE.PrecioBase),
                new SqlParameter("@CAPACIDAD", HBE.Capacidad),
                new SqlParameter("@DISPONIBILIDAD", HBE.Disponibilidad)
            };

            int valida = _access.Escribir("SP_CRUD", parametros);

            return valida > 0;
        }

        public bool ObtenerHabitaciones()
        {
            var parametros = new SqlParameter[]
            {
                new SqlParameter("@OPTION", "GET")
            };
            var dt = _access.Leer("SP_CRUD", parametros);

            return dt.Rows.Count > 0;
        }
    }
}
