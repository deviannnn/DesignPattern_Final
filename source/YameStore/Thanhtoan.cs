using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;


namespace YameStore
{
    public partial class Thanhtoan : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        public string manv = "";
        public bool doitramode = false;
        public Doitra reform;

        public Thanhtoan(string manv, Doitra reform)
        {
            InitializeComponent();
            this.manv = manv;
            this.reform = reform;
        }

        private void Thanhtoan_Load(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT HOTEN FROM NHANVIEN WHERE MANV = '" + this.manv + "'", con);
            sqlDataAdapter.Fill(DataTable);

            txt_hotennv.Text = DataTable.Rows[0][0].ToString();
            dateTimePicker1.Value = DateTime.Now;
            panel_Thanhtoantienmat.Visible = false;
            panel_Bankingonline.Visible = false;
            if (this.reform != null)
            {
                this.doitramode = true;
                button3.Visible = false;
                button4.Visible = true;
                txt_voucher.ReadOnly = true;
                txt_mahd.Text = reform.mahd;
                txt_matv.Text = reform.matv;
                txt_matv.ReadOnly = true;
                txt_sdt.ReadOnly = true;
                txt_giamkhachvip.Text = "0";
                btn_refesh.Enabled = false;
                label16.Text = "Tổng GT đổi hàng";
                txt_giamvoucher.Text = reform.tongGT;
            }
            else
            {
                button3.Visible = true;
                button4.Visible = false;
                loadmahd();
            }
        }


        //LOAD DÃY SỐ HOÁ ĐƠN KẾ TIẾP
        private void loadmahd()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT TOP 1 STT FROM HOADON ORDER BY STT DESC", con);
            sqlDataAdapter.Fill(dataTable);

