﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Bai9_Quy440_P1
{
    public class CSDLQLBanHangContext : DbContext
    {
        public CSDLQLBanHangContext() : base("Data Source=HUYEN-DIEU-ACER;Initial Catalog=CSDLQLBanHang;Integrated Security=True") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
    }
}