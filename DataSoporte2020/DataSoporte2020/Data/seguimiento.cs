//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataSoporte2020.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class seguimiento
    {
        public long idseguimiento { get; set; }
        public long idasignado { get; set; }
        public int fecha { get; set; }
        public string desc_seguimiento { get; set; }
        public int idestado { get; set; }
    
        public virtual asignado asignado { get; set; }
        public virtual estado estado { get; set; }
    }
}
