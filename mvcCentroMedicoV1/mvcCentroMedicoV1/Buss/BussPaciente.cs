using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Buss
{

    public class BussPaciente
    {
        static BaseDatos db = new BaseDatos();
        public static List<PacienteModel> listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_paciente";
            DataTable dt = db.ejecutarConsulta(cmd);
            List<PacienteModel> lista = new List<PacienteModel>();
            PacienteModel obj;
            foreach (DataRow row in dt.Rows)
            {
                obj = new PacienteModel();
                obj.idpaciente = int.Parse(row["idpaciente"].ToString());
                obj.nombres = row["nombres"].ToString();
                obj.apellidos = row["apellidos"].ToString();
                obj.email = row["email"].ToString();
                obj.telefono = int.Parse(row["telefono"].ToString());
                obj.genero = char.Parse(row["genero"].ToString());
                obj.edad = int.Parse(row["edad"].ToString());

                lista.Add(obj);
            }
            
            
            return lista;

        }

        public static PacienteModel Buscar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_paciente";
            cmd.Parameters.Add("@idpaciente", SqlDbType.Int).Value = id;
            DataTable dt = db.ejecutarConsulta(cmd);
            PacienteModel obj = new PacienteModel();
            foreach (DataRow row in dt.Rows)
            {
                obj = new PacienteModel();
                obj.idpaciente = int.Parse(row["idpaciente"].ToString());
                obj.nombres = row["nombres"].ToString();
                obj.apellidos = row["apellidos"].ToString();
                obj.email = row["email"].ToString();
                obj.telefono = int.Parse(row["telefono"].ToString());
                obj.genero = char.Parse(row["genero"].ToString());
                obj.edad = int.Parse(row["edad"].ToString());
            }


            return obj;

        }
    }
}