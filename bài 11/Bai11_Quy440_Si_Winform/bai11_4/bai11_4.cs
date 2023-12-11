using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Bai11_Quy440_Si_Winform;

namespace bai11_4
{
    public partial class bai11_4 : Form
    {
        public bai11_4()
        {
            InitializeComponent();
        }
        string gender = "";
        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            gender = "";
            gender += "nu";
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            gender = "";
            gender = "nam";
        }

        private void btnGetByGender_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8087/api/nhanvien?gender={gender}");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nv = data as NhanVien[];
            dtgNhanVien.DataSource = nv;
        }
    }
}
