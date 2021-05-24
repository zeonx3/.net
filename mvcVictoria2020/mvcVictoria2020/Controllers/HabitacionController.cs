using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class HabitacionController : Controller
    {
       HabitacionManager man = new HabitacionManager();
        public ActionResult Index()
        {
            return View(man.Listar());
        }
    }
}