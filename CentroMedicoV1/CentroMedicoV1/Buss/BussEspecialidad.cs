using Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using Modelos;
using System.Web.UI.WebControls;

namespace Buss
{
    public class BussEspecialidad
    {
        static BaseDatos db = new BaseDatos();
        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_especialidad";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Especialidad>Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_especialidad";
            DataTable dt = db.ejecutarConsulta(cmd);
            List<Especialidad> lista = new List<Especialidad>();
            Especialidad obj;
            foreach(DataRow row in dt.Rows)
            {
                obj = new Especialidad();
                obj.Idespecialidad = int.Parse(row["idespecialidad"].ToString());
                obj.Descripcion = row["descripcion"].ToString();
                lista.Add(obj);
            }

            return lista;

        }

        public static Especialidad Buscar(int idespecialidad)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = idespecialidad;
            DataTable dt = db.ejecutarConsulta(cmd);

            Especialidad obj = new Especialidad();

            if(dt != null && dt.Rows.Count > 0)
            {
                obj.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Descripcion = dt.Rows[0]["descripcion"].ToString();

            }
            else
            {
                obj = null;
            }
            return obj;
        }



        public static bool Insert(Especialidad obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_especialidad";
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;

            return db.ejecutarAccion(cmd);
        }

        public static bool update(Especialidad obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = obj.Idespecialidad;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;

            return db.ejecutarAccion(cmd);
        }
        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_especialidad";
            cmd.Parameters.Add("@idespecialidad", SqlDbType.Int).Value = id;
            

            return db.ejecutarAccion(cmd);
        }


        public static DataTable filtro()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_filtro_especialidad";
            return db.ejecutarConsulta(cmd);
        }




    }
}