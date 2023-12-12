using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai13_Quy440_Api_P2_Si
{
    public class SanPham
    {
        [Key]
        public string Ma {  get; set; }
        public string Ten { get; set; }
        public int DonGia { get; set; }
        public string MaDanhMuc { get; set; }
    }
}