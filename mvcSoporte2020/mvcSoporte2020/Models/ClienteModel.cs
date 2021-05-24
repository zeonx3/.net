using BAL;
using DataSoporte2020.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ClienteModel
    {
        public long idcliente { get; set; }
        public long idpersona { get; set; }
        public int idplan { get; set; }
        public DateTime fechaini { get; set; }
        public string desc_plan { get; set; }
        public int costo { get; set; }
        public PersonaModel persona { get; set; }

        public string NombreCliente
        {
            get
            {
                var per = new PersonaManager();
                return per.Buscar(idpersona).NombreCompleto;
            }
        }

        public string FechainiTxt
        {
            get
            {
                string dia = Rutinas.right(fechaini.Day.ToString(), 2);
                string mes = Rutinas.right(fechaini.Month.ToString(), 2);
                string anno = Rutinas.right(fechaini.Year.ToString(), 4);
                return dia + "-" + mes + "-" + anno;
            }
        }


    }
}