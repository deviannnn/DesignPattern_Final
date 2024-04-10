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
using TextBox = System.Windows.Forms.TextBox;

namespace YameStore.Screen.Inventory
{
    public partial class InventoryForm : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        SqlDataAdapter adapter;
        SqlDataAdapter adapterall;
        DataTable dt;
        DataTable dtall;
        public string manv = "";

        public InventoryForm()
        {
            InitializeComponent();
        }

        private void QL_Kho_Load(object sender, EventArgs e)
        {
            showAll();
            DataGridViewColumn column = tab1_gridview.Columns[2];
            column.Width = 300;      
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            new Frm_Quanli(this.manv).Show();
            this.Close();
        }
//---------- TAB 1 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cleartab1()
        {
            tab1_txt_masp.Text = "";
            showAll();
        }

        public void showData()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT SANPHAM_SIZE.MASP AS 'Mã Sản Phẩm',SANPHAM_SIZE.MASIZE AS 'Mã Size',TENSP AS 'Tên Sản Phẩm',TENSIZE AS 'Size',SOLUONG AS 'Số Lượng',DONGIA AS 'Đơn Giá',PHANTRAMGIAM AS 'Phần Trăm Giảm' FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE AND SANPHAM_SIZE.MASP='" + tab1_txt_masp.Text + "'", con);
            adapter.Fill(dt);
            tab1_gridview.DataSource = dt;
        }

        public void showAll()
        {
            dtall = new DataTable();
            adapterall = new SqlDataAdapter("SELECT SANPHAM_SIZE.MASP AS 'Mã Sản Phẩm',SANPHAM_SIZE.MASIZE AS 'Mã Size',TENSP AS 'Tên Sản Phẩm',TENSIZE AS 'Size',SOLUONG AS 'Số Lượng',DONGIA AS 'Đơn Giá',PHANTRAMGIAM AS 'Phần Trăm Giảm' FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE", con);
            adapterall.Fill(dtall);
            tab1_gridview.DataSource = dtall;
        }

        private void tab1_btn_timkiem_Click(object sender, EventArgs e)
        {
            if (tab1_txt_masp.Text == "")
            {
                return;
            }
            showData();
            
        }

        private void tab1_btn_hientatca_Click(object sender, EventArgs e)
        {
            tab1_txt_masp.Text = "";
            showAll();
        }
