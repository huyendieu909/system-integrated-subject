using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Bai12_Quy440_Api
{
    public class CSDLQLBanHangContext : DbContext
    {
        public CSDLQLBanHangContext() : base("Data Source=huyen-dieu-acer;Initial Catalog=CSDLQLBanHang;Persist Security Info=True;User ID=ahihi;Password=abc123") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();  
        }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
    }
}