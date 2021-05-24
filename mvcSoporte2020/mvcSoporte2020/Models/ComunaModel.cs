using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ComunaModel
    {
        public int idcomuna { get; set; }
        public int idprovincia { get; set; }
        public int idregion { get; set; }
        public string desc_comuna { get; set; }
        public string desc_provincia { get; set; }
        public string desc_region { get; set; }
    }
}