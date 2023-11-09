using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoangXuanQuy_2021604440_proj71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void DisplayData()
        {
            dataGridView1.DataSource = data.GetAllTaiKhoan();
            dataGridView1.Columns[0].Width = 190;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 170;
            countAcc.Text = dataGridView1.Rows.Count + "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaiKhoan t = new TaiKhoan();
            t.soTaiKhoan = tbStk.Text;
            t.tenTaiKhoan = tbTtk.Text;
            t.diaChi = tbDc.Text;
            t.dienThoai = tbSdt.Text;
            t.soTien = tbSdt.Text;
            data.AddTaiKhoan(t);
            ClearTextBox();
            DisplayData();
        }
        private void ClearTextBox()
        {
            tbStk.Clear();
            tbTtk.Clear();
            tbDc.Clear();
            tbSdt.Clear();
            tbSt.Clear();
            ActiveControl = tbStk;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            data.DeleteTaiKhoan(tbStk.Text);
            DisplayData();
        }

        private void GetAnAccount(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan t = (TaiKhoan)dataGridView1.CurrentRow.DataBoundItem;
            tbStk.Text = t.soTaiKhoan;
            tbTtk.Text = t.tenTaiKhoan;
            tbDc.Text = t.diaChi;
            tbSdt.Text = t.dienThoai;
            tbSt.Text = t.soTien;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbStk.Clear();
            tbTtk.Clear();
            tbDc.Clear();
            tbSdt.Clear();
            tbSt.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
