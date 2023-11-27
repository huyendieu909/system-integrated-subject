using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai9_Quy440_P1.Controllers
{
    public class SanPhamController : ApiController
    {
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            //CSDLQLBanHangDataContext db = new CSDLQLBanHangDataContext("Data Source=HUYEN-DIEU-ACER;Initial Catalog=CSDLQLBanHang;Integrated Security=True");
            CSDLQLBanHangContext db = new CSDLQLBanHangContext();
            List<SanPham> lsp = db.SanPhams.ToList();
            foreach (SanPham p in lsp)
            {
                if (p != null)
                {
                    p.DanhMuc = null;
                }
            }
            return lsp;
        }

        [HttpGet]
        public SanPham LaySanPhamTheoID(string id)
        {
            CSDLQLBanHangDataContext db = new CSDLQLBanHangDataContext("Data Source=HUYEN-DIEU-ACER;Initial Catalog=CSDLQLBanHang;Integrated Security=True");
            SanPham sp = db.SanPhams.First(x => x.Ma.Equals(id));
            if (sp != null) {sp.DanhMuc = null;}
            return sp;
        }

    }
}
