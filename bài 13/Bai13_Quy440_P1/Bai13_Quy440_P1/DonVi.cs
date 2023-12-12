using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bai13_Quy440_P1
{
    [DataContract]
    internal class DonVi
    {
        [DataMember]
        public string MaDonVi { get; set; }
        [DataMember]
        public string TenDonVi { get; set; }
    }
}
