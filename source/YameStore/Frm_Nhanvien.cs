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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YameStore
{
    public partial class Frm_Nhanvien : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        public string manv = "";
        public Frm_Nhanvien(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Frm_Nhanvien_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.manv;
        }

        public string getName()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT HOTEN FROM NHANVIEN WHERE TAIKHOAN='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thanhtoan(this.manv, null).Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Tracuu(this.manv).Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Doitra(this.manv).Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login frM = new login();
            frM.Show();  //hiển thị form main
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Thanhvienvip(this.manv).Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
