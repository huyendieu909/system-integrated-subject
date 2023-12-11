using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai12_Quy440_Api.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> GetByDanhMuc (string madm)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext())
            {
                List<SanPham> sp = db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList();
                return sp;
            }
        }
        [HttpGet]
        public List<SanPham> GetByPriceRange(int a, int b)
        {
            using (CSDLQLBanHangContext db = new CSDLQLBanHangContext ())
            {
                List<SanPham> sp = db.SanPhams.Where(x => x.DonGia >= a && x.DonGia <= b).ToList();
                return sp;
            }
        }
    }
}
