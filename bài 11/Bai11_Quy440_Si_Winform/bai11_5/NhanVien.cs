using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Bai11_Quy440_Si_Winform
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
        public NhanVien() { }
    }
}
