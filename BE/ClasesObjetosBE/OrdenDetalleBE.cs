using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE
{
    [Table("OORDEN_DETALLE")]
    public class OrdenDetalleBE
    {
        private int id_detalle;
        private int id_dueño;
        private int id_orden;

        public int Id_Detalle { get => id_detalle; set => id_detalle = value; }
        public int Id_Dueño { get => id_dueño; set => id_dueño = value; }
        public int Id_Orden { get => id_orden; set => id_orden = value; }

        public OrdenDetalleBE(int id_detalle, int id_dueño, int id_orden)
        {
            this.id_detalle = id_detalle;
            this.id_dueño = id_dueño;
            this.id_orden = id_orden;
        }
    }

}
