using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;

namespace ORM
{
    public class ORM_Cliente
    {
<<<<<<< HEAD
        Access acceso = new();
        private List<ClienteBE> listaClientes;

        /// Generamos un constructor para inicializar la lista de clientes dentro de una BLL y utilizar los metodos de ORM
         

        public List<ClienteBE> Cargar_Clientes_Grilla()
        {
            return listaClientes;

=======
        public List<ClienteBE> Obtener_Clientes_ORM()
        {
            List<ClienteBE> listnew = new List<ClienteBE>();


            return listnew;
>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
        }


        public ORM_Cliente()
        {
            listaClientes = Obtener_Clientes_ORM();
        }   

        // Este metodo convierte una tabla en una lista de objetos ClienteBE 
        public List<ClienteBE> Obtener_Clientes_ORM()
        {
            List<ClienteBE> listaClientes = new List<ClienteBE>();
            DataTable dt = acceso.Leer("SP_OBTENER_CLIENTES", null);

            /// Cargamos manualmente la funcion de mapeo
            foreach (DataRow dr in dt.Rows)
            {
                ClienteBE mapeoCliente = new(Convert.ToInt32(dr["Id_Cliente"]), dr["Nombre"].ToString(), dr["Telefono"].ToString(), dr["Mail"].ToString());
                listaClientes.Add(mapeoCliente);
            }
            return listaClientes;
        }

        /// Agrega el cliente a la lista en memoria
        public void Alta(ClienteBE cliente)
        {
<<<<<<< HEAD
            try
            {
                this.listaClientes.Add(cliente);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        /// Elimina el cliente de la lista en memoria
        public void Baja(ClienteBE cliente)
        {
            try
            {
                // Elimina el cliente de la lista en memoria
                this.listaClientes.RemoveAll(c => c.Id_Cliente == cliente.Id_Cliente);
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }
        /// No se modifica el Id_Cliente porlotanto solo buscamos y colocamos los nuevos valores al ID ya existente en la lista
        public void Modificar( ClienteBE clientemodificado )
        {
            {   var cliente = this.listaClientes.FirstOrDefault(c => c.Id_Cliente == clientemodificado.Id_Cliente);
                if ( cliente != null )
                {
                    cliente.Nombre = clientemodificado.Nombre;
                    cliente.Telefono = clientemodificado.Telefono;
                    cliente.Mail = clientemodificado.Mail; 
                }
            }
=======

        }

        public void Baja(ClienteBE cliente)
        {

        }

        public void Modificar(ClienteBE clientemodificado)
        {

>>>>>>> fe91ebba3f0de89302f09930830e67d99109d472
        }
    }
}

