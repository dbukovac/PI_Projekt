//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpravljanjeSkladistem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Materijal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materijal()
        {
            this.Stavka_narudzbenice = new HashSet<Stavka_narudzbenice>();
        }
    
        public int materijalId { get; set; }
        public string naziv { get; set; }
        public int kolicina { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_narudzbenice> Stavka_narudzbenice { get; set; }
    }
}
