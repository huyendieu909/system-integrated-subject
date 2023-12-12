using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai13_Quy440_Api_Si.Controllers
{
    public class NhanVienController : ApiController
    {
        [HttpPost]
        public bool Add(string ma, string hoten, DateTime ngaysinh, string gioitinh, decimal hsluong, string madonvi)
        {
            try
            {
                QLLuongContext db = new QLLuongContext();
                NhanVien nv = new NhanVien();
                nv.Ma = ma;
                nv.HoTen = hoten;
                nv.NgaySinh = ngaysinh;
                nv.GioiTinh = gioitinh;
                nv.HSLuong = hsluong;
                nv.MaDonVi = madonvi;
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return true;
            } catch { }
            return false;
        }
        [HttpGet] 
        public List<NhanVien> GetAll()
        {
            QLLuongContext db = new QLLuongContext ();
            List<NhanVien> nv = db.NhanViens.ToList();
            return nv;
        }
        [HttpPut]
        public bool Update (string ma, string hoten, DateTime ngaysinh, string gioitinh, decimal hsluong, string madonvi)
        {
            try
            {
                QLLuongContext db = new QLLuongContext();
                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma.Equals(ma));
                if (nv != null)
                {
                    nv.Ma = ma;
                    nv.HoTen = hoten;
                    nv.NgaySinh = ngaysinh;
                    nv.GioiTinh = gioitinh;
                    nv.HSLuong = hsluong;
                    nv.MaDonVi = madonvi;
                    db.SaveChanges();
                    return true;
                }
            }catch { }
            return false;
        }
        [HttpDelete]
        public bool Delete (string ma)
        {
            try
            {
                QLLuongContext db = new QLLuongContext();
                NhanVien nv = db.NhanViens.First(x => x.Ma.Equals(ma));
                if (nv != null)
                {
                    db.NhanViens.Remove(nv);
                    db.SaveChanges() ;
                    return true;
                }
            } catch { }
            return false;
        }
    }
}
