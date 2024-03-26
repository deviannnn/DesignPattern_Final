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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace YameStore
{

    public partial class Tracuu : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adapter;
        SqlDataAdapter adapterall;
        DataTable dt;
        DataTable dtall;
        public string manv = "";
        public Tracuu(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void Tracuu_Load(object sender, EventArgs e)
        {
            showAll();
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 300;
        }

        public void showData()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT TENSP AS 'Tên Sản Phẩm',TENSIZE AS 'Size',SOLUONG AS 'Số Lượng',DONGIA AS 'Đơn Giá',PHANTRAMGIAM AS 'Phần Trăm Giảm' FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE AND SANPHAM_SIZE.MASP='" + txt_masp.Text + "'", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void showAll()
        {
            dtall = new DataTable();
            adapterall = new SqlDataAdapter("SELECT TENSP AS 'Tên Sản Phẩm',TENSIZE AS 'Size',SOLUONG AS 'Số Lượng',DONGIA AS 'Đơn Giá',PHANTRAMGIAM AS 'Phần Trăm Giảm' FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE", con);
            adapterall.Fill(dtall);
            dataGridView1.DataSource = dtall;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text == "")
            {
                return;
            }
            showData();
        }

        private void btn_hientatca_Click(object sender, EventArgs e)
        {
            txt_masp.Text = "";
            showAll();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            new Frm_Nhanvien(this.manv).Show();
            this.Close();
        }
    }
}
