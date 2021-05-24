using BAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class PersonaController : Controller
    {
        PersonaManager man = new PersonaManager();

        UbicacionManager uman = new UbicacionManager();

        public ActionResult Index()
        {
            return View(man.Listar());
        }

        public ActionResult Crear()
        {
            ViewBag.Comunas = uman.ComunaListar(131, 13);
            return View();
        }

        [HttpPost]
        public ActionResult Crear(PersonaModel obj)
        {
            ViewBag.Comunas = uman.ComunaListar(131, 13);
            man.Crear(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(long id)
        {
            ViewBag.Comunas = uman.ComunaListar(131, 13);
            var obj = man.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Editar(long id, PersonaModel obj)
        {
            ViewBag.Comunas = uman.ComunaListar(131, 13);
            obj.idpersona = id;
            man.Editar(obj);
            return RedirectToAction("Index");
        }

        public ActionResult Borrar(long id)
        {
            var obj = man.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult Borrar(long id, PersonaModel obj)
        {
            man.Borrar(id);
            return RedirectToAction("Index");
        }
    }
}