using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bai13_Quy440_P1
{
    [DataContract]
    internal class NhanVien
    {
        [DataMember]
        public string Ma { get; set; }
        [DataMember]
        public string HoTen { get; set; }
        [DataMember]
        public string NgaySinh { get; set; }
        [DataMember]
        public string GioiTinh { get; set; }
        [DataMember]
        public decimal HSLuong { get; set; }
        [DataMember]
        public string MaDonVi { get; set; }
    }
}
