using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public static event EventHandler? SuccessfulLogin;
        public static event EventHandler? ActiveLogin;
        public static bool Authenticate(string identifier, string password)
        {
            AccountLoginHandler handler = new AccountLoginHandler();
            var result = handler.HandleLogin(new Account { Username = identifier, Password = password });

            if (result.IsValid)
            {
                UserSession.Instance.Login(result.Account);
                if (result.Account.Active)
                    SuccessfulLogin?.Invoke(null, EventArgs.Empty);
                else
                    ActiveLogin?.Invoke(null, EventArgs.Empty);

                return true;
            }
            else
            {
                MessageBox.Show(result.Msg, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            try
            {
                bool existingGmail = accountDAO.CheckExistingGmail(account.Gmail);
                bool existingPhone = accountDAO.CheckExistingPhone(account.Phone);

                if (existingGmail)
                {
                    throw new Exception("This Gmail already exists.");
                }

                if (existingPhone)
                {
                    throw new Exception("This phone number already exists.");
                }

                account.Password = PasswordGenerator.GeneratePassword(10);
                if (accountDAO.Insert(account))
                    return Gmail.SendPassword(account.Gmail, account.Password);
                else
                    throw new Exception("The account was inserted unsuccessfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
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
