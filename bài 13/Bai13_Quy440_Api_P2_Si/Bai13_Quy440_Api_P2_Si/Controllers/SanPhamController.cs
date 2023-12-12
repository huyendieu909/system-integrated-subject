using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai13_Quy440_Api_P2_Si.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> GetSanPhams()
        {
            CSDLQLBanHangContext db = new CSDLQLBanHangContext();
            List<SanPham> sp = db.SanPhams.ToList();
            return sp;
        }
        [HttpPost]
        public bool Luu(string ma, string ten, int dongia, string madanhmuc)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                SanPham sp = new SanPham();
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = dongia;
                sp.MaDanhMuc = madanhmuc;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        [HttpPost]
        public bool Luu2(SanPham sp)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        [HttpDelete]
        public bool Xoa(string ma)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                SanPham sp = db.SanPhams.First(x => x.Ma.Equals(ma));
                if (sp != null)
                {
                    db.SanPhams.Remove(sp);
                    db.SaveChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        [HttpPut]
        public bool Sua(string ma, string ten, int dongia, string madanhmuc)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                SanPham sp = db.SanPhams.First(x => x.Ma.Equals(ma));
                if (sp != null)
                {
                    sp.Ma = ma;
                    sp.Ten = ten;
                    sp.DonGia = dongia;
                    sp.MaDanhMuc = madanhmuc;
                    db.SaveChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        [HttpPut] 
        public bool Sua2(SanPham sp)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                SanPham _sp = db.SanPhams.FirstOrDefault(x => x.Ma.Equals(sp.Ma));
                if (_sp != null)
                {
                    _sp.Ma = sp.Ma;
                    _sp.Ten = sp.Ten;
                    _sp.DonGia = sp.DonGia;
                    _sp.MaDanhMuc = sp.MaDanhMuc;
                    db.SaveChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
    }
}
