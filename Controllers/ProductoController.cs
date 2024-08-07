using ProyectoPrograAvanzadaG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrograAvanzadaG.Controllers
{
    public class ProductoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        [HttpGet]
        public ActionResult ProductList()
        {
            var productos = db.Productos.ToList();
            return View(productos);
        }

        [HttpGet]
        public ActionResult Catalog()
        {
            var productos = db.Productos.ToList();
            return View(productos);
        }


        // Crear producto
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // Leer producto
        public ActionResult Details(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // Actualizar producto
        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // Eliminar producto
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var producto = db.Productos.Find(id);
            if (producto != null)
            {
                db.Productos.Remove(producto);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CartView()
        {
            return View();
        }
    }
}