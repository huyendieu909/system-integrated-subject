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
using System.IO;

namespace Bai13_Quy440_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiBang();
            cbMaDV.DataSource = LayDanhSachDV();
            cbMaDV.DisplayMember = "TenDonVi";
            cbMaDV.SelectedIndex = 0;
            cbMaDV.ValueMember = "MaDonVi";
        }
        public void HienThiBang ()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/nhanvien");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nv = data as NhanVien[];
            dtgNhanVien.DataSource = nv;
            dtgNhanVien.Columns[0].HeaderText = "Mã";
            dtgNhanVien.Columns[1].HeaderText = "Họ tên";
            dtgNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dtgNhanVien.Columns[3].HeaderText = "Giới tính";
            dtgNhanVien.Columns[4].HeaderText = "Hệ số lương";
            dtgNhanVien.Columns[5].HeaderText = "Mã đơn vị";
        }
        internal NhanVien[] LayDanhSachNV ()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/nhanvien");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = js.ReadObject(response.GetResponseStream());
            NhanVien[] nv = data as NhanVien[];
            return nv;
        }
        internal DonVi[] LayDanhSachDV()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/donvi");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi[] dv = data as DonVi[];
            return dv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckNgoaiLeLuu())
            {
                string gioitinh = (radNam.Checked == true) ? "Nam" : "Nữ";
                string postString = string.Format($"?ma={tbMa.Text}&hoten={tbHoTen.Text}&ngaysinh={dtpNgaySinh.Value}&gioitinh={gioitinh}&hsluong={tbHSLuong.Text}&madonvi={cbMaDV.SelectedValue}");
                HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/nhanvien" + postString);
                request.Method = "POST";
                request.ContentType = "application/json;charset=UTF-8";
                byte[] bytesArr = Encoding.UTF8.GetBytes(postString);
                request.ContentLength = bytesArr.Length;
                Stream stream = request.GetRequestStream();
                stream.Write(bytesArr, 0, bytesArr.Length);
                stream.Close();
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
                object data = js.ReadObject(request.GetResponse().GetResponseStream());
                bool kq = (bool)data;
                if (kq)
                {
                    MessageBox.Show("Đã lưu!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiBang();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool CheckNgoaiLeLuu()
        {
            int trungMa = 0;
            NhanVien[] list = LayDanhSachNV ();
            foreach ( NhanVien n in list )
            {
                if (n.Ma.Equals(tbMa.Text)) trungMa++;
            }
            if (trungMa != 0)
            {
                MessageBox.Show("Nhân viên có mã đã nhập đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                decimal hsluong = decimal.Parse(tbHSLuong.Text);
            } catch
            {
                MessageBox.Show("Hệ số lương là số thập phân dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DateTime ns = dtpNgaySinh.Value.ToUniversalTime();
            if (DateTime.Now.Year - ns.Year < 18)
            {
                MessageBox.Show("Tuổi nhân viên phải >= 18!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nv = dtgNhanVien.CurrentRow.DataBoundItem as NhanVien;
            if (nv != null)
            {
                tbMa .Text = nv.Ma;
                tbHoTen.Text = nv.HoTen;
                dtpNgaySinh.Value = DateTime.Parse(nv.NgaySinh);
                if (nv.GioiTinh.Equals("Nam")) {
                    radNam.Checked = true; radNu.Checked = false; }
                else { radNam.Checked = false; radNu.Checked = true;}
                tbHSLuong.Text = nv.HSLuong.ToString();
                cbMaDV.SelectedValue = nv.MaDonVi;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                string deleteString = string.Format($"?ma={tbMa.Text}");
                HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/nhanvien" + deleteString);
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
                    MessageBox.Show("Đã xóa!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiBang();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gioitinh = (radNam.Checked == true) ? "Nam" : "Nữ";
            string putString = string.Format($"?ma={tbMa.Text}&hoten={tbHoTen.Text}&ngaysinh={dtpNgaySinh.Value}&gioitinh={gioitinh}&hsluong={tbHSLuong.Text}&madonvi={cbMaDV.SelectedValue}");
            HttpWebRequest request = WebRequest.CreateHttp("http://localhost:8090/api/nhanvien" + putString);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] bytesArr = Encoding.UTF8.GetBytes(putString);
            request.ContentLength = bytesArr.Length;
            Stream stream = request.GetRequestStream();
            stream.Write(bytesArr, 0 , bytesArr.Length);
            stream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Đã sửa!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiBang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
