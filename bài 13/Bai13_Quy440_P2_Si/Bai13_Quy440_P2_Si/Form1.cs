using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13_Quy440_P2_Si
{
    public partial class Form1 : Form
    {
        internal List<SanPham> sp = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiBang();
            cbDanhMuc.DataSource = GetAllDanhMuc();
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.ValueMember = "MaDanhMuc";
        }

        //vùng config hiển thị form
        internal List<SanPham> GetListSanPham()
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:8091/api/")
            };
            var response = client.GetAsync("sanpham").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<SanPham>>().Result;
            }
            return null;
        }
        public void HienThiBang()
        {
            dtgNhanVien.DataSource = GetListSanPham();
            dtgNhanVien.Columns[0].HeaderText = "Mã sản phẩm";
            dtgNhanVien.Columns[1].HeaderText = "Tên sản phẩm";
            dtgNhanVien.Columns[2].HeaderText = "Đơn giá";
            dtgNhanVien.Columns[3].Visible = false;
        }
        internal List<DanhMuc> GetAllDanhMuc()
        {
            HttpClient client = new HttpClient() {
                BaseAddress = new Uri("http://localhost:8091/api/")
            };
            var response = client.GetAsync("danhmuc").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<DanhMuc>>().Result;
            }
            return null;
        }

        //Vùng config các button 

        //Lưu
        internal bool Add(SanPham sp)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:8091/api/")
            };
            var response = client.PostAsJsonAsync("sanpham", sp).Result;
            return response.IsSuccessStatusCode;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckNgoaiLeLuu())
            {
                if (Add(new SanPham() { Ma = tbMaSP.Text, Ten = tbTenSP.Text, DonGia = int.Parse(tbDonGia.Text), MaDanhMuc = (string) cbDanhMuc.SelectedValue })) HienThiBang();
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Sửa
        internal bool Update(SanPham sp)
        {
            HttpClient client = new HttpClient(){
                BaseAddress = new Uri("http://localhost:8091/api/")
            };
            var response = client.PutAsJsonAsync("sanpham", sp).Result;
            return response.IsSuccessStatusCode;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNgoaiLeSua())
            {
                List<SanPham> lsp = GetListSanPham();
                SanPham sp = lsp.FirstOrDefault(x => x.Ma.Equals(tbMaSP.Text));
                if (sp != null)
                {
                    sp.Ma = tbMaSP.Text;
                    sp.Ten = tbTenSP.Text;
                    sp.DonGia = int.Parse(tbDonGia.Text);
                    sp.MaDanhMuc = (string)cbDanhMuc.SelectedValue;
                }
                if (Update(sp)) HienThiBang();
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Xóa
        internal bool Delete(string ma)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:8091/api/")
            };
            var response = client.DeleteAsync($"sanpham?ma={ma}").Result;
            return response.IsSuccessStatusCode;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                if (Delete(tbMaSP.Text)) HienThiBang();
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //vùng check ngoại lệ
        public bool CheckNgoaiLeLuu()
        {
            sp = GetListSanPham();
            SanPham s = sp.FirstOrDefault(x => x.Ma.Equals(tbMaSP.Text));
            if (s != null)
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong danh sách!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                int dongia = int.Parse(tbDonGia.Text);
                if (dongia < 0)
                {
                    MessageBox.Show("Đơn giá là số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } catch
            {
                MessageBox.Show("Đơn giá là số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool CheckNgoaiLeSua()
        {
            try
            {
                int dongia = int.Parse(tbDonGia.Text);
                if (dongia < 0)
                {
                    MessageBox.Show("Đơn giá là số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Đơn giá là số nguyên dương!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SanPham sp = dtgNhanVien.CurrentRow.DataBoundItem as SanPham;
            if (sp != null)
            {
                tbMaSP.Text = sp.Ma;
                tbTenSP.Text = sp.Ten;
                tbDonGia.Text = sp.DonGia.ToString();
                cbDanhMuc.SelectedValue = sp.MaDanhMuc;
            }
        }
    }
}
