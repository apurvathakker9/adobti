﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ADOBathindaEntities : DbContext
    {
        public ADOBathindaEntities()
            : base("name=ADOBathindaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Village> Villages { get; set; }
        public virtual DbSet<WorkName> WorkNames { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Schema> Schemas { get; set; }
    }
}