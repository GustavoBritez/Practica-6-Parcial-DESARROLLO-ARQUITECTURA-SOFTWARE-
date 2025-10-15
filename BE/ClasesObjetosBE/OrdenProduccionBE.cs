using System.Formats.Tar;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    [Table("ORDEN_PRODUCCION")]
    public class OrdenProduccionBE
    {
        private int id_orden;
        private int id_materia;
        private int id_cliente;
        private string codigo_prod;
        private DateTime fecha_orden;
        private int cantidad_usada;
        private int cantidad_prod;
        private decimal costo_total_orden;
        private string estado;

        public int Id_Orden { get => id_orden; set => id_orden = value; }
        public int Id_Materia { get => id_materia; set => id_materia = value; } 
        public int Id_Cliente { get => id_cliente; set => id_cliente = value; }
        public string Codigo_Prod { get => codigo_prod; set => codigo_prod = value; }
        public DateTime Fecha_Orden { get => fecha_orden; set => fecha_orden = value; }
        public int Cantidad_Usada { get => cantidad_usada; set => cantidad_usada = value; } 
        public int Cantidad_Prod { get => cantidad_prod; set => cantidad_prod = value; }
        public decimal Costo_Total_Orden { get => costo_total_orden; set => costo_total_orden = value; }
        public string Estado { get => estado; set => estado = value; }

        public OrdenProduccionBE(int id_orden, int id_materia, int id_cliente, string codigo_prod, DateTime fecha_orden, int cantidad_usada, int cantidad_prod, decimal costo_total_orden, string estado)
        {
            this.id_orden = id_orden;
            this.id_materia = id_materia;
            this.id_cliente = id_cliente;
            this.codigo_prod = codigo_prod;
            this.fecha_orden = fecha_orden;
            this.cantidad_usada = cantidad_usada;
            this.cantidad_prod = cantidad_prod;
            this.costo_total_orden = costo_total_orden;
            this.estado = estado;
        }

    }
}