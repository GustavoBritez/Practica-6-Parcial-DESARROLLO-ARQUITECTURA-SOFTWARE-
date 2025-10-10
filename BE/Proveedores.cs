namespace BE
{
    ///Para subir cambios a git
    /// Git Add .
    /// Git Commit -m " NOMBRE DEL CAMBIO "
    /// Git Push
    public class Proveedores
    {
        public Proveedores(string pDNI) 
        { DNI = pDNI; }

        public Proveedores(object[] pItemArray)
        { 
            DNI = Convert.ToInt32(pItemArray[0]);
            Apellido = pItemArray[1].ToString(); 
            Telefono = Convert.ToInt32(pItemArray[3]);
            Mail = pItemArray[3].ToString();
        }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
    }
}
