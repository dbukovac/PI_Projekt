﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrikazStatistikeEntities : DbContext
    {
        public PrikazStatistikeEntities()
            : base("name=PrikazStatistikeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Faza> Faza { get; set; }
        public virtual DbSet<Faza_ima_materijal> Faza_ima_materijal { get; set; }
        public virtual DbSet<Faze_projekta> Faze_projekta { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<Materijal> Materijal { get; set; }
        public virtual DbSet<Narudzbenica> Narudzbenica { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Primka> Primka { get; set; }
        public virtual DbSet<Projekt> Projekt { get; set; }
        public virtual DbSet<Stavka_narudzbenice> Stavka_narudzbenice { get; set; }
        public virtual DbSet<Stavka_primke> Stavka_primke { get; set; }
        public virtual DbSet<Tip_korisnika> Tip_korisnika { get; set; }
        public virtual DbSet<Tip_partnera> Tip_partnera { get; set; }
    }
}
