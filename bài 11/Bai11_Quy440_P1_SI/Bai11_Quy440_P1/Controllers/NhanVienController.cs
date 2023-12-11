using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace Bai11_Quy440_P1.Controllers
{
    public class NhanVienController : ApiController
    {
        [HttpDelete]
        public IHttpActionResult Delete(string ma)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                NhanVien nv = db.NhanViens.FirstOrDefault(x => x.Ma.Equals(ma));
                if (nv != null)
                {
                    db.NhanViens.Remove(nv);
                    db.SaveChanges();
                }
                else return NotFound();
            }
            return Ok("Du lieu da xoa");
        }
        [HttpGet]
        public List<NhanVien> GetByGender (string gender)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                if (gender == "nam")
                {
                    List<NhanVien> nv = db.NhanViens.Where(n => n.GioiTinh == "Nam").ToList();
                    return nv;
                }
                else if (gender == "nu")
                {
                    List<NhanVien> nv = db.NhanViens.Where(x => x.GioiTinh == "Nữ").ToList();
                    return nv;
                }
                else return null;
            }
        }
        [HttpGet] 
        public List<NhanVien> GetAllNhanVien()
        {
            using (QLLuongContext db  = new QLLuongContext())
            {
                return db.NhanViens.ToList();
            }
        }
        [HttpGet]
        public List<NhanVien> GetNhanVien(string ma)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                var query = from n in db.NhanViens
                            where n.Ma == ma
                            select n;
                return query.ToList();
            }
        }
        [HttpGet]
        public List<NhanVien> GetNhanVienDonVi(string madv)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                var query = from n in db.NhanViens 
                            where n.MaDonVi.Equals(madv)
                            select n;
                return query.ToList();
            }
        }
        [HttpGet]
        public List<NhanVien> GetBySalaryCoefficientRange(decimal a, decimal b)
        {
            using (QLLuongContext db = new QLLuongContext()){
                List<NhanVien> nv = db.NhanViens.Where(x => x.HSLuong >= a && x.HSLuong <= b).ToList();
                return nv;
            }
        }
        [HttpPost]
        public IHttpActionResult Add([FromBody] NhanVien nhanVien)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
            }
            return Ok("Du lieu da duoc cap nhat");
        }
        
    }
}
