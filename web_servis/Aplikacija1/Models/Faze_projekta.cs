//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacija1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faze_projekta
    {
        public int id { get; set; }
        public int projektId { get; set; }
        public int fazaId { get; set; }
        public byte zakljucano { get; set; }
    
        public virtual Faza Faza { get; set; }
        public virtual Projekt Projekt { get; set; }
    }
}
