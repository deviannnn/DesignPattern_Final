using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;
using YameStore.Utils;

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

            // set PIN to database
            // sendPIN to account.Gmail
            string PIN = (new Random().Next(999999)).ToString();
            return Gmail.SendPIN(account.Gmail, PIN);
        }

        public static bool Create(Account account)
        {
            // encrypt password
            // after inserted successfully then send new password to gmail
            accountDAO.Insert(account);
            return Gmail.SendPassword(account.Gmail, account.Password);
        }

        public static bool ConfirmPIN()
        {
            // get PIN from database
            // validate PIN from gmail
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
