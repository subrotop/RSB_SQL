﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSB_SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RSBEntities : DbContext
    {
        public RSBEntities()
            : base("name=RSBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RSBDiary> RSBDiary { get; set; }
        public virtual DbSet<PrivateContractor> PrivateContractors { get; set; }
        public virtual DbSet<TranscriptCopyType> TranscriptCopyTypes { get; set; }
        public virtual DbSet<TranscriptParticularType> TranscriptParticularTypes { get; set; }
        public virtual DbSet<TranscriptSoundType> TranscriptSoundTypes { get; set; }
    }
}