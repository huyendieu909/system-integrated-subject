using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Bai11_Quy440_Si_Winform;

namespace bai11_3
{
    public partial class bai11_3 : Form
    {
        public bai11_3()
        {
            InitializeComponent();
        }

        private void btnGetDonVi_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8087/api/nhanvien?madv={tbMaDV.Text}");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nv = data as NhanVien[];
            dtgNhanVien.DataSource = nv;
        }
    }
}
