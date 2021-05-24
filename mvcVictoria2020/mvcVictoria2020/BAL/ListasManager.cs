using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BAL
{
    public class ListasManager
    {
        BaseDatos db = new BaseDatos();

        public List<ListasModel> Habitaciones()
        {
            var lista = (from t in db.habitacion
                         select new ListasModel
                         {
                             texto = "Hab. #"+t.numhab.ToString()+" - $"+t.valordia.ToString(),
                             valor = t.idhabitacion.ToString()
                         }).ToList();
            return lista;
        }

        public List<ListasModel> Clientes()
        {
            var lista = (from t in db.cliente
                         select new ListasModel
                         {
                             texto = t.nombres.ToString()+" "+t.apellidos.ToString(),
                             valor = t.idcliente.ToString()
                         }).ToList();
            return lista;
        }

        public List<ListasModel> Reservas()
        {
            var listar = (from t in db.reserva
                          join c in db.cliente on t.idcliente equals c.idcliente
                          join h in db.habitacion on t.idhabitacion equals h.idhabitacion
                          select new ListasModel
                          {
                              texto = c.nombres.ToString() + " " + c.apellidos.ToString()+" - Hab #"+h.numhab,
                              valor = t.idreserva.ToString()
                          }).ToList();
            return listar;
        }
    }
}