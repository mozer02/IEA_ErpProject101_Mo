﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProject101_Main.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ErpProjectWMPEntities : DbContext
    {
        public ErpProjectWMPEntities()
            : base("name=ErpProjectWMPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCariGruplari> tblCariGruplari { get; set; }
        public virtual DbSet<tblCariler> tblCariler { get; set; }
        public virtual DbSet<tblDepartmanlar> tblDepartmanlar { get; set; }
        public virtual DbSet<tblPersonelDetay> tblPersonelDetay { get; set; }
        public virtual DbSet<tblSehirler> tblSehirler { get; set; }
        public virtual DbSet<tblStokDurum> tblStokDurum { get; set; }
        public virtual DbSet<tblStokGirisAlt> tblStokGirisAlt { get; set; }
        public virtual DbSet<tblStokGirisUst> tblStokGirisUst { get; set; }
        public virtual DbSet<tblUrunler> tblUrunler { get; set; }
    }
}
