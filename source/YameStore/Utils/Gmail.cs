using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;

namespace YameStore.Utils
{
    public class Gmail
    {
        private static readonly string HostGmail = "manageryame@gmail.com";
        private static readonly string HostPassword = "vdpnizshdfgzksrq";
        private static readonly SmtpClient Smtp = new SmtpClient("smtp.gmail.com")
        {
            EnableSsl = true,
            Port = 587,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(HostGmail, HostPassword)
        };

        public static bool SendPIN(string gmail, string PIN)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(HostGmail);
            msg.To.Add(gmail);
            msg.Subject = "Reset Password";
            msg.Body = $"Your PIN: {PIN}";

            try
            {
                Smtp.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public static bool SendPassword(string gmail, string password)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(HostGmail);
            msg.To.Add(gmail);
            msg.Subject = "New Password";
            msg.Body = $"Your New Password: {password}";

            try
            {
                Smtp.Send(msg);
                return true;
            }
            catch
            {
                throw new Exception("The gmail system sent unsuccessfully.");
            }
        }
    }
}
