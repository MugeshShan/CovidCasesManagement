﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovidCaseManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CovidCasesDBEntities : DbContext
    {
        public CovidCasesDBEntities()
            : base("name=CovidCasesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Confirmed_Cases> Confirmed_Cases { get; set; }
        public virtual DbSet<Confirmed_Deaths> Confirmed_Deaths { get; set; }
        public virtual DbSet<Confirmed_Recoveries> Confirmed_Recoveries { get; set; }
        public virtual DbSet<Hospitalized_Details> Hospitalized_Details { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Patient_Details> Patient_Details { get; set; }
        public virtual DbSet<Tested_Individuals> Tested_Individuals { get; set; }
    }
}