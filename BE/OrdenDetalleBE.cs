using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrdenDetalleBE
    {
        private int id_detalle;
        private int id_dueño;
        private int id_orden;

        public int Id_Detalle { get => id_detalle; set => id_detalle = value; }
        public int Id_Dueño { get => id_dueño; set => id_dueño = value; }
        public int Id_Orden { get => id_orden; set => id_orden = value; }
    }

}
