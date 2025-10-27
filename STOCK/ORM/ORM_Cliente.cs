using BE;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ORM
{
    public class ORM_Cliente
    {

        private string storedprocedure = "SP_CLIENTE_CRUD";

        Access acceso = new Access();
        // Para manejar los clientes en memoria y comprarar cambios antes de enviarlos a la base de datos
        private List<ClienteBE> listaClientes;

        /// Generamos un constructor para inicializar la lista de clientes dentro de una BLL y utilizar los metodos de ORM
        public ORM_Cliente()
        {
            listaClientes = Obtener_Clientes_ORM();
        }
        /// Devuelve la lista de clientes en memoria y la usamos para cargar la grilla
        public List<ClienteBE> Cargar_Clientes_Grilla()
        {
            return listaClientes;
        }
        // Este metodo convierte una tabla en una lista de objetos ClienteBE 
        public List<ClienteBE> Obtener_Clientes_ORM()
        {
            List<ClienteBE> listaClientes = new List<ClienteBE>();
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ACCION", "OBTENER")
            };
            DataTable dt = acceso.Leer(storedprocedure, sp);

            foreach (DataRow dr in dt.Rows)
            {
                ClienteBE mapeoCliente = new ClienteBE(Convert.ToInt32(dr["Id_Cliente"]), dr["Nombre"].ToString(), dr["Telefono"].ToString(), dr["Mail"].ToString());
                listaClientes.Add(mapeoCliente);
            }
            return listaClientes;
        }


        public void Alta(ClienteBE cliente)
        {
            try
            {
                if (this.listaClientes.Count == 0)
                {
                    int id_sin_numeros = 1;

                    SqlParameter[] sp = new SqlParameter[]
                    {
                    new SqlParameter("@ACCION", "AGREGAR"),
                    new SqlParameter ("@ID_CLIENTE", SqlDbType.Int ) { Value = cliente.Id_Cliente },
                    new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = cliente.Nombre },
                    new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = cliente.Telefono },
                    new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = cliente.Mail }

                    };
                    acceso.Escribir(storedprocedure, sp);
                }
                else
                {
                    cliente.Id_Cliente = this.listaClientes.Max(c => c.Id_Cliente + 1);

                    SqlParameter[] sp = new SqlParameter[]
                    {
                    new SqlParameter("@ACCION", "AGREGAR"),
                    new SqlParameter ("@ID_CLIENTE", SqlDbType.Int ) { Value = cliente.Id_Cliente },
                    new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = cliente.Nombre },
                    new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = cliente.Telefono },
                    new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = cliente.Mail }

                    };
                    acceso.Escribir(storedprocedure, sp);
                }
                //this.listaClientes.Add(cliente); 
                // Quiero ver si esto funciona sin tener que agregar el cliente a la lista en memoria
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                /// Como cargamos a la base de datos entonces pisamos el dato de la lista en memoria con los datos de base de datos
                this.listaClientes = Obtener_Clientes_ORM();
            }
        }
        /// Elimina el cliente de la lista en memoria
        public void Baja( int id_cliente )
        {
            try
            {
                // Elimina el cliente de la lista en memoria
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@ACCION", "ELIMINAR"),
                    new SqlParameter ("@ID_CLIENTE", SqlDbType.Int ) { Value = id_cliente }
                };
                acceso.Escribir(storedprocedure, sp);
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
            finally
            {   
                // Como cargamos a la base de datos entonces pisamos el dato de la lista en memoria con los datos de base de datos
                this.listaClientes = Obtener_Clientes_ORM();
            }
        }
        // No se modifica el Id_Cliente porlotanto solo buscamos y colocamos los nuevos valores al ID ya existente en la lista
        public void Modificar( ClienteBE clientemodificado )
        {
            {   var cliente = this.listaClientes.FirstOrDefault(c => c.Id_Cliente == clientemodificado.Id_Cliente);
                if ( cliente != null )
                {
                    cliente.Nombre = clientemodificado.Nombre;
                    cliente.Telefono = clientemodificado.Telefono;
                    cliente.Mail = clientemodificado.Mail; 
                }

                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@ACCION", "MODIFICAR"),
                    new SqlParameter ("@ID_CLIENTE", SqlDbType.Int ) { Value = clientemodificado.Id_Cliente },
                    new SqlParameter ("@NOMBRE", SqlDbType.VarChar ) { Value = clientemodificado.Nombre },
                    new SqlParameter ("@TELEFONO", SqlDbType.VarChar ) { Value = clientemodificado.Telefono },
                    new SqlParameter ("@MAIL", SqlDbType.VarChar ){ Value = clientemodificado.Mail }
                };

                acceso.Escribir(storedprocedure, sp);

            }

        }
    }
}

