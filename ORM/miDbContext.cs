using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace ORM
{
    public class miDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ClienteBE> Clientes { get; set; }
        public DbSet<DueñoBE> Dueños { get; set; }
        public DbSet<EmpleadoBE> Empleados { get; set; }
        public DbSet<ProveedorBE> Proveedor { get; set; }
        public DbSet<MateriasPrimaBE> Materias_Primas { get; set; }
        public DbSet<OrdenProduccionBE> Ordenes_Produccion { get; set; }
        public DbSet<OrdenDetalleBE> OrdenDetalle { get; set; }
        public DbSet<ProductoBE> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=STOCK;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
