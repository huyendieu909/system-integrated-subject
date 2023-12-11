using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bai12_Quy440_Api
{
    public class DanhMuc
    {
        [Key]
        public string MaDanhMuc {  get; set; }
        public string TenDanhMuc { get; set; }
    }
}