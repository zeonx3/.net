using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Models
{
    public class PacienteModel
    {
        public int idpaciente { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String email { get; set; }
        public int telefono { get; set; }
        public char genero { get; set; }
        public int edad { get; set; }

        public PacienteModel() 
        {
            nombres = string.Empty;
            apellidos = string.Empty;
            email = string.Empty;
        }




    }
}