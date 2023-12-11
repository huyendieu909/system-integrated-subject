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

namespace bai11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet1NV_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp($"http://localhost:8087/api/nhanvien?ma={tbMaNV.Text}");
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nv = data as NhanVien[];
            dtgNhanVien.DataSource = nv;
        }
    }
}
