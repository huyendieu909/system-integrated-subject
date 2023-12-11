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
using Bai12_Quy440_Api;

namespace form_bai12_1_1
{
    public partial class form_bai12_1_1 : Form
    {
        public form_bai12_1_1()
        {
            InitializeComponent();
        }

        private void btnGetByMaDM_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8089/api/sanpham?madm={tbMaDM.Text}");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] sp = data as SanPham[];
            dtgSanPham.DataSource = sp;
        }

        private void btnGetByPrice_Click(object sender, EventArgs e)
        {
            if (CheckNgoaiLe())
            {
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
                HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8089/api/sanpham?a={a}&b={b}");
                WebResponse response = request.GetResponse();
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
                object data = js.ReadObject(response.GetResponseStream());
                SanPham[] sp = data as SanPham[];
                dtgSanPham.DataSource = sp;
            }
            
        }
        public bool CheckNgoaiLe()
        {
            try
            {
                int a = int.Parse(tbA.Text);
                int b = int.Parse(tbB.Text);
            }
            catch
            {
                MessageBox.Show("Khoảng giá phải là số nguyên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
