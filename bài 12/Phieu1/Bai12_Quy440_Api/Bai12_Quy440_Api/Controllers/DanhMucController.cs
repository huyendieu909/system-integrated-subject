using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai12_Quy440_Api.Controllers
{
    public class DanhMucController : ApiController
    {
        [HttpGet]
        public List<DanhMuc> GetAll()
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                List<DanhMuc> dm = db.DanhMucs.ToList();
                return dm;
            }
        }
        [HttpPost] 
        public bool SaveADanhMuc (string madm, string tendm)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                DanhMuc dm = new DanhMuc();
                dm.MaDanhMuc = madm;
                dm.TenDanhMuc = tendm;
                db.DanhMucs.Add(dm);
                db.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }
        [HttpPut]
        public bool UpdateADanhMuc (string madm, string tendm)
        {
            try
            {
                CSDLQLBanHangContext db = new CSDLQLBanHangContext();
                DanhMuc dm = db.DanhMucs.FirstOrDefault(x => x.MaDanhMuc.Equals(madm));
                if (dm != null)
                {
                    dm.TenDanhMuc = tendm;
                    db.SaveChanges();
                    return true;
                }
            }
            catch { }
            return false;
        }
        
        [HttpDelete]
        public bool Delete(string madm)
        {
            CSDLQLBanHangContext db = new CSDLQLBanHangContext ();
            DanhMuc dm = db.DanhMucs.First(x => x.MaDanhMuc == madm);
            if (dm != null)
            {
                db.DanhMucs.Remove(dm);
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
