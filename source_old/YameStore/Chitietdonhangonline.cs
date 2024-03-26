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
    public partial class Chitietdonhangonline : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adapterCTHD;
        DataTable dtCTHD;
        public string manv = "";
        public string madon = "";
        public Chitietdonhangonline(string manv, string madon)
        {
            InitializeComponent();
            this.manv = manv;
            this.madon = madon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Donhangonline(this.manv).Show();
            this.Close();
        }


        public void showCTHD()
        {
            string sql = "SELECT CONCAT(CT_ONL.MASP,CT_ONL.MASIZE) AS 'Mã Thanh Toán', TENSP AS 'Tên Sản Phẩm', TENSIZE AS 'Size',SOLUONG AS 'Số Lượng', CT_ONL.DONGIA AS 'Đơn Giá', CT_ONL.PHANTRAMGIAM AS 'Phần Trăm Giảm', THANHTIEN AS 'Thành Tiền' FROM CT_ONL, SANPHAM, SIZE WHERE CT_ONL.MASP = SANPHAM.MASP AND CT_ONL.MASIZE = SIZE.MASIZE AND MAONL='" + this.madon + "'";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dtCTHD = new DataTable();
            da.Fill(dtCTHD);
            dataGridView1.DataSource = dtCTHD;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Chitietdonhangonline_Load(object sender, EventArgs e)
        {
            showCTHD();
            showInfo();
        }

        public void showInfo()
        {
            string sql = "SELECT MATV, HOTEN, SDT, DIACHI FROM DONONL WHERE MAONL='" + this.madon + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txt_matv.Text = dt.Rows[0][0].ToString();
                txt_hoten.Text = dt.Rows[0][1].ToString();
                txt_sdt.Text = dt.Rows[0][2].ToString();
                txt_diachi.Text = dt.Rows[0][3].ToString();
            }
        }

        private void txt_matv_TextChanged(object sender, EventArgs e)
        {
            //showInfo();
        }
    }
}
