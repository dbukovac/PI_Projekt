//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrikazStatistike
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faza()
        {
            this.Faze_projekta = new HashSet<Faze_projekta>();
        }
    
        public int fazaId { get; set; }
        public string naziv { get; set; }
        public decimal cijena { get; set; }
        public int trajanje { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faze_projekta> Faze_projekta { get; set; }
    }
}
