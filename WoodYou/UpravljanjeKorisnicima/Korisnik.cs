//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpravljanjeKorisnicima
{
    using System;
    using System.Collections.Generic;
    
    public partial class Korisnik
    {
        public int korisnikId { get; set; }
        public string korisnicko_ime { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string lozinka { get; set; }
        public int tip_korisnikaId { get; set; }
    
        public virtual Tip_korisnika Tip_korisnika { get; set; }
    }
}
