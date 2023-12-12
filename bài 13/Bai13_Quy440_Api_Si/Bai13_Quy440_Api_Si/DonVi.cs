using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai13_Quy440_Api_Si
{
    public class DonVi
    {
        [Key]
        public string MaDonVi {  get; set; }
        public string TenDonVi { get; set; }
    }
}