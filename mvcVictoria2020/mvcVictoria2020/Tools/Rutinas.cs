using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tools
{
    public class Rutinas
    {

        public static string right(string cadena, int largo)
        {
            for (int i = 0; i < largo; i++)
            {
                cadena += "0" + cadena;
            }
            return cadena.Substring(cadena.Length - largo);
        }

        public static string formato (int m)
        {
            string f;
            if (m == 0)
            {
                f = "$0";
            }
            else
            {
                f = "$" + m.ToString("###,###,###,###");
            }
            return f;
        }


    }


}