using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Estado
    {
        private int idestado;
        private string descripcion;

        public Estado()
        {
        }

        public Estado(int idestado, string descripcion)
        {
            this.idestado = idestado;
            this.descripcion = descripcion;
        }

        public int Idestado { get => idestado; set => idestado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}