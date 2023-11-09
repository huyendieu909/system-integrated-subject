using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoangXuanQuy_2021604440_proj8
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        List<NhanVien> staffs = new List<NhanVien>();
        DataUtil dataUtil = new DataUtil();
        public void LoadData()
        {
            staffs.Clear();
            staffs = dataUtil.ShowStaffs();
            lbCountLuong1000.Text = dataUtil.CountLuong1000(staffs).ToString();
            lbTongLuong1000.Text = dataUtil.TongLuong1000(staffs).ToString();
            dgvCompany.DataSource = staffs;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien staff = new NhanVien
            {
                MaNV = tbMaNV.Text,
                HoTen = tbHoTen.Text,
                Tuoi = Convert.ToInt32(tbTuoi.Text),
                Luong = Convert.ToInt32(tbLuong.Text),
                Xa = tbXa.Text,
                Huyen = tbHuyen.Text,
                Tinh = tbTinh.Text,
                DienThoai = tbDienThoai.Text,
            };
            if (!dataUtil.isExistMaNV(staff.MaNV))
            {
                MessageBox.Show("Đã tồn tại nhân viên có mã trên trong danh sách!");
            }
            else
            {
                dataUtil.AddStaffs(staff);
                ClearAllTextBox();
                LoadData();
            }
        }

        private void dgvCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien staff = dgvCompany.CurrentRow.DataBoundItem as NhanVien;
            tbMaNV.Text = staff.MaNV;
            tbHoTen.Text = staff.HoTen;
            tbTuoi.Text = staff.Tuoi.ToString();
            tbLuong.Text = staff.Luong.ToString();
            tbXa.Text = staff.Xa;
            tbHuyen.Text = staff.Huyen;
            tbTinh.Text = staff.Tinh;
            tbDienThoai.Text = staff.DienThoai;
        }
        public void ClearAllTextBox ()
        {
            tbMaNV.Clear();
            tbHoTen.Clear();
            tbTuoi.Clear();
            tbLuong.Clear();
            tbXa.Clear();
            tbHuyen.Clear();
            tbTinh.Clear();
            tbDienThoai.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dataUtil.DeleteStaff(tbMaNV.Text);
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!dataUtil.isExistMaNV(tbMaNV.Text))
            {
                NhanVien staff = new NhanVien
                {
                    MaNV = tbMaNV.Text,
                    HoTen = tbHoTen.Text,
                    Tuoi = Convert.ToInt32(tbTuoi.Text),
                    Luong = Convert.ToInt32(tbLuong.Text),
                    Xa = tbXa.Text,
                    Huyen = tbHuyen.Text,
                    Tinh = tbTinh.Text,
                    DienThoai = tbDienThoai.Text
                };
                dataUtil.EditStaff(staff);
                LoadData();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvCompany.DataSource = dataUtil.FindByMaNV(tbMaNV.Text);
            lbCountLuong1000.Text = dataUtil.CountLuong1000(dataUtil.FindByMaNV(tbMaNV.Text)).ToString();
            lbTongLuong1000.Text = dataUtil.TongLuong1000(dataUtil.FindByMaNV(tbMaNV.Text)).ToString();
        }

        private void btnClearAllTextBox_Click(object sender, EventArgs e)
        {
            ClearAllTextBox();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lbCountLuong1000_Click(object sender, EventArgs e)
        {

        }

        private void lbTongLuong1000_Click(object sender, EventArgs e)
        {

        }
    }
}
