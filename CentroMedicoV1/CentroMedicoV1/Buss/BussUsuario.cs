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
    public class BussUsuario
    {
        static BaseDatos db = new BaseDatos();
        public static DataTable Validar(UsuarioModel obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_valida_usuario";
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = obj.Usuario;
            cmd.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = obj.Clave;
            return db.ejecutarConsulta(cmd);
        }
    }
}