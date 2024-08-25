using ProyectoPrograAvanzadaG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrograAvanzadaG.Controllers
{
    public class ProductoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // Acción para listar todos los productos
        public ActionResult ListaProductos()
        {
          var productos = db.Productos.ToList(); // Accede a la entidad Productos a través del contexto
          return View(productos);
        }
        
        // Acción para crear un nuevo producto
        [HttpGet]
        public ActionResult CrearProducto()
        {
          return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearProducto(Producto producto)
        {
          if (ModelState.IsValid)
          { 
            db.Productos.Add(producto); // Agrega el nuevo producto al contexto
            db.SaveChanges(); // Guarda los cambios en la base de datos
            return RedirectToAction("ListaProductos");
          }
          return View(producto);
        }
        
        // Acción para ver los detalles de un producto específico
        public ActionResult DetallesProducto(int id)
        {
          var producto = db.Productos.Find(id); // Busca el producto por ID
          if (producto == null)
          {
            return HttpNotFound();
          }
          return View(producto);
        }
        
        // Acción para editar un producto existente
        [HttpGet]
        public ActionResult EditarProducto(int id)
        {
          var producto = db.Productos.Find(id);
          if (producto == null)
          {
            return HttpNotFound();
          }
          return View(producto);
        }
        
       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarProducto(Producto producto)
        {
          if (ModelState.IsValid)
          {
            db.Entry(producto).State = EntityState.Modified; // Marca el cliente como modificado
            db.SaveChanges(); // Guarda los cambios en la base de datos
            return RedirectToAction("DetallesCliente", new { id = producto.CodigoProducto });
          }
          return View(producto);
        }
        // Acción para eliminar un producto
        [HttpGet]
        public ActionResult EliminarProducto(int id)
        {
          var producto = db.Productos.Find(id);
          if (producto == null)
          {
            return HttpNotFound();
          }
          return View(producto);
        }
        
        [HttpPost, ActionName("EliminarProducto")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarProductoConfirmed(int id)
        {
          var producto = db.Productos.Find(id);
          if (producto != null)
          {
             db.Productos.Remove(producto); // Elimina el cliente del contexto
             db.SaveChanges(); // Guarda los cambios en la base de datos
          }
          return RedirectToAction("ListaProductos");
        }

        [HttpGet]
        public ActionResult CartView()
        {
            return View();
        }
    }
}
