using ProyectoPrograAvanzadaG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrograAvanzadaG.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = new DashboardViewModel
            {
                TotalUsuarios = db.Usuarios.Count(),
                TotalProductos = db.Productos.Count(),
                TotalPedidosRecientes = db.Carritos.Count(),
                TotalReseñasPendientes = db.Resenas.Count()
            };
            return View(model);
        }
    }
}