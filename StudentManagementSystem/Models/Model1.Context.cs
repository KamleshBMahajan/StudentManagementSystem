﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentDataEntities : DbContext
    {
        public StudentDataEntities()
            : base("name=StudentDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<batch_Details> batch_Details { get; set; }
        public virtual DbSet<cource_Details> cource_Details { get; set; }
        public virtual DbSet<registration> registrations { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
