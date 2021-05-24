﻿using Data;
using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Buss
{
    public class BussHora
    {
        static BaseDatos db = new BaseDatos();

        public static DataTable Listar01()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_hora";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = 0;
            return db.ejecutarConsulta(cmd);
        }

        public static List<Hora> Listar02(int idestado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_hora";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = idestado;
            DataTable dt = db.ejecutarConsulta(cmd);
            // new traspazar el dt a un List<Hora>
            List<Hora> lista = new List<Hora>();
            Hora obj;
            foreach (DataRow fila in dt.Rows)
            {
                obj = new Hora();
                obj.Idhora = int.Parse(fila["idhora"].ToString());
                obj.Fecha = DateTime.Parse(fila["fecha"].ToString());
                obj.Horaminuto = TimeSpan.Parse(fila["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(fila["idmedico"].ToString());
                obj.Medico.Nombres = fila["nombres"].ToString();
                obj.Medico.Apellidos = fila["apellidos"].ToString();
                obj.Medico.Email = fila["email"].ToString();
                obj.Medico.Telefono = int.Parse(fila["telefono"].ToString());

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Idespecialidad = int.Parse(fila["idespecialidad"].ToString());
                obj.Medico.Especialidad.Descripcion = fila["nom_especialidad"].ToString();

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(fila["idestado"].ToString());
                obj.Estado.Descripcion = fila["nom_estado"].ToString();

                lista.Add(obj);
            }

            return lista;
        }

        public static Hora Buscar(int idhora)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscar_hora";
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = idhora;
            DataTable dt = db.ejecutarConsulta(cmd);

            Hora obj = new Hora();
            if (dt != null && dt.Rows.Count > 0)
            {
                obj = new Hora();
                obj.Idhora = int.Parse(dt.Rows[0]["idhora"].ToString());
                obj.Fecha = DateTime.Parse(dt.Rows[0]["fecha"].ToString());
                obj.Horaminuto = TimeSpan.Parse(dt.Rows[0]["horaminuto"].ToString());

                obj.Medico = new Medico();
                obj.Medico.Idmedico = int.Parse(dt.Rows[0]["idmedico"].ToString());
                obj.Medico.Nombres = dt.Rows[0]["nombres"].ToString();
                obj.Medico.Apellidos = dt.Rows[0]["apellidos"].ToString();
                obj.Medico.Email = dt.Rows[0]["email"].ToString();
                obj.Medico.Telefono = int.Parse(dt.Rows[0]["telefono"].ToString());

                obj.Medico.Especialidad = new Especialidad();
                obj.Medico.Especialidad.Idespecialidad = int.Parse(dt.Rows[0]["idespecialidad"].ToString());
                obj.Medico.Especialidad.Descripcion = dt.Rows[0]["nom_especialidad"].ToString();

                obj.Estado = new Estado();
                obj.Estado.Idestado = int.Parse(dt.Rows[0]["idestado"].ToString());
                obj.Estado.Descripcion = dt.Rows[0]["nom_estado"].ToString();
            }
            else
            {
                obj = null;
            }

            return obj;
        }


        public static bool Insert(Hora obj)
        {
            SqlCommand cmd = new SqlCommand();
            // tipo de consulta
            cmd.CommandType = CommandType.StoredProcedure;
            // definir la consulta (nombre del procedure)
            cmd.CommandText = "sp_insert_hora";
            // parámetros
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.Fecha;
            cmd.Parameters.Add("@horaminuto", SqlDbType.Time).Value = obj.Horaminuto;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = obj.Estado.Idestado;
            // ejecutamos la consulta
            return db.ejecutarAccion(cmd);
        }

        public static bool Update(Hora obj)
        {
            SqlCommand cmd = new SqlCommand();
            // tipo de consulta
            cmd.CommandType = CommandType.StoredProcedure;
            // definir la consulta (nombre del procedure)
            cmd.CommandText = "sp_update_hora";
            // parámetros
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = obj.Idhora;
            cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = obj.Fecha;
            cmd.Parameters.Add("@horaminuto", SqlDbType.Time).Value = obj.Horaminuto;
            cmd.Parameters.Add("@idmedico", SqlDbType.Int).Value = obj.Medico.Idmedico;
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = obj.Estado.Idestado;
            // ejecutamos la consulta
            return db.ejecutarAccion(cmd);
        }

        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            // tipo de consulta
            cmd.CommandType = CommandType.StoredProcedure;
            // definir la consulta (nombre del procedure)
            cmd.CommandText = "sp_delete_hora";
            // parámetros
            cmd.Parameters.Add("@idhora", SqlDbType.Int).Value = id;
            // ejecutamos la consulta
            return db.ejecutarAccion(cmd);
        }



        public static DataTable comb()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_comb_fecha";
            return db.ejecutarConsulta(cmd);
        }

        public static DataTable comb2()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_listar_hora";
            cmd.Parameters.Add("@idestado", SqlDbType.Int).Value = 1;
            return db.ejecutarConsulta(cmd);
        }
    }
}