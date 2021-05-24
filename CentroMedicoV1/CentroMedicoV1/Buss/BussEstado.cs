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
    public class BussEstado
    {
        static BaseDatos db = new BaseDatos();
        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from estado";
            return db.ejecutarConsulta(cmd);
        }

        public static List<Estado> Listar02()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_estado";
            DataTable dt = db.ejecutarConsulta(cmd);
            List<Estado> lista = new List<Estado>();
            Estado obj;
            foreach (DataRow row in dt.Rows)
            {
                obj = new Estado();
                obj.Idestado = int.Parse(row["idestado"].ToString());
                obj.Descripcion = row["descripcion"].ToString();
                lista.Add(obj);
            }

            return lista;

        }

        public static Estado Buscar(int idestado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_estado";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idestado;
            DataTable dt = db.ejecutarConsulta(cmd);

            Estado obj = new Estado();

            if (dt != null && dt.Rows.Count > 0)
            {
                obj.Idestado = int.Parse(dt.Rows[0]["idestado"].ToString());
                obj.Descripcion = dt.Rows[0]["descripcion"].ToString();

            }
            else
            {
                obj = null;
            }
            return obj;
        }

        public static bool Insert(Estado obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_estado";
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;

            return db.ejecutarAccion(cmd);
        }

        public static bool update(Estado obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_estado";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = obj.Idestado;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion;

            return db.ejecutarAccion(cmd);
        }
        public static bool delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_estado";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = id;


            return db.ejecutarAccion(cmd);
        }

    }
}