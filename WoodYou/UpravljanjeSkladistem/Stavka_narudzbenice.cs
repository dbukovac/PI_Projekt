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
    
    public partial class Stavka_narudzbenice
    {
        public int narudzbenicaId { get; set; }
        public int materijalId { get; set; }
        public int kolicina { get; set; }
    
        public virtual Materijal Materijal { get; set; }
        public virtual Narudzbenica Narudzbenica { get; set; }
    }
}
