//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipos_Movimientos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipos_Movimientos()
        {
            this.Asientos_Contables = new HashSet<Asientos_Contables>();
            this.Trasnsacciones = new HashSet<Trasnsaccione>();
        }
    
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Asientos_Contables> Asientos_Contables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trasnsaccione> Trasnsacciones { get; set; }
    }
}
