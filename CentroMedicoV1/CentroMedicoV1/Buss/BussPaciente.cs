using Data;
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
        public static DataTable Listar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from paciente";
            return db.ejecutarConsulta(cmd);
        }
    }
}