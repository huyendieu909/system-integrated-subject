using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bai13_Quy440_Api_Si.Controllers
{
    public class DonViController : ApiController
    {
        [HttpGet]
        public List<DonVi> GetDonVis()
        {
            QLLuongContext db = new QLLuongContext();
            List<DonVi> dv = db.DonVis.ToList();
            return dv;
        }
    }
}
