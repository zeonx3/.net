using Buss;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class ReservaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            // Mis reservas

            int id = int.Parse(Session["idusuario"].ToString());

            List<MisReservasModel> lista = BussReserva.MisReservas(id);
            return View(lista);
        }

        [HttpGet]
        public ActionResult HorasDisponibles()
        {
            // Horas disponibles
            List<HorasDisponiblesModel> lista = BussReserva.HorasDisponibles();
            return View(lista);
        }

        [HttpPost]
        public ActionResult HorasDisponibles(FormCollection frm)
        {
            // Horas disponibles
            List<HorasDisponiblesModel> lista = BussReserva.HorasDisponibles();
            return View(lista);
        }

        [HttpGet]
        public ActionResult TomarHora(int id)
        {
            HoraModel obj = BussHora.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult TomarHora(int id, FormCollection frm)
        {
            int idpac = int.Parse(Session["idusuario"].ToString());

            ReservaModel obj = new ReservaModel();
            obj.Medico = new MedicoModel();
            obj.Medico.Idmedico = int.Parse(frm["idmedico"].ToString());
            obj.Paciente = new PacienteModel();
            obj.Paciente.Idpaciente = idpac;
            obj.Hora = new HoraModel();
            obj.Hora.Idhora = int.Parse(frm["idhora"].ToString());

            BussReserva.TomarHora(obj);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AnularReserva(int id)
        {
            MisReservasModel obj = BussReserva.Buscar(id);
            return View(obj);
        }

        [HttpPost]
        public ActionResult AnularReserva(int id, FormCollection frm)
        {
            BussReserva.AnularReserva(id);
            return RedirectToAction("Index");
        }
    }
}