using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ClienteModel
    {
        public int idcliente { get; set; }
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
    }
}