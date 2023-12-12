using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai13_Quy440_Api_P2_Si.Controllers
{
    public class DanhMucController : ApiController
    {
        [HttpGet] 
        public List<DanhMuc> GetDanhMucs()
        {
            CSDLQLBanHangContext db = new CSDLQLBanHangContext();
            List<DanhMuc> dm = db.DanhMucs.ToList();
            return dm;
        }
    }
}
