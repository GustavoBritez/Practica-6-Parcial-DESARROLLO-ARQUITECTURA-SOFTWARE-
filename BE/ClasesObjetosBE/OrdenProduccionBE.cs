using System.Formats.Tar;

namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class OrdenProduccionBE
    {
        private int id_orden;
        private string codigo_prod;
        private int cantidad;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private string estado;

        public int Id_Orden { get => id_orden; set => id_orden = value; }
        public string Codigo_Prod { get => codigo_prod; set => codigo_prod = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime Fecha_Inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_Fin { get => fecha_fin; set => fecha_fin = value; }
        public string Estado { get => estado; set => estado = value; }

        public OrdenProduccionBE(int id_orden, string codigo_prod, int cantidad, DateTime fecha_inicio, DateTime fecha_fin, string estado)
        {
            this.id_orden = id_orden;
            this.codigo_prod = codigo_prod;
            this.cantidad = cantidad;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.estado = estado;
        }

    }
}