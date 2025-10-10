namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class Proveedores
    {
        Proveedores()
        {
        public Proveedores() { }
        public Proveedores(string pDNI) { DNI = pDNI; }

        public Proveedores(object[] pItemArray) : this(pItemArray[0].ToString())
        { Nombre = pItemArray[1].ToString(); Apellido = pItemArray[2].ToString(); }

        public Proveedores(string pDNI, string pNombre, string pApellido) : this(new object[] {pDNI,pNombre, pApellido})
        {}

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
}
