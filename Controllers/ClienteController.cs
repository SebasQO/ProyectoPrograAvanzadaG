using ProyectoPrograAvanzadaG.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ProyectoPrograAvanzadaG.Controllers
{
    public class ClienteController : Controller
    {
        // Aquí aseguramos que estamos usando el contexto correcto
        private ApplicationDbContext db = new ApplicationDbContext();

        // Acción para listar todos los clientes
        public ActionResult ListaClientes()
        {
            var clientes = db.Cliente.ToList(); // Accede a la entidad Clientes a través del contexto
            return View(clientes);
        }

        // Acción para ver los detalles de un cliente específico
        public ActionResult DetallesCliente(int id)
        {
            var cliente = db.Cliente.Find(id); // Busca el cliente por ID
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // Acción para crear un nuevo cliente
        [HttpGet]
        public ActionResult CrearCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(cliente); // Agrega el nuevo cliente al contexto
                db.SaveChanges(); // Guarda los cambios en la base de datos
                return RedirectToAction("ListaClientes");
            }
            return View(cliente);
        }

        // Acción para editar un cliente existente
        [HttpGet]
        public ActionResult EditarCliente(int id)
        {
            var cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified; // Marca el cliente como modificado
                db.SaveChanges(); // Guarda los cambios en la base de datos
                return RedirectToAction("DetallesCliente", new { id = cliente.ClienteId });
            }
            return View(cliente);
        }
        // Acción para eliminar un cliente
        [HttpGet]
        public ActionResult EliminarCliente(int id)
        {
            var cliente = db.Cliente.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("EliminarCliente")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarClienteConfirmed(int id)
        {
            var cliente = db.Cliente.Find(id);
            if (cliente != null)
            {
                db.Cliente.Remove(cliente); // Elimina el cliente del contexto
                db.SaveChanges(); // Guarda los cambios en la base de datos
            }
            return RedirectToAction("ListaClientes");
        }
    }
}
