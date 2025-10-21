using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BE;
namespace ORM
{
    public class ORM_Cliente
    {private miDbContext _context = new();
        public List<ClienteBE> Obtener_Clientes_ORM()
        {
            return _context.Clientes.ToList();
        }

        public void Alta(ClienteBE cliente)
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }   

        public void Baja(ClienteBE cliente)
        {
            try
            {
                var entity = _context.Clientes.Find(cliente.Id_Cliente);
                if (entity != null)
                {
                    _context.Clientes.Remove(entity);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                throw ex; 
            }
        }

        public void Modificar( ClienteBE clientemodificado )
        {
            var entity = _context.Clientes.Find(clientemodificado.Id_Cliente);
            if ( entity != null )
            {
                entity.Nombre = clientemodificado.Nombre;
                entity.Telefono = clientemodificado.Telefono;
                entity.Mail = clientemodificado.Mail; 

                _context.SaveChanges();
            }
        }
    }
    }
}
