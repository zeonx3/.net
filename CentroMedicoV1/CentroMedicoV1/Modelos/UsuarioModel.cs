using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class UsuarioModel
    {
        private int idusuario;
        private string usuario;
        private string clave;
        private string email;

        public UsuarioModel()
        {
        }

        public int Idusuario { get => idusuario; set => idusuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Email { get => email; set => email = value; }
    }
}