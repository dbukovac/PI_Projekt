//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpravljanjeNarudzbama
{
    using System;
    using System.Collections.Generic;
    
    public partial class Narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzbenica()
        {
            this.Stavka_narudzbenice = new HashSet<Stavka_narudzbenice>();
        }
    
        public int narudzbenicaId { get; set; }
        public System.DateTime datum { get; set; }
        public int korisnikId { get; set; }
        public int partnerId { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavka_narudzbenice> Stavka_narudzbenice { get; set; }
    }
}
