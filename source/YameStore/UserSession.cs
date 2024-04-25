using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.Models;

namespace YameStore
{
    public class UserSession
    {
        private static UserSession? instance;
        private bool isLoggedIn;
        private Account? account;

        private UserSession() { }

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

        public void Login(Account account)
        {
            isLoggedIn = true;
            this.account = account;
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
