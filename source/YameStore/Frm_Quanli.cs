using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YameStore
{
    public partial class Frm_Quanli : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        public string manv = "";

        public Frm_Quanli(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new QL_KHO(this.manv).Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Thongke(this.manv).Show();
            this.Close();
        }

        private void Frm_Quanli_Load(object sender, EventArgs e)
        {
            txt_nameuser.Text = this.manv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Close();
        }
    }
}
