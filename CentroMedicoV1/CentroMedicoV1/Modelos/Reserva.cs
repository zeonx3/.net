using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Reserva
    {
        private int idreserva;
        private Medico medico;
        private Paciente paciente;
        private Hora hora;

        public Reserva()
        {
        }

        public Reserva(
            int idreserva, 
            Medico medico, 
            Paciente paciente, 
            Hora hora)
        {
            this.idreserva = idreserva;
            this.medico = medico;
            this.paciente = paciente;
            this.hora = hora;
        }

        public int Idreserva { get => idreserva; set => idreserva = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public Paciente Paciente { get => paciente; set => paciente = value; }
        public Hora Hora { get => hora; set => hora = value; }
    }
}