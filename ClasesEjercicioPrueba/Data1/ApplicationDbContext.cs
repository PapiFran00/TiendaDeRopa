using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClasesEjercicioPrueba.Models;
using ClasesModelo.Models;

namespace ClasesEjercicioPrueba.Data1
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<ProductoProveedor> ProductoProveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

     



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\TEW_SQLEXPRESS;Database=TiendaDeRopa;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }



    }
}
