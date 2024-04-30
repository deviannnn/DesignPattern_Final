using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.Models;

namespace YameStore
{
    public class UserSession
    {
        private bool isLoggedIn;
        private Account? account;
        private static UserSession? instance;
        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSession();
                }
                return instance;
            }
        }

        private UserSession() { }

        public void Login(Account account)
        {
            if (account != null)
            {
                if (account.Active)
                {
                    isLoggedIn = true;
                }
                this.account = account;
            }
        }

        public void Logout()
        {
            isLoggedIn = false;
            account = null;
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
        }

        public Account? Account
        {
            get { return account; }
        }
    }
}
