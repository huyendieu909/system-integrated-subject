using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_Quy440_P1.Controllers
{
    public class DanhMucController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Insert([FromBody] DanhMuc danhMuc)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                db.DanhMucs.Add(danhMuc);
                db.SaveChanges();
            }
            return Ok("Du lieu da duoc them");
        }

        [HttpPost]
        [Route("api/sanpham")]        
        
        public IHttpActionResult InsertSanPham([FromBody] SanPham sanPham)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
            }
            return Ok("Du lieu da duoc them.");
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] DanhMuc danhMuc)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                DanhMuc dm = db.DanhMucs.Find(danhMuc.MaDanhMuc);
                if (dm != null)
                {
                    dm.MaDanhMuc = danhMuc.MaDanhMuc;
                    dm.TenDanhMuc = danhMuc.TenDanhMuc;
                }
                else return NotFound();
            }
            return Ok("Du lieu da duoc sua");
        }

        [HttpDelete]
        public IHttpActionResult Delete(string madm)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                DanhMuc dm = db.DanhMucs.FirstOrDefault(x => x.MaDanhMuc.Equals(madm));
                if (dm != null)
                {
                    db.DanhMucs.Remove(dm);
                    db.SaveChanges();
                }
                else { return NotFound(); }
            }
            return Ok("Du lieu da duoc xoa");
        }
        [HttpGet]
        public List<DanhMuc> LayHetDanhMuc()
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                List<DanhMuc> dm = db.DanhMucs.ToList();
                return dm;
            }
        }
        [HttpGet]
        [Route("api/sanpham")]
        public List<SanPham> LayHetSanPham()
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                List<SanPham> sp = db.SanPhams.ToList();
                return sp;
            }
        }
    }
}
