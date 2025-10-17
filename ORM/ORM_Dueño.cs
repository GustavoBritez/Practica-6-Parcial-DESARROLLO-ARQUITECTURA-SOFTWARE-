
namespace ORM_Dueño
{
    public class ORM_Dueño
    {
        DataSet DS;
        Dueño_DAL AC;
        public ORM_Dueño() { AC = new Access(); DS = AC.TablaDueño();  }

        public void Alta(Dueño mp)
        {
            try
            {

            }
            catch (exception ex) { throw ex; }
        }
        
        public void Baja(Dueño mp)
        {
            try
            {

            }
            catch (exception ex) { throw ex; }
        }
    }
}
