using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace ProyectoPrograAvanzadaG.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Resena> Resenas { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProductoCarrito> ProductosCarrito { get; set; }
        public DbSet<ProductoPedido> ProductosPedido { get; set; }

    }
}