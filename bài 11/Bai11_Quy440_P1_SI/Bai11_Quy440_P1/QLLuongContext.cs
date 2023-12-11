using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Bai11_Quy440_P1
{
    public class QLLuongContext : DbContext
    {
        public QLLuongContext() : base("Data Source=huyen-dieu-acer;Initial Catalog=QLLuong;Persist Security Info=True;User ID=ahihi; Password=abc123") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DonVi> DonVis { get; set; }
    }
}