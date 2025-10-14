namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class ListaOrdenesBE
    {
        public ListaOrdenesBE(DateTime x) 
        { Fecha_Realizada = x; }
        public DateTime Fecha_Realizada { get => Fecha_Realizada; set => Fecha_Realizada = value; }

        private DateTime Fecha_Realizada;
    }
}