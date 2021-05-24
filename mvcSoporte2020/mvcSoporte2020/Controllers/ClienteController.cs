using BAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class ClienteController : Controller
    {
        ClienteManager man = new ClienteManager();

        public ActionResult Index()
        {
            return View(man.Listar());
        }

        public ActionResult Crear()
        {
            ViewBag.Planes = man.Planes();
            ViewBag.Personas = man.Personas();
            return View();
        }

        [HttpPost]
        public ActionResult Crear(ClienteModel obj)
        {
            ViewBag.Planes = man.Planes();
            ViewBag.Personas = man.Personas();
            man.Crear(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(long id)
        {
            ViewBag.Planes = man.Planes();
            ViewBag.Personas = man.Personas();
            var obj = man.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Editar(long id, ClienteModel obj)
        {
            ViewBag.Planes = man.Planes();
            ViewBag.Personas = man.Personas();
            obj.idcliente = id;
            man.Editar(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Borrar(long id)
        {
            var obj = man.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Borrar(long id, ClienteModel obj)
        {
            man.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}