            string date = dateTimePicker1.Value.ToString("ddMMyy");
            string stt = (Int32.Parse(dataTable.Rows[0][0].ToString()) + 1).ToString();
            for (int i = 0; i < 12-stt.Length; i++)
            {
                date += "0";
            }
            date += stt;
            txt_mahd.Text = date;            
        }


        //THAY ĐỔI TEXTBOX NHẬP MÃ THÀNH VIÊN SẼ LOAD TÊN KHÁCH HÀNG VÀ SỐ ĐIỆN THOẠI
        private void txt_matv_TextChanged(object sender, EventArgs e)
        {
            if (txt_matv.Text != "0")
            {
                txt_sdt.ReadOnly = true;

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM KHACHHANG WHERE MATV='" + txt_matv.Text + "'", con);
                sqlDataAdapter1.Fill(dataTable);

                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT HOTEN,SDT,PHANTRAMGIAM FROM KHACHHANG,VITHANHVIEN WHERE KHACHHANG.MATV = VITHANHVIEN.MATV AND KHACHHANG.MATV='" + txt_matv.Text + "'", con);
                    sqlDataAdapter2.Fill(dataTable);
                    txt_hoten.Text = dataTable.Rows[1][1].ToString();
                    txt_sdt.Text = dataTable.Rows[1][2].ToString();
                    txt_giamkhachvip.Text = dataTable.Rows[1][3].ToString();
                }
                else
                {
                    txt_hoten.Text = "Không tồn tại!";
                    txt_giamkhachvip.Text = "0";
                }
            }
            else
            {
                txt_sdt.ReadOnly = false;
                txt_hoten.Text = "Khách Hàng Yame";
            }
        }


        //THAY ĐỔI TEXTBOX NHẬP SỐ ĐIỆN THOẠI SẼ LOAD TÊN KHÁCH HÀNG VÀ MÃ THÀNH VIÊN
        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdt.Text != "")
            {
                txt_matv.ReadOnly = true;
                
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM KHACHHANG WHERE SDT='" + txt_sdt.Text + "'", con);
                sqlDataAdapter1.Fill(dataTable);

                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT KHACHHANG.MATV,HOTEN,PHANTRAMGIAM FROM KHACHHANG,VITHANHVIEN WHERE KHACHHANG.MATV = VITHANHVIEN.MATV AND SDT='" + txt_sdt.Text + "'", con);
                    sqlDataAdapter2.Fill(dataTable);
                    txt_matv.Text = dataTable.Rows[1][1].ToString();
                    txt_hoten.Text = dataTable.Rows[1][2].ToString();
                    float giamkhachvip = float.Parse(dataTable.Rows[1][3].ToString());
                    if (giamkhachvip > 0.10)
                    {
                        txt_giamkhachvip.Text = "0.10";
                    }
                    else
                    {
                        txt_giamkhachvip.Text = giamkhachvip.ToString();
                    }
                }
                else
                {
                    txt_hoten.Text = "Không tồn tại!";
                    txt_giamkhachvip.Text = "0";
                }
            }
            else
            {
                txt_matv.ReadOnly = false;
                txt_hoten.Text = "Khách Hàng Yame";
            }
        }


        //CHỨC NĂNG LOAD TỔNG HOÁ ĐƠN HIỆN TẠI
        private void loadTongHD()
        {
            int tonghoadon = 0;
            for (int i = 0; i < listView_chitiet.Items.Count; i++)
            {
                int soluong = Int32.Parse(listView_chitiet.Items[i].SubItems[3].Text);
                int dongia = Int32.Parse(listView_chitiet.Items[i].SubItems[4].Text);
                tonghoadon += soluong * dongia;
            }
            txt_tonghoadon.Text = tonghoadon.ToString();
            txt_tonghoadonpanel.Text = tonghoadon.ToString(); //Hậu Phùng
            txt_tonghoadonpanelbanking.Text = tonghoadon.ToString(); 
        }


        //CHỨC NĂNG LOAD TỔNG SỐ TIỀN ĐƯỢC GIẢM HIỆN TẠI
        private void loadGiaGiam()
        {
            int tonggiamSP = 0;
            int tonggiamVIP = 0;
            
            for (int i = 0; i < listView_chitiet.Items.Count; i++)
            {
                string mathanhtoan = listView_chitiet.Items[i].SubItems[0].Text;
                string masp = mathanhtoan.Substring(0, 7);
                int soluong = Int32.Parse(listView_chitiet.Items[i].SubItems[3].Text);
                int dongia = Int32.Parse(listView_chitiet.Items[i].SubItems[4].Text);

                DataTable DataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT PHANTRAMGIAM FROM SANPHAM WHERE MASP = '" + masp + "'", con);
                sqlDataAdapter.Fill(DataTable);
                int giagoc = soluong * dongia;

                if (DataTable.Rows[0][0].ToString() != "0")
                {
                    float giamSP = giagoc * float.Parse(DataTable.Rows[0][0].ToString());
                    tonggiamSP += (int)giamSP;
                    continue;
                }

                float giamVIP = giagoc * float.Parse(txt_giamkhachvip.Text);
                tonggiamVIP += (int)giamVIP;
            }
            if (Int32.Parse(txt_tonghoadon.Text) > 100000)
            {
                txt_giamtructiep.Text = (tonggiamSP + tonggiamVIP).ToString();
                txt_giamtructieppanel.Text = (tonggiamSP + tonggiamVIP).ToString(); // Hậu Phùng
                txt_giamtructieppanelbanking.Text = (tonggiamSP + tonggiamVIP).ToString(); // Hậu Phùng
            }
            else
            {
                txt_giamtructiep.Text = tonggiamSP.ToString();
                txt_giamtructieppanel.Text = tonggiamSP.ToString(); //Hậu Phùng
                txt_giamtructieppanelbanking.Text = tonggiamSP.ToString(); //Hậu Phùng
            }
        }


        //CHỨC NĂNG LOAD SỐ TIỀN GIẢM TỪ VOUCHER
        private void loadVoucher()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM VOUCHER WHERE MAHD='" + txt_voucher.Text + "'", con);
            SqlDataAdapter1.Fill(DataTable);
            if (DataTable.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter SqlDataAdapter2 = new SqlDataAdapter("SELECT DONTOITHIEU,TIENGIAMLANSAU FROM VOUCHER WHERE MAHD='" + txt_voucher.Text + "'", con);
                SqlDataAdapter2.Fill(DataTable);
                int tonghoadon = Int32.Parse(txt_tonghoadon.Text);
                int tonggiamtructiep = Int32.Parse(txt_giamtructiep.Text);
                int dontoithieu = Int32.Parse(DataTable.Rows[1][1].ToString());
                if ((tonghoadon - tonggiamtructiep) > dontoithieu)
                {
                    txt_giamvoucher.Text = DataTable.Rows[1][2].ToString();
                    txt_valid.Text = "✓";
                    txt_loadvoucher.Text = "HOÁ ĐƠN ĐỦ ĐIỀU KIỆN ÁP DỤNG VOUCHER";
                }
                else
                {
                    txt_giamvoucher.Text = "0";
                    txt_valid.Text = "X";
                    txt_loadvoucher.Text = "CẦN THÊM " + (dontoithieu - (tonghoadon - tonggiamtructiep)).ToString() + " ĐỂ ÁP DỤNG VOUCHER";
                }
            }
        }


        //CHỨC NĂNG LOAD SỐ TIỀN PHẢI THU HIỆN TẠI
        private void loadThuTien()
        {
            int tonghoadon = int.Parse(txt_tonghoadon.Text);
            int giamtructiep = int.Parse(txt_giamtructiep.Text);
            int giamvoucher = int.Parse(txt_giamvoucher.Text);
            int tienphaithu = tonghoadon - giamtructiep - giamvoucher;
            if (tienphaithu < 0)
            {
                txt_phaithu.Text = "0";
                return;
            }
            decimal num = (decimal)tienphaithu / 1000;
            num = Math.Round(num, MidpointRounding.AwayFromZero);
            num *= 1000;
            txt_phaithu.Text = num.ToString();
            txt_phaithupanel.Text = num.ToString(); //Hậu Phùng
            txt_phaithupanelbanking.Text = num.ToString();

        }


        //CHỨC NĂNG LOAD TỔNG SỐ LƯỢNG SẢN PHẨM HIỆN TẠI
        private void loadTongSP()
        {
            int tongsoluong = 0;
            for (int i = 0; i < listView_chitiet.Items.Count; i++)
            {
                int soluong = Int32.Parse(listView_chitiet.Items[i].SubItems[3].Text);
                tongsoluong += soluong;
            }
            txt_tongsp.Text = tongsoluong.ToString();
        }

        //CẬP NHẬT BẢNG THANH TOÁN KHI CÓ THÊM GIẢM VOUCHER
        private void txt_voucher_TextChanged(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM VOUCHER WHERE MAHD='" + txt_voucher.Text + "'", con);
            SqlDataAdapter1.Fill(DataTable);
            if (DataTable.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter SqlDataAdapter2 = new SqlDataAdapter("SELECT SUDUNG,YEAR(NGAYVOUCHER),MONTH(NGAYVOUCHER),DAY(NGAYVOUCHER),DONTOITHIEU FROM VOUCHER WHERE MAHD='" + txt_voucher.Text + "'", con);
                SqlDataAdapter2.Fill(DataTable);

                DateTime ngayhethan = new DateTime(Int32.Parse(DataTable.Rows[1][0].ToString()), Int32.Parse(DataTable.Rows[1][2].ToString()), Int32.Parse(DataTable.Rows[1][3].ToString()));
                DateTime ngayhomnay = dateTimePicker1.Value.Date;
                int checkhethan = DateTime.Compare(ngayhomnay, ngayhethan);

                if (DataTable.Rows[1][1].ToString() == "True")
                {
                    txt_loadvoucher.Text = "VOUCHER ĐÃ ĐƯỢC SỬ DỤNG";
                }
                else if (checkhethan > 0)
                {
                    txt_loadvoucher.Text = "VOUCHER HẾT THỜI HẠN SỬ DỤNG";
                }
                else
                {
                    txt_voucher.ReadOnly = true;
                    loadVoucher();
                    loadThuTien();
                }
            }
            else
            {
                txt_loadvoucher.Text = "VOUCHER KHÔNG TỒN TẠI";
            }
        }


        //CẬP NHẬT BẢNG THANH TOÁN KHI CÓ THÊM GIẢM THÀNH VIÊN VIP
        private void txt_giamkhachvip_TextChanged(object sender, EventArgs e)
        {
            loadTongHD();
            loadGiaGiam();
            loadVoucher();
            loadThuTien();
        }


        //NÚT THÊM SẢN PHẨM VÀO LIST THANH TOÁN
        private void btn_themsp_Click(object sender, EventArgs e)
        {
            if (txt_mathanhtoan.Text.Length == 10)
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter SqlDataAdapter1 = new SqlDataAdapter("SELECT COUNT(*) FROM SANPHAM_SIZE WHERE MASP = '" + txt_mathanhtoan.Text.Substring(0, 7) + "' AND MASIZE = '" + txt_mathanhtoan.Text.Substring(7) + "'", con);
                SqlDataAdapter1.Fill(dataTable);

                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    SqlDataAdapter SqlDataAdapter2 = new SqlDataAdapter("SELECT TENSP, TENSIZE, DONGIA FROM SANPHAM_SIZE, SANPHAM, SIZE WHERE SANPHAM_SIZE.MASP = SANPHAM.MASP AND SANPHAM_SIZE.MASIZE = SIZE.MASIZE AND SANPHAM_SIZE.MASP = '" + txt_mathanhtoan.Text.Substring(0, 7) + "' AND SANPHAM_SIZE.MASIZE = '" + txt_mathanhtoan.Text.Substring(7) + "'", con);
                    SqlDataAdapter2.Fill(dataTable);

                    string mathanhtoan = txt_mathanhtoan.Text;
                    string tensp = dataTable.Rows[1][1].ToString();
                    string tensize = dataTable.Rows[1][2].ToString();
                    int soluong = Int32.Parse(numUD_soluong.Value.ToString());
                    int dongia = Int32.Parse(dataTable.Rows[1][3].ToString());

                    int giagoc = soluong * dongia;

                    ListViewItem item = new ListViewItem();
                    item.Text = mathanhtoan;
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tensp });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = tensize });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = soluong.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dongia.ToString() });
                    listView_chitiet.Items.Add(item);

                    txt_mathanhtoan.Text = "";
                    numUD_soluong.Value = 1;
                    loadTongSP();
                    loadTongHD();
                    loadGiaGiam();
                    loadVoucher();
                    loadThuTien();
                }
                else
                {
                    MessageBox.Show("Mã thanh toán không tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Mã thanh toán không hợp lệ!");
            }
        }


        //NÚT XOÁ SẢN PHẨM KHỎI LIST THANH TOÁN
        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            if (listView_chitiet.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chưa chọn sản phẩm cần xoá!");
                return;
            }
            else
            {
                int count = listView_chitiet.SelectedItems.Count;
                for (int i = 0; i < count; i++)
                {
                    listView_chitiet.Items.Remove(listView_chitiet.SelectedItems[0]);
                }
                loadTongSP();
                loadTongHD();
                loadGiaGiam();
                loadVoucher();
                loadThuTien();
                return;
            }
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ INSERT DỮ LIỆU MỚI VÀO BẢNG HOADON
        private void insertHOADON()
        {
            con.Open();
            string insertHOADON = @"INSERT INTO dbo.HOADON (MAHD,MANV,MATV) VALUES ('" + txt_mahd.Text + "','" + this.manv + "','" + txt_matv.Text + "')";
            SqlCommand cmd = new SqlCommand(insertHOADON, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ INSERT DỮ LIỆU MỚI VÀO BẢNG CTHD
        private void insertCTHD()
        {
            con.Open();
            string mahd = txt_mahd.Text;
            for (int i = 0; i < listView_chitiet.Items.Count; i++)
            {
                string mathanhtoan = listView_chitiet.Items[i].SubItems[0].Text;
                string masp = mathanhtoan.Substring(0, 7);
                string masize = mathanhtoan.Substring(7);
                int soluong = Int32.Parse(listView_chitiet.Items[i].SubItems[3].Text);
                int dongia = Int32.Parse(listView_chitiet.Items[i].SubItems[4].Text);

                DataTable DataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT PHANTRAMGIAM FROM SANPHAM WHERE MASP = '" + masp + "'", con);
                sqlDataAdapter.Fill(DataTable);

                float phantramgiam = float.Parse(txt_giamkhachvip.Text);
                if (DataTable.Rows[0][0].ToString() != "0")
                {
                    phantramgiam = float.Parse(DataTable.Rows[0][0].ToString());
                }

                float thanhtien = (soluong * dongia) * (1 - phantramgiam);

                string insertCTHD = @"INSERT INTO dbo.CTHD (MAHD,MASP,MASIZE,SOLUONG,DONGIA,PHANTRAMGIAM,THANHTIEN) VALUES ('" + mahd + "','" + masp + "','" + masize + "'," + soluong.ToString() + "," + dongia.ToString() + "," + phantramgiam.ToString() + "," + thanhtien.ToString() + ")";
                SqlCommand cmd = new SqlCommand(insertCTHD, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ INSERT DỮ LIỆU MỚI VÀO BẢNG BANGTHANHTOAN
        private void insertBANGTHANHTOAN()
        {
            con.Open();
            string insertBANGTHANHTOAN = @"INSERT INTO dbo.BANGTHANHTOAN (MAHD,TONGHOADON,GIAMTRUCTIEP,GIAMVOUCHER,TIENPHAITHU) VALUES ('" + txt_mahd.Text + "'," + txt_tonghoadon.Text + "," + txt_giamtructiep.Text + "," + txt_giamvoucher.Text + "," + txt_phaithu.Text + ")";
            SqlCommand cmd = new SqlCommand(insertBANGTHANHTOAN, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ INSERT DỮ LIỆU MỚI VÀO BẢNG VOUCHER
        private void insertVOUCHER()
        {
            con.Open();

            decimal dontoithieu = decimal.Parse(txt_phaithu.Text) / 2000;
            dontoithieu = Math.Round(dontoithieu, MidpointRounding.AwayFromZero);
            dontoithieu *= 1000;

            decimal tiengiamlansau = dontoithieu / 10;

            string insertVOUCHER = @"INSERT INTO dbo.VOUCHER (MAHD,DONTOITHIEU,TIENGIAMLANSAU) VALUES ('" + txt_mahd.Text + "'," + dontoithieu.ToString() + "," + tiengiamlansau.ToString() + ")";
            SqlCommand cmd = new SqlCommand(insertVOUCHER, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ UPDATE LẦN SỬ DỤNG BẢNG VOUCHER NẾU CÓ ÁP DỤNG VOUCHER
        private void updateVOUCHER()
        {
            if (txt_valid.Text == "✓")
            {
                con.Open();
                string updateVOUCHER = @"UPDATE dbo.VOUCHER SET SUDUNG = 1 WHERE MAHD ='" + txt_voucher.Text + "'";
                SqlCommand cmd = new SqlCommand(updateVOUCHER, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ UPDATE TIỀN TÍCH LUỸ BẢNG TRONG THANHVIEN
        private void updateVITHANHVIEN()
        {
            if (txt_matv.Text != "0")
            {
                con.Open();
                string updateVITHANHVIEN = @"UPDATE dbo.VITHANHVIEN SET TONGTIENTICHLUY = TONGTIENTICHLUY + " + txt_phaithu.Text + "WHERE MATV = '" + txt_matv.Text + "'";
                SqlCommand cmd = new SqlCommand(updateVITHANHVIEN, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        //THỰC HIỆN CÂU LỆNH SQL ĐỂ UPDATE SỐ LƯỢNG ĐỔI TRẢ TRONG BẢNG CTHD
        private void updateCTHD()
        {
            string[,] Array = reform.getSPdoi();
            con.Open();
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                string masp = Array[i,0];
                string masize = Array[i, 1];
                string soluongdoi = Array[i, 2];
                
                string updateCTHD = @"UPDATE dbo.CTHD SET SOLUONGDOI = " + soluongdoi + " WHERE MAHD = '" + txt_mahd.Text + "' AND MASP = '" + masp + "' AND MASIZE = '" + masize + "'";
                SqlCommand cmd = new SqlCommand(updateCTHD, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void updateVOUCHER_money()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT SUDUNG FROM VOUCHER WHERE MAHD='" + txt_mahd.Text + "'", con);
            SqlDataAdapter.Fill(DataTable);
            if (DataTable.Rows[0][0].ToString() == "False")
            {
                decimal dontoithieu = decimal.Parse(txt_phaithu.Text) / 2000;
                dontoithieu = Math.Round(dontoithieu, MidpointRounding.AwayFromZero);
                dontoithieu *= 1000;
                decimal tiengiamlansau = dontoithieu / 10;

                con.Open();
                string updateVOUCHER_money = @"UPDATE dbo.VOUCHER SET DONTOITHIEU = DONTOITHIEU + " + dontoithieu.ToString() + ", TIENGIAMLANSAU = TIENGIAMLANSAU + " + tiengiamlansau.ToString() + " WHERE MAHD = '" + txt_mahd.Text + "'";
                SqlCommand cmd = new SqlCommand(updateVOUCHER_money, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //REFESH
        private void btn_refesh_Click(object sender, EventArgs e)
        {
            new Thanhtoan(this.manv, null).Show();
            this.Close();
        }

        private void loadTiendu()//Hậu Phùng
        {
            txt_khachdua.Focus();
            long n;
            if (long.TryParse(txt_khachdua.Text, out n))
            {
                int tienphaithu = int.Parse(txt_phaithu.Text);
                int tienkhachdua = int.Parse(txt_khachdua.Text)*1000;
                int tiendu = tienkhachdua - tienphaithu;
                if (tiendu < 0)
                {
                    txt_tienthua.Text = "0";
                }
                else
                {
                    txt_tienthua.Text = tiendu.ToString();
                }
            }
        }
        private void txt_khachdua_TextChanged(object sender, EventArgs e)  //Hậu Phùng
        {
            loadTiendu();
        }

        //THANH TOÁN TỔNG KẾT BILL
        private void btn_thanhtoan_Click(object sender, EventArgs e) // Hậu Phùng
        {
            if (txt_tongsp.Text != "0" && cbb_loaithanhtoan.Text == "Tiền mặt")
            {
                panel_Thanhtoantienmat.Visible = true;
            }
            else if (txt_tongsp.Text != "0" && cbb_loaithanhtoan.Text == "ATM")
            {
                panel_Bankingonline.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm để thanh toán!");
            }
        }

        private void btn_hoantatthanhtoantienmat_Click(object sender, EventArgs e) //Hậu Phùng
        {
            if(txt_khachdua.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thanh toán !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if(Int32.Parse(txt_phaithu.Text) <= Int32.Parse(txt_khachdua.Text)*1000 && !doitramode)
            {
				Inhoadon();
                insertHOADON();
                insertCTHD();
                insertBANGTHANHTOAN();
                insertVOUCHER();
                updateVOUCHER();
                updateVITHANHVIEN();
                MessageBox.Show("Thanh toán hoàn tất");
                new Thanhtoan(this.manv, null).Show();
                this.Close();
            }
            else if (Int32.Parse(txt_phaithu.Text) <= Int32.Parse(txt_khachdua.Text)*1000 && doitramode)
            {
				Inhoadon();
                updateCTHD();
                insertCTHD();
                insertBANGTHANHTOAN();
                updateVOUCHER_money();
                updateVITHANHVIEN();
                MessageBox.Show("Thanh toán hoàn tất");
                new Thanhtoan(this.manv, null).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Số tiền không đủ để thực hiện thanh toán !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Hoantatbanking_Click(object sender, EventArgs e)    //Hậu Phùng
        {
            DataTable dataTablebanking = new DataTable();
            SqlDataAdapter sqlDataAdapterbanking = new SqlDataAdapter("SELECT COUNT(*) FROM CARD WHERE MASOTHE='" + txt_sotaikhoan.Text + "' AND HOTEN=N'" + txt_tentaikhoan.Text + "' AND MATKHAU= '" + txt_matkhau.Text + "'", con);
            sqlDataAdapterbanking.Fill(dataTablebanking);

            if (dataTablebanking.Rows[0][0].ToString() == "1")
            {
                DataTable dataTablebanking1 = new DataTable();
                SqlDataAdapter sqlDataAdapterbanking1 = new SqlDataAdapter("SELECT * FROM CARD WHERE MASOTHE='" + txt_sotaikhoan.Text + "'", con);
                sqlDataAdapterbanking1.Fill(dataTablebanking1);

                if(long.Parse(dataTablebanking1.Rows[0][3].ToString()) < Int32.Parse(txt_phaithu.Text))
                {
                    MessageBox.Show("Số dư không đủ để thực hiện thanh toán !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                con.Open();
                string updateSODU = @"UPDATE dbo.CARD SET SODU = SODU - " + txt_phaithu.Text + "WHERE MASOTHE = '" + txt_sotaikhoan.Text + "'";
                SqlCommand cmdbanking = new SqlCommand(updateSODU, con);
                cmdbanking.ExecuteNonQuery();
                con.Close();

                if (!doitramode)
                {
                    Inhoadon();
                    insertHOADON();
                    insertCTHD();
                    insertBANGTHANHTOAN();
                    insertVOUCHER();
                    updateVOUCHER();
                    updateVITHANHVIEN();
                }
                else
                {
                    Inhoadon();
                    updateCTHD();
                    insertCTHD();
                    insertBANGTHANHTOAN();
                    updateVOUCHER_money();
                    updateVITHANHVIEN();
                }    
                
                MessageBox.Show("Thanh toán hoàn tất");
                new Thanhtoan(this.manv, null).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        //THOÁT CHỨC NĂNG THANH TOÁN
        private void button3_Click(object sender, EventArgs e)
        {
            new Frm_Nhanvien(this.manv).Show();
            this.Close();
        }


        //TRỞ VỀ FORM ĐỔI TRẢ
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.reform.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            panel_Bankingonline.Visible = false;
            txt_sotaikhoan.Text = "";
            txt_tentaikhoan.Text = "";
            txt_matkhau.Text = "";
        }

        private void label33_Click(object sender, EventArgs e)
        {
            panel_Thanhtoantienmat.Visible = false;
            txt_khachdua.Text = "";
        }
		private void Inhoadon()
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            exSheet.Range["A:A"].ColumnWidth = 13.50;
            exSheet.Range["B:B"].ColumnWidth = 25;
            exSheet.Range["F:F"].ColumnWidth = 9.50;



            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 2]; 
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "                               CỬA HÀNG THỜI TRANG YAME";

            Excel.Range dc = (Excel.Range)exSheet.Cells[2, 1];
            dc.Value = "(028)7307 1441";
            dc.Font.Size = 13;
            dc.Font.Bold = true;
            dc.Font.Color = Color.Black;

            Excel.Range dc1 = (Excel.Range)exSheet.Cells[2, 5];
            dc1.Value = "www.YaMe.vn";
            dc1.Font.Size = 13;
            dc1.Font.Bold = true;
            dc1.Font.Color = Color.Black;

            //In chữ Hóa đơn bán
            exSheet.Range["C4"].Font.Size = 20;
            exSheet.Range["C4"].Font.Bold = true;
            exSheet.Range["C4"].Font.Color = Color.Red;
            exSheet.Range["C4"].Value = "                        HÓA ĐƠN BÁN HÀNG";

            //In các thông tin chung
            exSheet.Range["A5:A8"].Font.Size = 12;
            exSheet.Range["A5"].Value = "#     " + txt_mahd.Text;
            exSheet.Range["A6"].Value = "Ngày:";
            exSheet.Range["B6"].Value = "'" + dateTimePicker1.Text;
            exSheet.Range["A7"].Value = "Thu ngân:";
            exSheet.Range["B7"].Value = txt_hotennv.Text;
            exSheet.Range["A8"].Value = "Khách hàng VIP:";
            exSheet.Range["B8"].Value = txt_hoten.Text;

            //In dòng tiêu đề
            exSheet.Range["A10:F10"].Font.Size = 12;
            exSheet.Range["A10:F10"].Font.Bold = true;
            exSheet.Range["A10"].Value = "Mã thanh toán";
            exSheet.Range["B10"].Value = "Sản phẩm";
            exSheet.Range["C10"].Value = "Số lượng";
            exSheet.Range["D10"].Value = "Đơn giá";
            exSheet.Range["E10"].Value = "Giảm %";
            exSheet.Range["F10"].Value = "Thành Tiền";

            //In danh sách sản phẩm
            int dong = 11;
            for (int i = 0; i < listView_chitiet.Items.Count; i++)
            {
                string mathanhtoan = listView_chitiet.Items[i].SubItems[0].Text;
                string masp = mathanhtoan.Substring(0, 7);
                int soluong = Int32.Parse(listView_chitiet.Items[i].SubItems[3].Text);
                int dongia = Int32.Parse(listView_chitiet.Items[i].SubItems[4].Text);

                DataTable DataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT PHANTRAMGIAM FROM SANPHAM WHERE MASP = '" + masp + "'", con);
                sqlDataAdapter.Fill(DataTable);

                float phantramgiam = float.Parse(txt_giamkhachvip.Text);
                if (Int32.Parse(txt_tonghoadon.Text) < 100000)
                {
                    phantramgiam = 0;
                }
                if (DataTable.Rows[0][0].ToString() != "0")
                {
                    phantramgiam = float.Parse(DataTable.Rows[0][0].ToString());
                }
                

                float thanhtien = (soluong * dongia) * (1 - phantramgiam);

                exSheet.Range["A" + (dong + i).ToString()].Value = "'"+mathanhtoan;
                exSheet.Range["B" + (dong + i).ToString()].Value = listView_chitiet.Items[i].SubItems[1].Text;
                exSheet.Range["C" + (dong + i).ToString()].Value = "'" + soluong.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = "'" + dongia.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = (phantramgiam*100).ToString() + "%";
                exSheet.Range["F" + (dong + i).ToString()].Value = thanhtien.ToString();
            }
            dong = dong + listView_chitiet.Items.Count + 1;
            exSheet.Range["D" + dong.ToString()].Value = "Tổng giá gốc:";
            exSheet.Range["F" + dong.ToString()].Value = txt_tonghoadon.Text;
            dong = dong + 1;

            exSheet.Range["D" + dong.ToString()].Value = "Giảm trực tiếp:";
            exSheet.Range["F" + dong.ToString()].Value = txt_giamtructiep.Text;
            dong = dong + 1;

            exSheet.Range["D" + dong.ToString()].Value = "Giảm Voucher:";
            exSheet.Range["F" + dong.ToString()].Value = txt_giamvoucher.Text;
            dong = dong + 1;
            
            exSheet.Range["D" + dong.ToString()].Value = "Phải thu (VND):";
            exSheet.Range["F" + dong.ToString()].Value = txt_phaithu.Text;
            dong = dong + 1;

            decimal dontoithieu = decimal.Parse(txt_phaithu.Text) / 2000;
            dontoithieu = Math.Round(dontoithieu, MidpointRounding.AwayFromZero);
            dontoithieu *= 1000;
            decimal tiengiamlansau = dontoithieu / 10;

            
            exSheet.Range["A" + dong.ToString()].Value = "'-----------------------------------------------------------------------------------------";
            dong = dong + 1;
            exSheet.Range["B" + dong.ToString()].Value = "                           MÃ GIẢM GIÁ HÓA ĐƠN TIẾP THEO";
            exSheet.Range["B" + dong.ToString()].Font.Bold = true;
            exSheet.Range["B" + dong.ToString()].Font.Size = 15;
            exSheet.Range[exSheet.Cells[dong, 1], exSheet.Cells[dong, 6]].Merge();
            dong = dong + 1;
            exSheet.Range["B" + dong.ToString()].Value = "'                                          " + txt_mahd.Text;
            exSheet.Range["B" + dong.ToString()].Font.Size = 15;
            exSheet.Range[exSheet.Cells[dong, 1], exSheet.Cells[dong, 6]].Merge();
            dong = dong + 2;
            exSheet.Range["A" + dong.ToString()].Value = "Vocher:     " + tiengiamlansau;

            DateTime hanVoucher = dateTimePicker1.Value.AddMonths(1);
            exSheet.Range["C" + dong.ToString()].Value = "Hiệu lực đến:     " + hanVoucher.ToString("dd/MM/yyyy");
            exSheet.Range[exSheet.Cells[dong, 3], exSheet.Cells[dong, 4]].Merge();
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = " * Giá trị HĐ tiếp theo tối thiểu:  " + dontoithieu;
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "   [Sau khi trừ khuyên mãi, giảm giá]";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = " * Không áp dụng trong ngày xuất Voucher.";

            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "'-----------------------------------------------------------------------------------------";
            dong = dong + 1;
            exSheet.Range["B" + dong.ToString()].Value = "                                                  YOU ARE MY EVERYTHING";
            exSheet.Range["B" + dong.ToString()].Font.Bold = true;
            exSheet.Range[exSheet.Cells[dong, 1], exSheet.Cells[dong, 6]].Merge();
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "Đổi hàng: 7 ngày (9:00 - 22:00)";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Phải còn hóa đơn, không hoàn lại tiền.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Hàng còn nguyên tem, chưa qua sử dụng.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Chỉ đổi sản phẩm giá cao hơn hoặc bằng.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Sản phẩm Giày/Dép/Sandal/Quần jean đổi mới";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "trong vòng 30 ngày nếu sản phẩm bị lỗi.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Sản phẩm sale chỉ hỗ trợ đổi Size.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "                                  ";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "Bảo hành: 365 ngày.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "- Hỗ trợ sửa chữa sản phẩm khi hết hạn bảo hành.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "**Không giặt chung với sản phẩm khác màu.";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "Góp ý:";
            exSheet.Range["B" + dong.ToString()].Value = "http://yame.vn/thanphien";
            dong = dong + 1;
            exSheet.Range["B" + dong.ToString()].Value = "090909 1441";
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "'-------------------------------------------------------------------------------------------";
            dong = dong + 1;
            exSheet.Range["B" + dong.ToString()].Value = "                                                Quý khách cần hóa đơn tài chính.";
            exSheet.Range[exSheet.Cells[dong, 1], exSheet.Cells[dong, 6]].Merge();
            dong = dong + 1;
            exSheet.Range["A" + dong.ToString()].Value = "                                            Vui lòng cung cấp thông tin trong ngày.";
            exSheet.Range[exSheet.Cells[dong, 1], exSheet.Cells[dong, 6]].Merge();

            exSheet.Name = txt_mahd.Text;
            exBook.Activate();

            //Merge cột lại 
            exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, 6]].Merge();
            exSheet.Range[exSheet.Cells[2, 1], exSheet.Cells[2, 2]].Merge();
            exSheet.Range[exSheet.Cells[2, 5], exSheet.Cells[2, 6]].Merge();
            exSheet.Range[exSheet.Cells[4, 1], exSheet.Cells[4, 6]].Merge();
            exSheet.Range[exSheet.Cells[5, 1], exSheet.Cells[5, 2]].Merge();
            exSheet.Range[exSheet.Cells[6, 2], exSheet.Cells[6, 3]].Merge();
            exSheet.Range[exSheet.Cells[7, 2], exSheet.Cells[7, 3]].Merge();
            exSheet.Range[exSheet.Cells[8, 2], exSheet.Cells[8, 3]].Merge();

            //Lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 2012 of highter(.xlsx) | *.xlsx";
            save.FilterIndex = 2;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName);
            }
            exApp.Quit();
        }

        private void txt_panel_khachdua_keypress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
