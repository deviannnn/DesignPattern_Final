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
    public partial class ThongkeCTHD : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adaptercthd;
        DataTable cthd;
        public string manv = "";
        public string mahd = "";
        public Thongke reform;
        public ThongkeCTHD(string manv,string mahd, Thongke reform)
        {
            InitializeComponent();
            this.manv = manv;
            this.mahd = mahd;
            this.reform = reform;
        }
        public void showCTHD()
        {
            cthd = new DataTable();
            adaptercthd = new SqlDataAdapter("SELECT CTHD.MAHD,HOADON.NGAYLAP,CTHD.MASP,CTHD.MASIZE,CTHD.SOLUONG,CTHD.DONGIA,BANGTHANHTOAN.GIAMTRUCTIEP,BANGTHANHTOAN.GIAMVOUCHER,CTHD.THANHTIEN FROM CTHD,BANGTHANHTOAN,HOADON WHERE HOADON.MAHD=BANGTHANHTOAN.MAHD AND HOADON.MAHD=CTHD.MAHD AND HOADON.MAHD='" + mahd + "'", con);
            adaptercthd.Fill(cthd);
            dataGridView2.DataSource = cthd;
        }

        private void ThongkeCTHD_Load(object sender, EventArgs e)
        {
            showCTHD();
            txt_manv.Text = manv;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.reform.Show();
            this.Close();
        }
    }
}
