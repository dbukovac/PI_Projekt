//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpravljanjeProjektima
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projekt()
        {
            this.Faze_projekta = new HashSet<Faze_projekta>();
        }
    
        public int projektId { get; set; }
        public string ime { get; set; }
        public System.DateTime datum_pocetka { get; set; }
        public Nullable<int> potrebno_vrijeme { get; set; }
        public Nullable<System.DateTime> datum_zavrsetka { get; set; }
        public Nullable<double> ukupna_cijena { get; set; }
        public Nullable<double> cijena_bez_pdv { get; set; }
        public Nullable<double> iznos_pdv { get; set; }
        public int korisnikId { get; set; }
        public int partnerId { get; set; }
        public byte gotovo { get; set; }
        public byte aktivan { get; set; }
        public Nullable<System.DateTime> datum_izdavanja_racuna { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faze_projekta> Faze_projekta { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Partner Partner { get; set; }
    }
}
