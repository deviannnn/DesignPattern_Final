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
    public partial class Donhangonline : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adapterhoadon;
        DataTable dthoadon;
        public string manv = "";
        public string madon = "";
        public Donhangonline(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Donhangonline_Load(object sender, EventArgs e)
        {
            showHoadon();
        }

        public void showHoadon()
        {
            string sql = "SELECT MAONL AS 'Mã Đơn', HOTEN AS 'Khách Hàng', NGAYDAT AS 'Ngày Đặt', TRANGTHAI AS 'Trạng Thái' FROM DONONL";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dthoadon = new DataTable();
            da.Fill(dthoadon);
            dataGridView1.DataSource = dthoadon;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Chi tiết đơn";
            btn.Text = "Xem";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Frm_Nhanvien(this.manv).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn")
            {    
                this.madon= dataGridView1[0, e.RowIndex].Value.ToString();
                new Chitietdonhangonline(this.manv, this.madon).Show();
                this.Hide();
            }
        }
    }
}
