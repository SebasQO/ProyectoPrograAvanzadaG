using ProyectoPrograAvanzadaG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrograAvanzadaG.Controllers
{
    public class PedidoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult OrderHistory()
        {
            var usuario = Session["User"] as Usuario;
            if (usuario != null)
            {
                var pedidos = db.Pedidos.Where(p => p.CodigoUsuario == usuario.CodigoUsuario).ToList();
                return View(pedidos);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult OrderHistoryView()
        {
            return View();
        }
    }
}