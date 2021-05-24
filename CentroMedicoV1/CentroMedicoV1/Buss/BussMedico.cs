using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Buss
{
    public class BussMedico
    {
        static BaseDatos db = new BaseDatos();
        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_medico";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Medico> Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_medico";
            DataTable dt= db.ejecutarConsulta(cmd);
            List<Medico> lista = new List<Medico>();
            Medico obj;
            foreach(DataRow row in dt.Rows)
            {
                obj = new Medico();
                obj.Idmedico = int.Parse(row["idmedico"].ToString());
                obj.Nombres = row["nombres"].ToString();
                obj.Apellidos = row["apellidos"].ToString();
                obj.Email = row["email"].ToString();
                obj.Telefono = int.Parse(row["telefono"].ToString());

                obj.Especialidad = new Especialidad();
                obj.Especialidad.Idespecialidad= int.Parse(row["idespecialidad"].ToString());
                obj.Especialidad.Descripcion = row["nom_especialidad"].ToString();

                lista.Add(obj);
            }
            return lista;
        }




        public static bool Insert(Medico obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_medico";
            cmd.Parameters.Add("@nombres", SqlDbType.VarChar, 50).Value = obj.Nombres;
            cmd.Parameters.Add("@apellidos", SqlDbType.VarChar, 50).Value = obj.Apellidos;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = obj.Email;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = obj.Telefono;
            cmd.Parameters.Add("@idespecialidad", SqlDbType.VarChar, 50).Value = obj.Especialidad.Idespecialidad;
            return db.ejecutarAccion(cmd);
        }

        public static DataTable filtro(int idestado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_filtro_medico";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = idestado;
            return db.ejecutarConsulta(cmd);
        }



    }
}