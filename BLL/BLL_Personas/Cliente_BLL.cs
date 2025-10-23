using BE;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_Personas
{
    public class Cliente_BLL
    {
        ORM_Cliente mapper = new();

        public void Agregar_Cliente(ClienteBE newCliente)
        {
            try
            {
                mapper.Alta(newCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar_Cliente( int id_cliente)
        {
            try
            {
                mapper.Baja(id_cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Modificar_Cliente(ClienteBE cliente )
        {
            try
            {
                mapper.Modificar(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ClienteBE> ObtenerClientes()
        {
            try
            {
                List<ClienteBE> lista_clientes = mapper.Cargar_Clientes_Grilla();

                return lista_clientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
