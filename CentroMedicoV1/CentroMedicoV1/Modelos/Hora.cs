using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Hora
    {
        private int idhora;
        private DateTime fecha;
        private TimeSpan horaminuto;
        private Medico medico;
        private Estado estado;

        public Hora()
        {
        }

        public Hora(
            int idhora,
            DateTime fecha,
            TimeSpan horaminuto,
            Medico medico,
            Estado estado)
        {
            this.idhora = idhora;
            this.fecha = fecha;
            this.horaminuto = horaminuto;
            this.medico = medico;
            this.estado = estado;
        }

        public int Idhora { get => idhora; set => idhora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan Horaminuto { get => horaminuto; set => horaminuto = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public Estado Estado { get => estado; set => estado = value; }


        public string FechaTxt
        {
            get
            {
                if (fecha != null)
                {
                    string dia = right(fecha.Day.ToString(), 2);
                    string mes = right(fecha.Month.ToString(), 2);
                    string anno = right(fecha.Year.ToString(), 4);
                    return dia + "-" + mes + "-" + anno;
                }
                else
                {
                    return "-";
                }
            }
        }

        public string HoraminutoTxt
        {
            get
            {
                string hora = right(horaminuto.Hours.ToString(), 2);
                string minuto = right(horaminuto.Minutes.ToString(), 2);
                return hora + ":" + minuto;
            }
        }

        public string right(string cadena, int largo)
        {
            cadena = "0000000000" + cadena;
            return cadena.Substring(cadena.Length - largo);
        }
    }
}