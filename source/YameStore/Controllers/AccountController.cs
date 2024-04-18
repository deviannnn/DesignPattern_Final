using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore.Controllers
{
    public class AccountController
    {
        private static readonly AccountDAO accountDAO = new();
        public static bool Login(string username, string password)
        {
            /*Account? account = accountDAO.GetAccountByIdentifier(username);
            if (account == null)
                return false;

            // so sanh account.Password va password*/
            return username == "admin" && password == "admin";
        }

        public static bool ResetPassword(string username)
        {
            Account? account = accountDAO.GetAccountByIdentifier(username);
            if (account == null)
                return false;

            // sendPIN to account.Gmail
            return SendPIN(account.Gmail);
        }

        public static bool Create(Account account)
        {
            // encrypt password
            // after inserted successfully then send new password to gmail
            accountDAO.Insert(account);
            return SendNewPassword(account.Gmail);
        }

        private static bool SendNewPassword(string gmail)
        {
            return true;
        }

        private static bool SendPIN(string gmail)
        {
            return true;
        }

        public static bool ConfirmPIN()
        {
            // after confirmed valid PIN from gmail then send new password to gmail
            return true;
        }

        public static List<Account> GetAllStaff()
        {
            return accountDAO.GetAll();
        }

        public static Account? GetProfile(string identifier)
        {
            return accountDAO.GetAccountByIdentifier(identifier);
        }

        public static bool Update(Account account)
        {
            return true;
        }
    }
}
