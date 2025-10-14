namespace BE
{
    public class ProveedorBE : PersonaBE
    {
        private int id_proveedor;


        public int Id_Proveedor { get => id_proveedor; set => id_proveedor = value; }


        public ProveedorBE(int id_proveedor, string nombre, string telefono, string mail) : base(nombre,telefono, mail)
        {
            this.id_proveedor = id_proveedor;
        }
    }
}
