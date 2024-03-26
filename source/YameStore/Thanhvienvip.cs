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
    public partial class Thanhvienvip : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        public string manv = "";

        public Thanhvienvip(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Thanhvienvip_Load(object sender, EventArgs e)
        {
            loadmatv();
        }

        public void loadmatv()
        {
            DataTable getmatvtb = new DataTable();
            SqlDataAdapter getgetmatv = new SqlDataAdapter("SELECT TOP 1 MATV FROM KHACHHANG ORDER BY MATV DESC", con);
            getgetmatv.Fill(getmatvtb);
            string matv = getmatvtb.Rows[0][0].ToString();
            string stthientai = matv.Substring(6);
            string tongso0 = "";
            int index = 0;
            for (int i = 0; i < stthientai.Length; i++)
            {
                if (stthientai[i] == '0')
                {
                    tongso0 += '0';
                }
                else
                {
                    index = i;
                    break;
                }
            }
            int stt = Int32.Parse(stthientai.Substring(index));
            stt += 1;
            string stttieptheo = stt.ToString();
            if (stthientai.Length - stttieptheo.Length < tongso0.Length)
            {
                stthientai = tongso0.Substring(0, stthientai.Length - stttieptheo.Length) + stttieptheo;
            }
            else
            {
                stthientai = tongso0 + stttieptheo;
            }
            matv = "TVYAME" + stthientai;
            textBox4.Text = matv;
        }

        private bool check_error()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Họ tên!");
                return true;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Frm_Nhanvien(this.manv).Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check_error())
            {
                con.Open();
                string getmatv = textBox4.Text;
                string getsdt = textBox2.Text;
                string gethoten = textBox1.Text;
                string insertKHACHHANG = @"insert into dbo.KHACHHANG (MATV,SDT,HOTEN) values ('" + getmatv + "','" + getsdt + "',N'" + gethoten + "')";
                SqlCommand cmd = new SqlCommand(insertKHACHHANG, con);
                cmd.ExecuteNonQuery();

                
                string insertUser = @"insert into dbo.VITHANHVIEN (MATV,PHANTRAMGIAM,TONGTIENTICHLUY) values ('" + getmatv + "',0,0)";
                SqlCommand cmd1 = new SqlCommand(insertUser, con);
                cmd1.ExecuteNonQuery();


                MessageBox.Show("Đăng ký thành công");
                con.Close();
                new Frm_Nhanvien(this.manv).Show();
                this.Close();
            }
        }
    }
}
