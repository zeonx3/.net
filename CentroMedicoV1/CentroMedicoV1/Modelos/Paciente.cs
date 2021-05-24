using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Paciente
    {
        private int idpaciente;
        private string nombres;
        private string apellidos;
        private string email;
        private int telefono;
        private string genero;
        private int edad;

        public Paciente()
        {
        }

        public Paciente(
            int idpaciente, 
            string nombres, 
            string apellidos, 
            string email, 
            int telefono, 
            string genero, 
            int edad)
        {
            this.idpaciente = idpaciente;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.genero = genero;
            this.edad = edad;
        }

        public int Idpaciente { get => idpaciente; set => idpaciente = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Edad { get => edad; set => edad = value; }

        public string NomPaciente
        {
            get
            {
                return nombres + " " + apellidos;
            }
        }
    }
}