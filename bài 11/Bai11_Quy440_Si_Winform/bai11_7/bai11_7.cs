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
using bai11_6;

namespace bai11_7
{
    public partial class bai11_7 : Form
    {
        public bai11_7()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:8087/api/donvi?madv={tbMaDV.Text}");
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DonVi[]));
            object data = js.ReadObject(response.GetResponseStream());
            DonVi[] dv = data as DonVi[];
            dtgDonVi.DataSource = dv;
            dtgDonVi.Columns[0].HeaderText = "Mã đơn vị";
            dtgDonVi.Columns[1].HeaderText = "Tên đơn vị";
        }

        private void tbMaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