//---------- TAB 2 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private bool check_null_tab2()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM WHERE MASP='" + tab2_txt_masp.Text + "'", con);
            SqlDataAdapter.Fill(DataTable);

            if (DataTable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return true;
            }
            else if (tab2_txt_masp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã sản phẩm!");
                return true;
            }
            else if (tab2_txt_tensp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm!");
                return true;
            }
            else if (tab2_txt_dongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Đơn giá của sản phẩm!");
                return true;
            }
            else if (validNumber(tab2_txt_dongia.Text) <= 0)
            {
                MessageBox.Show("Nhập sai giá trị của Đơn giá!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tab2_cbb_loaisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            tab2_labelsoluong.Visible = true;
            tab2_btn_them.Visible = true;
            tab2_label_s1.Visible = true; tab2_num_s1.Visible = true; tab2_num_s1.Value = 0;
            tab2_label_s2.Visible = true; tab2_num_s2.Visible = true; tab2_num_s2.Value = 0;
            tab2_label_s3.Visible = true; tab2_num_s3.Visible = true; tab2_num_s3.Value = 0;
            tab2_label_s4.Visible = true; tab2_num_s4.Visible = true; tab2_num_s4.Value = 0;
            tab2_label_s5.Visible = true; tab2_num_s5.Visible = true; tab2_num_s5.Value = 0;
            switch (tab2_cbb_loaisp.Text)
            {
                case "Loại 1":
                    tab2_label_s1.Text = "S";
                    tab2_label_s2.Text = "M";
                    tab2_label_s3.Text = "L";
                    tab2_label_s4.Text = "XL";
                    tab2_label_s5.Visible = false;
                    tab2_num_s5.Visible = false;
                    break;

                case "Loại 2":
                    tab2_label_s1.Text = "29";
                    tab2_label_s2.Text = "30";
                    tab2_label_s3.Text = "31";
                    tab2_label_s4.Text = "32";
                    tab2_label_s5.Text = "33";
                    break;

                case "Loại 3":
                    tab2_label_s1.Text = "40";
                    tab2_label_s2.Text = "41";
                    tab2_label_s3.Text = "42";
                    tab2_label_s4.Text = "43";
                    tab2_label_s5.Visible = false;
                    tab2_num_s5.Visible = false;
                    break;

                default:
                    tab2_label_s1.Text = "FREE SIZE";
                    tab2_label_s2.Visible = false; tab2_num_s2.Visible = false;
                    tab2_label_s3.Visible = false; tab2_num_s3.Visible = false;
                    tab2_label_s4.Visible = false; tab2_num_s4.Visible = false;
                    tab2_label_s5.Visible = false; tab2_num_s5.Visible = false;
                    break;
            }
        }

        private void cleartab2()
        {
            tab2_txt_masp.Text = "";
            tab2_txt_tensp.Text = "";
            tab2_txt_dongia.Text = "";
            tab2_num_phantramgiam.Value = 0;
            tab2_cbb_loaisp.SelectedIndex = -1;
            tab2_cbb_loaisp.Text = "(Chọn loại sản phẩm)";
            tab2_label_s1.Visible = false; tab2_num_s1.Visible = false; tab2_num_s1.Value = 0;
            tab2_label_s2.Visible = false; tab2_num_s2.Visible = false; tab2_num_s2.Value = 0;
            tab2_label_s3.Visible = false; tab2_num_s3.Visible = false; tab2_num_s3.Value = 0;
            tab2_label_s4.Visible = false; tab2_num_s4.Visible = false; tab2_num_s4.Value = 0;
            tab2_label_s5.Visible = false; tab2_num_s5.Visible = false; tab2_num_s5.Value = 0;
            tab2_labelsoluong.Visible = false;
            tab2_btn_them.Visible = false;
        }
        
        private int validNumber(string a)
        {
            int parsedValue;
            if (!int.TryParse(a, out parsedValue))
            {
                return 0;
            }
            else
            {
                parsedValue = Int32.Parse(a);
                return parsedValue;
            }
        }

        private string[] converseSizetoMasize()
        {
            string[] masizeArray;
            switch (tab2_cbb_loaisp.Text)
            {
                case "Loại 1":
                    masizeArray = new string[4] { "001", "002", "003", "004" };
                    break;

                case "Loại 2":
                    masizeArray = new string[5] { "005", "006", "007", "008", "009" };
                    break;

                case "Loại 3":
                    masizeArray = new string[4] { "010", "011", "012", "013" };
                    break;

                default:
                    masizeArray = new string[1] { "000" };
                    break;
            }
            return masizeArray;
        }

        private string[] getSoluong()
        {
            string[] soluongArray = new string[] { 
                tab2_num_s1.Value.ToString(), 
                tab2_num_s2.Value.ToString(), 
                tab2_num_s3.Value.ToString(), 
                tab2_num_s4.Value.ToString(), 
                tab2_num_s5.Value.ToString() 
            };
            return soluongArray;
        }

        private void tab2_btn_them_Click(object sender, EventArgs e)
        {
            if(!check_null_tab2())
            {
                con.Open();
                string insertSANPHAM = @"INSERT INTO dbo.SANPHAM (MASP,TENSP,DONGIA,PHANTRAMGIAM) VALUES ('" + tab2_txt_masp.Text + "',N'" + tab2_txt_tensp.Text + "'," + (Int32.Parse(tab2_txt_dongia.Text)*1000).ToString() + "," + (tab2_num_phantramgiam.Value/100).ToString() + ")";
                SqlCommand cmd = new SqlCommand(insertSANPHAM, con);
                cmd.ExecuteNonQuery();

                string[] masizeArray = converseSizetoMasize();
                string[] soluongArray = getSoluong();
                for (int i = 0; i < masizeArray.Length; i++)
                {
                    string insertSANPHAM_SIZE = @"INSERT INTO dbo.SANPHAM_SIZE (MASP,MASIZE,SOLUONG) VALUES ('" + tab2_txt_masp.Text + "','" + masizeArray[i] + "'," + soluongArray[i] + ")";
                    SqlCommand cmd1 = new SqlCommand(insertSANPHAM_SIZE, con);
                    cmd1.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Thêm sản phẩm thành công");
                cleartab2();
            }
        }
//---------- TAB 3 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void showDataTab3()
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT SANPHAM_SIZE.MASP AS 'Mã Sản Phẩm',SANPHAM_SIZE.MASIZE AS 'Mã Size',TENSP AS 'Tên Sản Phẩm',TENSIZE AS 'Size',SOLUONG AS 'Số Lượng',DONGIA AS 'Đơn Giá',PHANTRAMGIAM AS 'Phần Trăm Giảm' FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE AND SANPHAM_SIZE.MASP='" + tab3_txt_masp.Text + "'", con);
            adapter.Fill(dt);
            tab3_gridview.DataSource = dt;
        }

        private void cleartab3()
        {
            tab3_txt_masp.Text = "";
        }
        private void Tab3_TextChanged(object sender, EventArgs e)
        {
            DataTable DataTabletab3 = new DataTable();
            SqlDataAdapter SqlDataAdaptertab3 = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM WHERE MASP='" + tab3_txt_masp.Text + "'", con);
            SqlDataAdaptertab3.Fill(DataTabletab3);
            if(DataTabletab3.Rows[0][0].ToString() == "1")
            {
                showDataTab3();
            }
            else
            {
                tab3_gridview.DataSource = null;
            }
        }
        private void tab3_btn_xoa_Click(object sender, EventArgs e)  
        {
            DataTable DataTabletab3xoa = new DataTable();
            SqlDataAdapter SqlDataAdaptertab3xoa = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM WHERE MASP='" + tab3_txt_masp.Text + "'", con);
            SqlDataAdaptertab3xoa.Fill(DataTabletab3xoa);
            if (DataTabletab3xoa.Rows[0][0].ToString() == "1")    //Thiếu hàm xóa trong database
            {
                //Thiếu hàm xóa trong database
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM dbo.SANPHAM_SIZE WHERE MASP = '" + tab3_txt_masp.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Xóa sản phẩm thành công !");
                tab3_gridview.DataSource=null;
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại !");
            }
        }
        //---------- TAB 4 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cleartab4()
        {
            tab4_txt_masp.Text = "";
            tab4_txt_tensp.Text = "";
            tab3_gridview.DataSource = null;
        }

        private void tab4_txt_masp_TextChanged(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM_SIZE WHERE MASP='" + tab4_txt_masp.Text + "'", con);
            SqlDataAdapter.Fill(DataTable);

            if (DataTable.Rows[0][0].ToString() != "0")
            {
                tab4_btn_nhap.Visible = true;
                tab4_btn_xuat.Visible = true;
                tab4_labelsoluong.Visible = true;
                tab4_labelconlai.Visible = true;
                tab4_label_s1.Visible = true; tab4_num_s1.Visible = true; tab4_num_s1.Value = 0;
                tab4_label_s2.Visible = true; tab4_num_s2.Visible = true; tab4_num_s2.Value = 0;
                tab4_label_s3.Visible = true; tab4_num_s3.Visible = true; tab4_num_s3.Value = 0;
                tab4_label_s4.Visible = true; tab4_num_s4.Visible = true; tab4_num_s4.Value = 0;
                tab4_label_s5.Visible = true; tab4_num_s5.Visible = true; tab4_num_s5.Value = 0;
                tab4_labelconlai_s1.Visible = true; tab4_txt_conlai_s1.Visible = true;
                tab4_labelconlai_s2.Visible = true; tab4_txt_conlai_s2.Visible = true;
                tab4_labelconlai_s3.Visible = true; tab4_txt_conlai_s3.Visible = true;
                tab4_labelconlai_s4.Visible = true; tab4_txt_conlai_s4.Visible = true;
                tab4_labelconlai_s5.Visible = true; tab4_txt_conlai_s5.Visible = true;

                SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter("SELECT TENSP FROM SANPHAM WHERE MASP='" + tab4_txt_masp.Text + "'", con);
                SqlDataAdapter1.Fill(DataTable);
                tab4_txt_tensp.Text = DataTable.Rows[1][1].ToString();

                SqlDataAdapter SqlDataAdapter2 = new SqlDataAdapter("SELECT SUM(CAST(MASIZE AS INT)) FROM SANPHAM_SIZE WHERE MASP = '" + tab4_txt_masp.Text + "' GROUP BY MASP", con);
                SqlDataAdapter2.Fill(DataTable);
                switch (DataTable.Rows[2][0].ToString())
                {
                    case "10":
                        tab4_label_s1.Text = "S"; tab4_labelconlai_s1.Text = "S";
                        tab4_label_s2.Text = "M"; tab4_labelconlai_s2.Text = "M";
                        tab4_label_s3.Text = "L"; tab4_labelconlai_s3.Text = "L";
                        tab4_label_s4.Text = "XL"; tab4_labelconlai_s4.Text = "XL";
                        tab4_label_s5.Visible = false; tab4_labelconlai_s5.Visible = false;
                        tab4_num_s5.Visible = false; tab4_txt_conlai_s5.Visible = false;
                        break;

                    case "35":
                        tab4_label_s1.Text = "29"; tab4_labelconlai_s1.Text = "29";
                        tab4_label_s2.Text = "30"; tab4_labelconlai_s2.Text = "30";
                        tab4_label_s3.Text = "31"; tab4_labelconlai_s3.Text = "31";
                        tab4_label_s4.Text = "32"; tab4_labelconlai_s4.Text = "32";
                        tab4_label_s5.Text = "33"; tab4_labelconlai_s5.Text = "33";
                        break;

                    case "46":
                        tab4_label_s1.Text = "40"; tab4_labelconlai_s1.Text = "40";
                        tab4_label_s2.Text = "41"; tab4_labelconlai_s2.Text = "41";
                        tab4_label_s3.Text = "42"; tab4_labelconlai_s3.Text = "42";
                        tab4_label_s4.Text = "43"; tab4_labelconlai_s4.Text = "43";
                        tab4_label_s5.Visible = false; tab4_labelconlai_s5.Visible = false;
                        tab4_num_s5.Visible = false; tab4_txt_conlai_s5.Visible = false;
                        break;

                    default:
                        tab4_label_s1.Text = "FREE SIZE"; tab4_labelconlai_s1.Text = "FREE SIZE";
                        tab4_label_s2.Visible = false; tab4_num_s2.Visible = false; tab4_labelconlai_s2.Visible = false; tab4_txt_conlai_s2.Visible = false;
                        tab4_label_s3.Visible = false; tab4_num_s3.Visible = false; tab4_labelconlai_s3.Visible = false; tab4_txt_conlai_s3.Visible = false;
                        tab4_label_s4.Visible = false; tab4_num_s4.Visible = false; tab4_labelconlai_s4.Visible = false; tab4_txt_conlai_s4.Visible = false;
                        tab4_label_s5.Visible = false; tab4_num_s5.Visible = false; tab4_labelconlai_s5.Visible = false; tab4_txt_conlai_s5.Visible = false;
                        break;
                }
                SqlDataAdapter SqlDataAdapter3 = new SqlDataAdapter("SELECT SOLUONG FROM SANPHAM_SIZE WHERE MASP='" + tab4_txt_masp.Text + "'", con);
                SqlDataAdapter3.Fill(DataTable);
                TextBox[] temp = new TextBox[] { tab4_txt_conlai_s1, tab4_txt_conlai_s2, tab4_txt_conlai_s3, tab4_txt_conlai_s4, tab4_txt_conlai_s5 };
                for (int i = 0; i < DataTable.Rows.Count - 3; i++)
                {
                    temp[i].Text = DataTable.Rows[i + 3][2].ToString();
                }

            }
            else
            {
                tab4_txt_tensp.Text = "Không tồn tại!";
                tab4_label_s1.Visible = false; tab4_num_s1.Visible = false; tab4_num_s1.Value = 0; tab4_labelconlai_s1.Visible = false; tab4_txt_conlai_s1.Visible = false; tab4_txt_conlai_s1.Text = "0";
                tab4_label_s2.Visible = false; tab4_num_s2.Visible = false; tab4_num_s2.Value = 0; tab4_labelconlai_s2.Visible = false; tab4_txt_conlai_s2.Visible = false; tab4_txt_conlai_s2.Text = "0";
                tab4_label_s3.Visible = false; tab4_num_s3.Visible = false; tab4_num_s3.Value = 0; tab4_labelconlai_s3.Visible = false; tab4_txt_conlai_s3.Visible = false; tab4_txt_conlai_s3.Text = "0";
                tab4_label_s4.Visible = false; tab4_num_s4.Visible = false; tab4_num_s4.Value = 0; tab4_labelconlai_s4.Visible = false; tab4_txt_conlai_s4.Visible = false; tab4_txt_conlai_s4.Text = "0";
                tab4_label_s5.Visible = false; tab4_num_s5.Visible = false; tab4_num_s5.Value = 0; tab4_labelconlai_s5.Visible = false; tab4_txt_conlai_s5.Visible = false; tab4_txt_conlai_s5.Text = "0";
                tab4_labelsoluong.Visible = false;
                tab4_labelconlai.Visible = false;
                tab4_btn_nhap.Visible = false;
                tab4_btn_xuat.Visible = false;
            }
        }

        private string[] converseSizetoMasize_tab4()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter2 = new SqlDataAdapter("SELECT SUM(CAST(MASIZE AS INT)) FROM SANPHAM_SIZE WHERE MASP = '" + tab4_txt_masp.Text + "' GROUP BY MASP", con);
            SqlDataAdapter2.Fill(DataTable);
            string[] masizeArray;
            switch (DataTable.Rows[0][0].ToString())
            {
                case "10":
                    masizeArray = new string[4] { "001", "002", "003", "004" };
                    break;

                case "35":
                    masizeArray = new string[5] { "005", "006", "007", "008", "009" };
                    break;

                case "46":
                    masizeArray = new string[4] { "010", "011", "012", "013" };
                    break;

                default:
                    masizeArray = new string[1] { "000" };
                    break;
            }
            return masizeArray;
        }

        private string[] getSoluong_tab4()
        {
            string[] soluongArray = new string[] {
                tab4_num_s1.Value.ToString(),
                tab4_num_s2.Value.ToString(),
                tab4_num_s3.Value.ToString(),
                tab4_num_s4.Value.ToString(),
                tab4_num_s5.Value.ToString()
            };
            return soluongArray;
        }
        
        private void tab4_btn_nhap_Click(object sender, EventArgs e)
        {
            con.Open();
            string[] masizeArray = converseSizetoMasize_tab4();
            string[] soluongArray = getSoluong_tab4();
            for (int i = 0; i < masizeArray.Length; i++)
            {
                string updateSANPHAM_SIZE = @"UPDATE dbo.SANPHAM_SIZE SET SOLUONG = SOLUONG + " + soluongArray[i] + "WHERE MASP = '" + tab4_txt_masp.Text + "' AND MASIZE = '" + masizeArray[i] + "'";
                SqlCommand cmd = new SqlCommand(updateSANPHAM_SIZE, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Nhập số lượng sản phẩm thành công");
            cleartab4();
        }
        
        private void tab4_btn_xuat_Click(object sender, EventArgs e)
        {
            TextBox[] soluongconlaiArray = new TextBox[] { tab4_txt_conlai_s1, tab4_txt_conlai_s2, tab4_txt_conlai_s3, tab4_txt_conlai_s4, tab4_txt_conlai_s5 };
            NumericUpDown[] soluongxuatArray = new NumericUpDown[] { tab4_num_s1, tab4_num_s2, tab4_num_s3, tab4_num_s4, tab4_num_s5 };
            for (int i = 0; i < soluongxuatArray.Length; i++)
            {
                if (soluongxuatArray[i].Value > Int32.Parse(soluongconlaiArray[i].Text))
                {
                    MessageBox.Show("Số lượng Xuất nhiều hơn số lượng tồn kho!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            con.Open();
            string[] masizeArray = converseSizetoMasize_tab4();
            string[] soluongArray = getSoluong_tab4();
            for (int i = 0; i < masizeArray.Length; i++)
            {
                string updateSANPHAM_SIZE = @"UPDATE dbo.SANPHAM_SIZE SET SOLUONG = SOLUONG - " + soluongArray[i] + "WHERE MASP = '" + tab4_txt_masp.Text + "' AND MASIZE = '" + masizeArray[i] + "'";
                SqlCommand cmd = new SqlCommand(updateSANPHAM_SIZE, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Xuất số lượng sản phẩm thành công");
            cleartab4();
        }
//---------- TAB 5 ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private void cleartab5()
        {
            tab5_txt_masp.Text = "";
            tab5_txt_tensp.Text = "Không tìm thấy sản phẩm !";
            tab5_txt_dongia.Text = "0";
            tab5_cbb_phantram.Text = "0";
        }
        private void txt_masptab5_TextChanged(object sender, EventArgs e)
        {
            DataTable DataTabletab5 = new DataTable();
            SqlDataAdapter SqlDataAdaptertab5 = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM WHERE MASP='" + tab5_txt_masp.Text + "'", con);
            SqlDataAdaptertab5.Fill(DataTabletab5);
            if (DataTabletab5.Rows[0][0].ToString() == "1")
            {
                showDataTab5();
            }
            else
            {
                tab5_txt_tensp.Text = "Không tìm thấy sản phẩm !";
                tab5_txt_dongia.Text = "0";
                tab5_cbb_phantram.Text = "0";
            }
        }

        private void tab5_btn_capnhat_Click(object sender, EventArgs e)
        {
            DataTable DataTabletab5capnhatsaukhixoa1 = new DataTable();
            SqlDataAdapter SqlDataAdaptertab5capnhatsaukhixoa1 = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM_SIZE WHERE MASP='" + tab5_txt_masp.Text + "'", con);
            SqlDataAdaptertab5capnhatsaukhixoa1.Fill(DataTabletab5capnhatsaukhixoa1);
            if (DataTabletab5capnhatsaukhixoa1.Rows[0][0].ToString() != "0")
            {
                if (tab5_txt_tensp.Text != "")
                {
                    float phantramgiamtab5 = float.Parse(tab5_cbb_phantram.Text) / 100;
                    con.Open();
                    string updateSANPHAM = @"UPDATE dbo.SANPHAM SET TENSP = N'" + tab5_txt_tensp.Text.ToString() + "',DONGIA= " + Int32.Parse(tab5_txt_dongia.Text) + ",PHANTRAMGIAM= " + phantramgiamtab5 + "WHERE MASP = '" + tab5_txt_masp.Text + "'";
                    SqlCommand cmd = new SqlCommand(updateSANPHAM, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Cập nhật sản phẩm thành công !");
                    cleartab5();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm !");
            }    
        }

        public void showDataTab5()
        {
            DataTable DataTabletab5capnhatsaukhixoa = new DataTable();
            SqlDataAdapter SqlDataAdaptertab5capnhatsaukhixoa = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM_SIZE WHERE MASP='" + tab5_txt_masp.Text + "'", con);
            SqlDataAdaptertab5capnhatsaukhixoa.Fill(DataTabletab5capnhatsaukhixoa);
            if (DataTabletab5capnhatsaukhixoa.Rows[0][0].ToString() != "0")
            {
                dt = new DataTable();
                adapter = new SqlDataAdapter("SELECT SANPHAM_SIZE.MASP,TENSP,DONGIA,PHANTRAMGIAM FROM SANPHAM_SIZE,SANPHAM,SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE AND SANPHAM_SIZE.MASP='" + tab5_txt_masp.Text + "'", con);
                adapter.Fill(dt);
                tab5_txt_tensp.Text = dt.Rows[0][1].ToString();
                tab5_txt_dongia.Text = dt.Rows[0][2].ToString();
                float hienthiphantram = float.Parse(dt.Rows[0][3].ToString()) * 100;
                tab5_cbb_phantram.Text = hienthiphantram.ToString();
            }
            else
            {
                
            }

            
        }
//---------- Chuyển đổi giữa các tab ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleartab1();
            cleartab2();
            cleartab3();
            cleartab4();
            cleartab5();
        }

//Chặn nhập dữ liệu

        //Chặn người dùng nhập chữ, chỉ được nhập số ô nhập đơn giá
        private void tab5_txt_dongia_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //Chặn người dùng nhập chữ, chỉ được nhập số ô nhập phần trăm giảm
        private void tab5_cbb_phantram_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || (e.KeyChar == '.' && (tab5_cbb_phantram.Text.Length == 0 || tab5_cbb_phantram.Text.IndexOf('.') != -1))))
                e.Handled = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
