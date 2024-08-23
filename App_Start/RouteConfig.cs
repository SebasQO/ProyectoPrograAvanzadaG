using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProyectoPrograAvanzadaG
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
             // Rutas de CRUD de Cliente
            routes.MapRoute(
                name: "ClientesLista",
                url: "Cliente/ListaClientes",
                defaults: new { controller = "Cliente", action = "ListaClientes" }
            );
            
            routes.MapRoute(
                name: "DetallesCliente",
                url: "Cliente/DetallesCliente/{id}",
                defaults: new { controller = "Cliente", action = "DetallesCliente" }
            );
            
            routes.MapRoute(
                name: "CrearCliente",
                url: "Cliente/CrearCliente",
                defaults: new { controller = "Cliente", action = "CrearCliente" }
            );
            
            routes.MapRoute(
                name: "EditarCliente",
                url: "Cliente/EditarCliente/{id}",
                defaults: new { controller = "Cliente", action = "EditarCliente" }
            );
            
            routes.MapRoute(
                name: "EliminarCliente",
                url: "Cliente/EliminarCliente/{id}",
                defaults: new { controller = "Cliente", action = "EliminarCliente" }
            );
            
            // Rutas de CRUD de Producto
            routes.MapRoute(
                name: "ProductosLista",
                url: "Producto/ListaProductos",
                defaults: new { controller = "Producto", action = "ListaProductos" }
            );
            
            routes.MapRoute(
                name: "DetallesProducto",
                url: "Producto/DetallesProducto/{id}",
                defaults: new { controller = "Producto", action = "DetallesProducto" }
            );
            
            routes.MapRoute(
                name: "CrearProducto",
                url: "Producto/CrearProducto",
                defaults: new { controller = "Producto", action = "CrearProducto" }
            );
            
            routes.MapRoute(
                name: "EditarProducto",
                url: "Producto/EditarProducto/{id}",
                defaults: new { controller = "Producto", action = "EditarProducto" }
            );
            
            routes.MapRoute(
                name: "EliminarProducto",
                url: "Producto/EliminarProducto/{id}",
                defaults: new { controller = "Producto", action = "EliminarProducto" }
            );
        }
    }
}
