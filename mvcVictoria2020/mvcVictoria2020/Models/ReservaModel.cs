using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tools;

namespace Models
{
    public class ReservaModel
    {
        public int idreserva { get; set; }
        public int idhabitacion { get; set; }
        public int idcliente { get; set; }

        public DateTime fecha { get; set; }
        public int numdias { get; set; }
        public DateTime fechaout { get; set; }
        public int total { get; set; }
        public int estado { get; set; }
        //habitacion

        public int numhab { get; set; }
        public string detalle { get; set; }
        public int valordia { get; set; }
        public string NumValordia
        {
            get
            {
                return "Hab. #" + numhab + " - $ " + valordia;
            }
        }

        //cliente

        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String email { get; set; }
        public int telefono { get; set; }

        public string NombreCliente
        {
            get
            {
                return nombres + " " + apellidos;
            }
        }
        public string FechainiTxt
        {
            get
            {
                string dia = Rutinas.right(fecha.Day.ToString(), 2);
                string mes = Rutinas.right(fecha.Month.ToString(), 2);
                string anno = Rutinas.right(fecha.Year.ToString(), 4);
                return dia + "-" + mes + "-" + anno;
            }
        }
        public string FechaoutTxt
        {
            get
            {
                string dia = Rutinas.right(fechaout.Day.ToString(), 2);
                string mes = Rutinas.right(fechaout.Month.ToString(), 2);
                string anno = Rutinas.right(fechaout.Year.ToString(), 4);
                return dia + "-" + mes + "-" + anno;
            }
        }

        public string EstadoTxt
        {
            get
            {
                string p = "";
                if (estado == 0)
                {
                    p = "Abonado";
                }
                else if (estado == 3)
                {
                    p = "Pendiente";
                }
                return p;
            }
        }

        public string Totaltxt
        {
            get
            {
                string p = Rutinas.formato(total);
                return p;
            }
        }
        
    }
}