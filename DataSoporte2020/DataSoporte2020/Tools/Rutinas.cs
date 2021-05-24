using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataSoporte2020.Tools
{
    public class Rutinas
    {
        static string key { get; set; } = "!123456789$nNeEtTaAccCCeEsSS#$%&";
        public static string CifrarClave(string cadena)
        {
            var md5 = new MD5CryptoServiceProvider();

            var tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            var transform = tdes.CreateEncryptor();
            byte[] textBytes = UTF8Encoding.UTF8.GetBytes(cadena);
            byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
            return Convert.ToBase64String(bytes, 0, bytes.Length);

        }

        public static string txtSession()
        {
            return "S0P0RT3-2020";
        }

        public static bool ValidaRut(int rut, string dv)
        {
            var std = false;
            string dig = "";

            int suma = 0;
            int factor = 1;
            while (rut != 0)
            {
                factor++;
                if (factor == 8)
                    factor = 2;
                suma += (rut % 10) * factor;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                dig = "0";
            }
            else if (suma == 10)
            {
                dig = "K";
            }
            else
            {
                dig = suma.ToString();
            }
            if (dig.Equals(dv, StringComparison.OrdinalIgnoreCase))
            {
                std = true;
            }
            return std;
        }

        public static string right(string cadena, int largo)
        {
            for(int i = 0; i < largo; i++)
            {
                cadena += "0" + cadena;
            }
            return cadena.Substring(cadena.Length - largo);
        }

        
    }
}
