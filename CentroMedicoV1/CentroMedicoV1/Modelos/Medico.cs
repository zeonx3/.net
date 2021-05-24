using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Medico
    {
        private int idmedico;
        private string nombres;
        private string apellidos;
        private string email;
        private int telefono;
        private Especialidad especialidad;

        public Medico()
        {
        }

        public Medico(
            int idmedico, 
            string nombres, 
            string apellidos, 
            string email, 
            int telefono, 
            Especialidad especialidad)
        {
            this.idmedico = idmedico;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.especialidad = especialidad;
        }

        public int Idmedico { get => idmedico; set => idmedico = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public Especialidad Especialidad { get => especialidad; set => especialidad = value; }
    
    
        public string NomMedico{
            get
            {
                return nombres + " " + apellidos;
            }
        }

        public string NomEspecialidad
        {
            get
            {
                return especialidad.Descripcion;
            }
        }
    }
}