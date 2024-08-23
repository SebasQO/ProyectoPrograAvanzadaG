using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace ProyectoPrograAvanzadaG.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Resena> Resenas { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProductoCarrito> ProductosCarrito { get; set; }
        public DbSet<ProductoPedido> ProductosPedido { get; set; }

    }
}
