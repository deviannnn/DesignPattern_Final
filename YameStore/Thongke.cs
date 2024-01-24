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
    public partial class Thongke : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adapterngay,adapterthang,adaptercthd;
        DataTable dtngay,dtthang,dttbngay,dttbthang,cthd;
        public string manv = "";
        public string mahd = "";
        public Thongke(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Frm_Quanli(this.manv).Show();
            this.Close();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            select_date.Value = DateTime.Now;
            select_month.Text= select_date.Value.ToString("MM");
            txt_manv.Text = manv;
            showDoanhthuTheongay();
            showHoadonTheongay();
        
        }

        public void showHoadonTheongay()
        {
            dttbngay = new DataTable();
            string getngay = select_date.Value.ToString("yyyy/MM/dd");
            adapterngay = new SqlDataAdapter("SELECT BANGTHANHTOAN.MAHD AS 'Mã Hoá Đơn', NGAYLAP AS 'Ngày Lập', HOTEN AS 'Nhân Viên', SUM(BANGTHANHTOAN.TIENPHAITHU) AS 'Tổng Đơn' FROM BANGTHANHTOAN, HOADON, NHANVIEN WHERE BANGTHANHTOAN.MAHD = HOADON.MAHD AND HOADON.MANV = NHANVIEN.MANV AND NGAYLAP = '" + getngay + "' GROUP BY BANGTHANHTOAN.MAHD, NGAYLAP, HOTEN", con);
            adapterngay.Fill(dttbngay);
            dataGridView1.DataSource = dttbngay;
        }
        public void showHoadonTheothang()
        {
            dttbthang = new DataTable();
            string getthang = select_month.Text;
            adapterthang = new SqlDataAdapter("SELECT BANGTHANHTOAN.MAHD AS 'Mã Hoá Đơn', NGAYLAP AS 'Ngày Lập', HOTEN AS 'Nhân Viên', SUM(BANGTHANHTOAN.TIENPHAITHU) AS 'Tổng Đơn' FROM BANGTHANHTOAN, HOADON, NHANVIEN WHERE BANGTHANHTOAN.MAHD = HOADON.MAHD AND HOADON.MANV = NHANVIEN.MANV AND MONTH(NGAYLAP) = '" + getthang + "' GROUP BY BANGTHANHTOAN.MAHD, NGAYLAP, HOTEN", con);
            adapterthang.Fill(dttbthang);
            dataGridView1.DataSource = dttbthang;
        }
        public void showDoanhthuTheongay()
        {
            dtngay = new DataTable();
            string getngay = select_date.Value.ToString("yyyy/MM/dd");
            adapterngay = new SqlDataAdapter("SELECT SUM(TIENPHAITHU) FROM BANGTHANHTOAN,HOADON WHERE HOADON.MAHD=BANGTHANHTOAN.MAHD AND NGAYLAP='" + getngay + "'", con);
            adapterngay.Fill(dtngay);
            txt_Tongdoanhthu.Text = dtngay.Rows[0][0].ToString();
        }
        public void showDoanhthuTheothang()
        {
            dtthang = new DataTable();
            string getthang = select_month.Text;
            adapterthang = new SqlDataAdapter("SELECT SUM(TIENPHAITHU) FROM BANGTHANHTOAN,HOADON WHERE HOADON.MAHD=BANGTHANHTOAN.MAHD AND MONTH(NGAYLAP)='" + getthang + "'", con);
            adapterthang.Fill(dtthang);
            txt_Tongdoanhthu.Text = dtthang.Rows[0][0].ToString();
        }

        private void select_date_ValueChanged(object sender, EventArgs e)
        {
            showDoanhthuTheongay();
            showHoadonTheongay();
        }

        private void select_month_TextChanged(object sender, EventArgs e)
        {
            showDoanhthuTheothang();
            showHoadonTheothang();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.mahd = dataGridView1[0, e.RowIndex].Value.ToString();
            new ThongkeCTHD(this.manv, this.mahd, this).Show();
            this.Hide();
        }

        private void rd_theothang_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_theothang.Checked == true)
            {
                select_date.Enabled = false;
                select_month.Enabled = true;
                showDoanhthuTheothang();
                showHoadonTheothang();
            }
        }

        private void rd_theongay_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_theongay.Checked == true)
            {
                select_date.Enabled = true;
                select_month.Enabled = false;
                showDoanhthuTheongay();
                showHoadonTheongay();
            }
        }
    }
}
