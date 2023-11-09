using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HoangXuanQuy_2021604440_proj73
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }
        DataUtil dataUtil = new DataUtil();
        List<TaiKhoan> accounts = new List<TaiKhoan>();
        public void LoadData()
        {
            accounts.Clear();
            accounts = dataUtil.ShowAccounts();
            dgvAccounts.DataSource = accounts;
        }
        private void Bai7_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaiKhoan account = new TaiKhoan
            {
                SoTaiKhoan = tbAccountNo.Text,
                TenTaiKhoan = tbAccountName.Text,
                DiaChi = tbAddress.Text,
                DienThoai = tbPhone.Text,
                SoTien = Convert.ToInt32(tbBalance.Text),
            };
            List<TaiKhoan> accounts = dataUtil.ShowAccounts();
            int c = 0;
            accounts.ForEach(a => { if (a.SoTaiKhoan.Equals(account.SoTaiKhoan)) c++; });
            if (c != 0)
            {
                MessageBox.Show("Số tài khoản đã tồn tại trong danh sách!");
            }
            else
            {
                dataUtil.AddAccount(account);
                LoadData();
                ClearAllTextBox();
            }

        }
        private void ClearAllTextBox ()
        {
            tbAccountNo.Clear();
            tbAccountName.Clear();
            tbAddress.Clear();
            tbPhone.Clear();
            tbBalance.Clear();
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TaiKhoan account = (TaiKhoan)dgvAccounts.CurrentRow.DataBoundItem;
            //tbAccountNo.Text = account.SoTaiKhoan;
            //tbAccountName.Text = account.TenTaiKhoan;
            //tbAddress.Text = account.DiaChi;
            //tbPhone.Text = account.DienThoai;
            //tbBalance.Text = account.SoTien.ToString();
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan account = (TaiKhoan)dgvAccounts.CurrentRow.DataBoundItem;
            tbAccountNo.Text = account.SoTaiKhoan;
            tbAccountName.Text = account.TenTaiKhoan;
            tbAddress.Text = account.DiaChi;
            tbPhone.Text = account.DienThoai;
            tbBalance.Text = account.SoTien.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAllTextBox ();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TaiKhoan account = new TaiKhoan
            {
                SoTaiKhoan = tbAccountNo.Text,
                TenTaiKhoan = tbAccountName.Text,
                DiaChi = tbAddress.Text,
                DienThoai = tbPhone.Text,
                SoTien = Convert.ToInt32(tbBalance.Text)
            };
            dataUtil.UpdateAccount(account);
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dataUtil.DeleteAccount(tbAccountNo.Text);
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvAccounts.DataSource = dataUtil.FindAccount(tbAccountNo.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
