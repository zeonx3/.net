using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class PersonaModel
    {
        public long idpersona { get; set; }
        public string rut { get; set; }
        public string dv { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nombres { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string dir_calle { get; set; }
        public int dir_numero { get; set; }
        public int idcomuna { get; set; }
        public string desc_comuna { get; set; }

        public string RutCompleto
        {
            get
            {
                return rut + "-" + dv;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return nombres + " " + ap_paterno + " " + ap_materno;
            }
        }

        public string DirCompleta
        {
            get
            {
                return dir_calle + " #" + dir_numero;
            }
        }
    }
}