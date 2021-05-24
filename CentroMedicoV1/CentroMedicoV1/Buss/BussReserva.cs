using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CentroMedicoV1.Buss
{
    public class BussReserva
    {
        static BaseDatos db = new BaseDatos();
        public static List<Reserva> Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_reserva";
            DataTable dt = db.ejecutarConsulta(cmd);
            List<Reserva> lista = new List<Reserva>();
            Reserva obj;
            foreach (DataRow row in dt.Rows)
            {
                obj = new Reserva();
                obj.Idreserva = int.Parse(row["idreserva"].ToString());

                obj.Hora = new Hora();
                obj.Hora.Fecha = DateTime.Parse(row["fecha"].ToString());
                obj.Hora.Horaminuto = TimeSpan.Parse(row["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Nombres = row["nom_medicos"].ToString();
                obj.Medico.Apellidos = row["ape_medicos"].ToString();

                obj.Paciente = new Paciente();
                obj.Paciente.Nombres = row["nom_pacientes"].ToString();
                obj.Paciente.Apellidos = row["ape_pacientes"].ToString();

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Descripcion = row["nom_especialidad"].ToString();

                lista.Add(obj);

            }

            return lista;
        }
        public static List<Reserva> Listar02(int idhora, int idmedico, int idespcialidad)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar2_reserva";
            cmd.Parameters.Add("@idfecha", SqlDbType.Int).Value = idhora;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = idmedico;
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = idespcialidad;
            DataTable dt = db.ejecutarConsulta(cmd);
            List<Reserva> lista = new List<Reserva>();
            Reserva obj;
            foreach (DataRow row in dt.Rows)
            {
                obj = new Reserva();
                obj.Idreserva = int.Parse(row["idreserva"].ToString());

                obj.Hora = new Hora();
                obj.Hora.Fecha = DateTime.Parse(row["fecha"].ToString());
                obj.Hora.Horaminuto = TimeSpan.Parse(row["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Nombres = row["nom_medicos"].ToString();
                obj.Medico.Apellidos = row["ape_medicos"].ToString();

                obj.Paciente = new Paciente();
                obj.Paciente.Nombres = row["nom_pacientes"].ToString();
                obj.Paciente.Apellidos = row["ape_pacientes"].ToString();

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Descripcion = row["nom_especialidad"].ToString();

                lista.Add(obj);

            }

            return lista;
        }


        public static bool Insert(Reserva obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_reserva";
            cmd.Parameters.Add("@idpaciente", SqlDbType.Int).Value = obj.Paciente.Idpaciente;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = obj.Hora.Idhora;

            return db.ejecutarAccion(cmd);
        }

        public static Reserva Buscar(int idreserva)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_reserva";
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = idreserva;
            DataTable dt = db.ejecutarConsulta(cmd);
            Reserva obj = new Reserva();
            if (dt !=null && dt.Rows.Count > 0)
            {
                
                obj.Idreserva = int.Parse(dt.Rows[0]["idreserva"].ToString());

                obj.Hora = new Hora();
                obj.Hora.Idhora = int.Parse(dt.Rows[0]["idhora"].ToString());
                obj.Hora.Fecha = DateTime.Parse(dt.Rows[0]["fecha"].ToString());
                obj.Hora.Horaminuto = TimeSpan.Parse(dt.Rows[0]["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(dt.Rows[0]["idmedico"].ToString());
                obj.Medico.Nombres = dt.Rows[0]["nom_medicos"].ToString();
                obj.Medico.Apellidos = dt.Rows[0]["ape_medicos"].ToString();

                obj.Paciente = new Paciente();
                obj.Paciente.Idpaciente = int.Parse(dt.Rows[0]["idpaciente"].ToString());
                obj.Paciente.Nombres = dt.Rows[0]["nom_pacientes"].ToString();
                obj.Paciente.Apellidos = dt.Rows[0]["ape_pacientes"].ToString();

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Medico.Especialidad.Descripcion = dt.Rows[0]["nom_especialidad"].ToString();

                

            }
            else
            {
                obj = null;
            }
            return obj;




        }
        public static bool Update(Reserva obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_reserva";
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = obj.Idreserva;
            cmd.Parameters.Add("@idpaciente", SqlDbType.Int).Value = obj.Paciente.Idpaciente;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = obj.Hora.Idhora;

            return db.ejecutarAccion(cmd);
        }

        public static bool delete(Reserva obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_reserva";
            cmd.Parameters.Add("@idreserva", SqlDbType.Int).Value = obj.Idreserva;

            return db.ejecutarAccion(cmd);
        }

    }
}