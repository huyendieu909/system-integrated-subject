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

namespace bai11_5
{
    public partial class bai11_5 : Form
    {
        public bai11_5()
        {
            InitializeComponent();
        }

        private void btnGetBySalary_Click(object sender, EventArgs e)
        {
            if (KhongCoNgoaiLe())
            {
                decimal a = decimal.Parse(tbA.Text);
                decimal b = decimal.Parse(tbB.Text);
                HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8087/api/nhanvien?a={a}&b={b}");
                WebResponse response = request.GetResponse(); 
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
                object data = js.ReadObject(response.GetResponseStream());
                NhanVien[] nv = data as NhanVien[];
                dtgNhanVien.DataSource = nv;
            }
            
        }
        public bool KhongCoNgoaiLe()
        {
            try
            {
                decimal a = decimal.Parse(tbA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Khoảng lương là số thập phân!");
                return false;
            }
            try
            {
                decimal b = decimal.Parse(tbB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Khoảng lương là số thập phân!");
                return false;
            }
            return true;
        }
    }
}
