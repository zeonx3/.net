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
    
    public partial class tbl_comuna
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_comuna()
        {
            this.persona = new HashSet<persona>();
            this.sucursal = new HashSet<sucursal>();
        }
    
        public int idcomuna { get; set; }
        public string desc_comuna { get; set; }
        public int idregion { get; set; }
        public int idprovincia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<persona> persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sucursal> sucursal { get; set; }
        public virtual tbl_provincia tbl_provincia { get; set; }
        public virtual tbl_region tbl_region { get; set; }
    }
}
