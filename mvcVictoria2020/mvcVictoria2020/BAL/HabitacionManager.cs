using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAL
{
    public class HabitacionManager
    {
        BaseDatos db = new BaseDatos();

        public List<HabitacionModel> Listar()
        {
            var listar = (from h in db.habitacion
                          select new HabitacionModel
                          {
                              idhabitacion = h.idhabitacion,
                              numhab = h.numhab,
                              detalle = h.detalle,
                              valordia = h.valordia
                             
                          }).ToList();
            return listar;
        }
    }
}