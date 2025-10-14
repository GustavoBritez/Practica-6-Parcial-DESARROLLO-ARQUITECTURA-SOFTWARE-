namespace BE
{
    public abstract class PersonaBE
    {
        private string nombre;
        private string telefono;
        private string mail;

        public string Nombre { get => nombre; set => nombre = value; }  
        public string Telefono { get => telefono; set => telefono = value; }    
        public string Mail { get => mail; set => mail = value; }    

        public PersonaBE( string nombre, string telefono, string mail)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.mail = mail;   
        }
    }

}
