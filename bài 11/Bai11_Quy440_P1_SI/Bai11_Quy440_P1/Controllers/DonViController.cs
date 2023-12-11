using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai11_Quy440_P1.Controllers
{
    public class DonViController : ApiController
    {
        [HttpGet]
        public List<DonVi> GetAll()
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                List<DonVi> dv = db.DonVis.ToList();
                return dv;
            }
        }
        [HttpGet]
        public List<DonVi> Get(string madv)
        {
            using (QLLuongContext db = new QLLuongContext())
            {
                List<DonVi> dv = db.DonVis.Where(x => x.MaDonVi.Equals(madv)).ToList();
                return dv;
            }
        }
    }
}
