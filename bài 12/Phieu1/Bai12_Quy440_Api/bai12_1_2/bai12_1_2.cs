using Bai12_Quy440_Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bai12_1_2
{
    public partial class bai1212 : Form
    {
        public bai1212()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string postString = string.Format($"?madm={tbMaDM.Text}&tendm={tbTenDM.Text}");
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8089/api/danhmuc" + postString);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] bytesArray = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = bytesArray.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(bytesArray, 0, bytesArray.Length);
            stream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq) { MessageBox.Show("Đã lưu!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); HienThiDM(); }
            else MessageBox.Show("Lưu thất bại!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dtgDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bai1212_Load(object sender, EventArgs e)
        {
            HienThiDM();
        }
        public void HienThiDM ()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8089/api/danhmuc");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] dm = data as DanhMuc[];
            dtgDanhMuc.DataSource = dm;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format($"?madm={tbMaDM.Text}&tendm={tbTenDM.Text}");
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8089/api/danhmuc" + putString);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] bytesArr = Encoding.UTF8.GetBytes(putString);
            request.ContentLength = bytesArr.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(bytesArr, 0, bytesArr.Length);
            stream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Đã sửa!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDM();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DanhMuc dm = dtgDanhMuc.CurrentRow.DataBoundItem as DanhMuc;
            if (dm != null)
            {
                tbMaDM.Text = dm.MaDanhMuc;
                tbTenDM.Text = dm.TenDanhMuc;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteString = string.Format($"?madm={tbMaDM.Text}");
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8089/api/danhmuc" + deleteString);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] bytesArr = Encoding.UTF8.GetBytes(deleteString);
            request.ContentLength = bytesArr.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(bytesArr, 0, bytesArr.Length);
            stream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Đã xóa!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                HienThiDM();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
