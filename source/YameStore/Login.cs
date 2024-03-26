using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;


namespace YameStore
{
    public partial class login : Form
    {
        SqlConnection con = new YameDatabase().getConnection();
        String randomCode,chucvuhientai, next_OTP_from;
        public static String to;
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {
            txt_email_login.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//--------------- ĐĂNG NHẬP -------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // KIỂM TRA THÔNG TIN PANEL ĐĂNG NHẬP
        private bool check_signin()
        {
            if (txt_email_login.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return true;
            }
            else if (txt_pw_login.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return true;
            }
            else
            {
                return false;
            }
        }

        // ĐĂNG NHẬP VÀO HỆ THỐNG KHI NHẤN NÚT ĐĂNG NHẬP
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (!check_signin())
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM USERYAME WHERE TAIKHOAN='" + txt_email_login.Text + "' AND MATKHAU='" + txt_pw_login.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    DataTable dtchucvu = new DataTable();
                    SqlDataAdapter getchucvu = new SqlDataAdapter("select CHUCVU, MANV FROM USERYAME, NHANVIEN WHERE USERYAME.TAIKHOAN = NHANVIEN.TAIKHOAN AND USERYAME.TAIKHOAN ='" + txt_email_login.Text + "'", con);
                    getchucvu.Fill(dtchucvu);
                    string manv = dtchucvu.Rows[0][1].ToString();
                    if (dtchucvu.Rows[0][0].ToString() == "Bán hàng")
                    {
                        this.Hide();
                        new Frm_Nhanvien(manv).Show();
                    }
                    else
                    {
                        this.Hide();
                        new Frm_Quanli(manv).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void openpanel_signin()
        {
            panel_signin.Visible = true;
            btn_signin.BackColor = Color.LightBlue;
        }

        private void closepanel_signin()
        {
            txt_email_login.Text = "";
            txt_pw_login.Text = "";
            panel_signin.Visible = false;
            btn_signin.BackColor = Color.White;
        }

        // CHUYỂN ĐẾN PANEL ĐĂNG NHẬP KHI CLICK VÀO NÚT ĐĂNG NHẬP
        private void btn_signin_Click(object sender, EventArgs e)
        {
            openpanel_signin();
            closepanel_signup();
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//--------------- QUÊN MẬT KHẨU ------------------------------------------------------------------------------------------------------------------------------------------------------

        // KIỂM TRA THÔNG TIN PANEL LẤY LẠI MẬT KHẨU
        private bool check_regain()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM NHANVIEN WHERE TAIKHOAN='" + txt_email_regain.Text + "'", con);
            SqlDataAdapter.Fill(DataTable);
            if (DataTable.Rows[0][0].ToString() == "1")
            {
                return false;
            }
            else if (txt_email_regain.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return true;
            }
            else
            {
                MessageBox.Show("Email không tồn tại!");
                return true;
            }
        }

        // KIỂM TRA THÔNG TIN PANEL ĐẶT LẠI MẬT KHẨU
        private bool check_resetpw()
        {
            if (txt_pw_resetpw.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!");
                return true;
            }
            else if (txt_pw_resetpw.Text.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập đặt Mật khẩu từ 6 kí tự trở lên!");
                return true;
            }
            else if (txt_pw_resetpw.Text != txt_verifypw_resetpw.Text)
            {
                MessageBox.Show("Xác nhận Mật khậu chưa đúng!");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Gửi MÃ OTP KHI ẤN NÚT TIẾP TỤC (TỪ PANEL LẤY LẠI MẬT KHẨU)
        private void btn_next_regain_Click(object sender, EventArgs e)
        {
            if (!check_regain())
            {
                next_OTP_from = "regain";
                panel_regain.Visible = false;
                panel_OTP.Visible = true;
                sendOTP(txt_email_regain.Text);
            }
        }

        private void btn_next_resetpw_Click(object sender, EventArgs e)
        {
            if (!check_resetpw())
            {
                con.Open();
                string resetPW = @"UPDATE dbo.USERYAME SET MATKHAU = '" + txt_pw_resetpw.Text + "' WHERE TAIKHOAN ='" + txt_email_regain.Text + "'";
                SqlCommand cmd = new SqlCommand(resetPW, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lấy lại mật khẩu thành công");
                closepanel_resetpw();
                closepanel_OTP();
                closepanel_regain();
                openpanel_signin();
            }
        }
        
        private void btn_back_resetpw_Click(object sender, EventArgs e)
        {
            panel_regain.Visible = true;
            closepanel_OTP();
            closepanel_resetpw();
        }

        // CHUYỂN ĐẾN PANEL LẤY LẠI MẬT KHẨU KHI CLICK VÀO DÒNG CHỮ QUÊN MẬT KHẨU
        private void label_forgot_Click(object sender, EventArgs e)
        {
            panel_regain.Visible = true;
            closepanel_signin();
        }

        // CHUYỂN ĐẾN PANEL ĐĂNG NHẬP KHI CLICK VÀO NÚT HUỶ (TỪ PANEL LẤY LẠI MẬT KHẨU)
        private void btn_back_regain_Click(object sender, EventArgs e)
        {
            openpanel_signin();
            closepanel_regain();
            closepanel_resetpw();
            closepanel_OTP();
        }

        private void closepanel_regain()
        {
            txt_email_regain.Text = "";
            panel_regain.Visible = false;
        }

        private void closepanel_resetpw()
        {
            txt_pw_resetpw.Text = "";
            txt_verifypw_resetpw.Text = "";
            panel_resetpw.Visible = false;
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//--------------- ĐĂNG KÝ ------------------------------------------------------------------------------------------------------------------------------------------------------------

        // KIỂM TRA THÔNG TIN PANEL ĐĂNG KÝ
        private bool check_signup()
        {
            DataTable DataTable = new DataTable();
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM NHANVIEN WHERE TAIKHOAN='" + txt_email_signup.Text + "'", con);
            SqlDataAdapter.Fill(DataTable);
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (txt_hoten_signup.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Họ tên!");
                return true;
            }
            else if (!rd_ql.Checked && !rd_bh.Checked)
            {
                MessageBox.Show("Vui lòng chọn Chức vụ của bạn!");
                return true;
            }
            else if (txt_email_signup.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return true;
            }
            else if (DataTable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Email đã tồn tại!");
                return true;
            }
            else if(!reg.IsMatch(txt_email_signup.Text))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return true;
            }
            else if (txt_pw_signup.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu!");
                return true;
            }
            else if (txt_pw_signup.Text.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập đặt Mật khẩu từ 6 kí tự trở lên!");
                return true;
            }
            else if (txt_pw_signup.Text != txt_verifypw_signup.Text)
            {
                MessageBox.Show("Xác nhận Mật khậu chưa đúng!");
                return true;
            }
            else
            {
                return false;
            }
        }

        // Gửi MÃ OTP KHI ẤN NÚT TIẾP TỤC (TỪ PANEL ĐĂNG KÝ)
        private void btn_next_signup_Click(object sender, EventArgs e)
        {
            if (!check_signup())
            {
                next_OTP_from = "signup";
                panel_signup.Visible = false;
                panel_OTP.Visible = true;
                sendOTP(txt_email_signup.Text);
            }
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//--------------- OTP ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void sendOTP(string email)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = email;
            from = "manageryame@gmail.com";
            pass = "vdpnizshdfgzksrq";
            if (next_OTP_from == "signup")
            {
                message.Subject = "Đăng Ký Tài Khoản YAME";
                messageBody = "Mã xác nhận để đăng ký tài khoản của bạn là " + randomCode;
            }
            else
            {
                message.Subject = "Đặt Lại Mật Khẩu YAME";
                messageBody = "Mã xác nhận để đặt lại mật khẩu của bạn là " + randomCode;
            }
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Hệ thống đã gửi mã xác nhận về " + email + ", vui lòng kiểm tra trong hộp thư của bạn (bao gồm hộp thư rác)");
                label_resendOTP.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_resendOTP_Click(object sender, EventArgs e)
        {
            label_resendOTP.ForeColor = Color.Red;
            if (next_OTP_from == "signup")
            {
                sendOTP(txt_email_signup.Text);
            }
            else
            {
                sendOTP(txt_email_regain.Text);
            }
        }

        // NÚT TIẾP TỤC Ở PANEL OTP
        private void btn_next_OTP_Click(object sender, EventArgs e)
        {
            // NHẬP OTP KHI ĐĂNG KÝ
            if (randomCode == (txt_OTP.Text).ToString() && next_OTP_from == "signup")
            {
                con.Open();
                string insertUser = @"insert into dbo.USERYAME (TAIKHOAN,MATKHAU) values ('" + txt_email_signup.Text + "','" + txt_pw_signup.Text + "')";
                SqlCommand cmd = new SqlCommand(insertUser, con);
                cmd.ExecuteNonQuery();

                string insertNV = @"insert into dbo.NHANVIEN (MANV,TAIKHOAN,HOTEN,CHUCVU) values ('" + txt_manv_signup.Text + "','" + txt_email_signup.Text + "',N'" + txt_hoten_signup.Text + "',N'" + chucvuhientai + "')";
                SqlCommand cmd1 = new SqlCommand(insertNV, con);
                cmd1.ExecuteNonQuery();


                MessageBox.Show("Đăng ký thành công");
                panel_signin.Visible = true;
                btn_signin.BackColor = Color.LightBlue;
                txt_OTP.Text = "";
                closepanel_signup();
            }
            // NHẬP OTP KHI LẤY LẠI MẬT KHẨU
            else if (randomCode == (txt_OTP.Text).ToString() && next_OTP_from == "regain")
            {
                panel_resetpw.Visible = true;
                closepanel_OTP();
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!");
            }
        }
        private void btn_back_OTP_Click(object sender, EventArgs e)
        {
            if (next_OTP_from == "signup")
            {
                panel_signup.Visible = true;
                closepanel_OTP();
            }
            else
            {
                panel_regain.Visible = true;
                closepanel_OTP();
            }
        }

        private void closepanel_OTP()
        {
            txt_OTP.Text = "";
            panel_OTP.Visible = false;
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//--------------- CÁC HIỂN THỊ Ở PANEL ĐĂNG KÝ ---------------------------------------------------------------------------------------------------------------------------------------

        public void loadmanv(string chucvu)
        {
            DataTable getmatvtb = new DataTable();
            SqlDataAdapter getgetmatv = new SqlDataAdapter("SELECT TOP 1 MANV FROM NHANVIEN WHERE CHUCVU = N'"+chucvu+"' ORDER BY MANV DESC", con);
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

            if (chucvu == "Bán hàng")
            {
                matv = "BHYAME" + stthientai;
                txt_manv_signup.Text = matv;
            }
            else
            {
                matv = "QLYAME" + stthientai;
                txt_manv_signup.Text = matv;
            }
        }

        private void load_signup()
        {
            label_manv.Visible = true;
            txt_manv_signup.Visible = true;
            label_hoten.Visible = true;
            txt_hoten_signup.Visible = true;
            label_email.Visible = true;
            txt_email_signup.Visible = true;
            label_pw.Visible = true;
            txt_pw_signup.Visible = true;
            label_verify.Visible = true;
            txt_verifypw_signup.Visible = true;
            btn_next_signup.Visible = true;
        }

        private void rd_ql_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_ql.Checked)
            {
                loadmanv(rd_ql.Text);
                chucvuhientai = rd_ql.Text;
                load_signup();
            }
        }

        private void rd_bh_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_bh.Checked)
            {
                loadmanv(rd_bh.Text);
                chucvuhientai = rd_bh.Text;
                load_signup();
            }
        }
        private void openpanel_signup()
        {
            panel_signup.Visible = true;
            btn_signup.BackColor = Color.LightBlue;
        }

        private void closepanel_signup()
        {
            label_manv.Visible = false;
            txt_manv_signup.Visible = false;
            txt_manv_signup.Text = "";
            label_hoten.Visible = false;
            txt_hoten_signup.Visible = false;
            txt_hoten_signup.Text = "";
            label_email.Visible = false;
            txt_email_signup.Visible = false;
            txt_email_signup.Text = "";
            label_pw.Visible = false;
            txt_pw_signup.Visible = false;
            txt_pw_signup.Text = "";
            label_verify.Visible = false;
            txt_verifypw_signup.Visible = false;
            txt_verifypw_signup.Text = "";
            btn_next_signup.Visible = false;
            panel_signup.Visible = false;
            btn_signup.BackColor = Color.White;
            rd_ql.Checked = false;
            rd_bh.Checked = false;
        }

        // CHUYỂN ĐẾN PANEL ĐĂNG KÝ KHI CLICK VÀO NÚT ĐĂNG KÝ
        private void btn_signup_Click(object sender, EventArgs e)
        {
            openpanel_signup();
            closepanel_signin();
        }
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_pw_login.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txt_pw_login.PasswordChar = '\0';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_pw_login.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                txt_pw_login.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (txt_pw_login.PasswordChar == '*')
            {
                pictureBox3.BringToFront();
                txt_pw_login.PasswordChar = '\0';
            }
        }
    }
}