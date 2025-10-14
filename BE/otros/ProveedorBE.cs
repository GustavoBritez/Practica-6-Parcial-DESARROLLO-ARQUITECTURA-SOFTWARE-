namespace BE
{
    public class ProveedorBE
    {
        private int id_proveedor;
        private string nombre;
        private string telefono;
        private string mail;

        public int Id_Proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
