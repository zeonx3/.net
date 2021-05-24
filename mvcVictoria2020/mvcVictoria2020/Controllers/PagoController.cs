using BAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class PagoController : Controller
    {
        PagoManager man = new PagoManager();
        public ActionResult Index()
        {
            return View(man.Listar());
        }
        public ActionResult DropVistas()
        {
            ViewBag.Habitaciones = man.Habitaciones();
            ViewBag.Clientes = man.Clientes();
            ViewBag.Reservas = man.Reservas();
            return View();
        }

        public ActionResult Editar(int id)
        {
            DropVistas();
            var obj = man.Buscar(id);
            return View(obj);


        }

        public ActionResult Crear()
        {
            DropVistas();
            return View();
        }

        [HttpPost]
        public ActionResult Editar(int id, PagoModel obj)
        {
            DropVistas();
            obj.idpago = id;
            man.Editar(obj);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Crear (PagoModel obj)
        {
            DropVistas();
            man.Crear(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Borrar(int id)
        {
            var obj = man.Buscar(id);
            return View(obj);
        }

        [HttpPost]

        public ActionResult Borrar(int id, PagoModel obj)
        {
            man.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}