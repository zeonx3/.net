using Buss;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            List<PacienteModel> lista = BussPaciente.listar();
            return View(lista);
        }
    }
}