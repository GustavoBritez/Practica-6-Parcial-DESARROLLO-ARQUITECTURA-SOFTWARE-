using System.ComponentModel.DataAnnotations.Schema;
namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    [Table("MATERIA")]
    public class MateriasPrimaBE
    {
        private int id_materia;
        private int id_prove;
        private string nombre;
        private int stock_actual;
        private decimal costo_venta;


        public int Id_Materia { get => id_materia; set => id_materia = value; }
        public int Id_Prove { get => id_prove; set => id_prove = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock_Actual { get => stock_actual; set => stock_actual = value; }
        public decimal Costo_Venta { get => costo_venta; set => costo_venta = value; }

        public MateriasPrimaBE(int id_materia, int id_prove, string nombre, int stock_actual, decimal costo_venta)
        {
            this.id_materia = id_materia;
            this.id_prove = id_prove;
            this.nombre = nombre;
            this.stock_actual = stock_actual;
            this.costo_venta = costo_venta;
        }

    }
}