﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpicorDaily.Persistance.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DotitExtensionEntities : DbContext
    {
        public DotitExtensionEntities()
            : base("name=DotitExtensionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PICKERORDER> PICKERORDERs { get; set; }
        public virtual DbSet<PICKORDERDETAIL> PICKORDERDETAILs { get; set; }
        public virtual DbSet<WAREHOUSEEMPLOYEE> WAREHOUSEEMPLOYEEs { get; set; }
    }
}