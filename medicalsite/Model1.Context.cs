﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace medicalsite
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedicalDBEntities : DbContext
    {
        public MedicalDBEntities()
            : base("name=MedicalDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Chabter1_Tbl> Chabter1_Tbl { get; set; }
        public virtual DbSet<Diseases_destails_tbl> Diseases_destails_tbl { get; set; }
        public virtual DbSet<Diseases_Tbl> Diseases_Tbl { get; set; }
        public virtual DbSet<dises_Description_tbl> dises_Description_tbl { get; set; }
        public virtual DbSet<Notes_Tbl> Notes_Tbl { get; set; }
        public virtual DbSet<Section_Tbl> Section_Tbl { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
