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
    
    public partial class tbl_provincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_provincia()
        {
            this.tbl_comuna = new HashSet<tbl_comuna>();
        }
    
        public int idprovincia { get; set; }
        public string desc_provincia { get; set; }
        public int idregion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_comuna> tbl_comuna { get; set; }
        public virtual tbl_region tbl_region { get; set; }
    }
}
