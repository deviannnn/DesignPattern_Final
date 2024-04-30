using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameStore.DAOs;
using YameStore.Models;

namespace YameStore
{
    public class CheckResult
    {
        public bool IsValid { get; set; }
        public string? Msg { get; set; }
        public Account? Account { get; set; }

        public CheckResult(bool isValid, string? msg = null, Account? account = null)
        {
            IsValid = isValid;
            Msg = msg;
            Account = account;
        }

        public CheckResult(bool isValid, Account account)
        {
            IsValid = isValid;
            Account = account;
        }
    }

    public abstract class AccountChecker
    {
        protected AccountChecker? _nextChecker;

        public void SetNextChecker(AccountChecker nextChecker)
        {
            _nextChecker = nextChecker;
        }

        public abstract CheckResult Check(Account account);
    }

    public class AccountAuthChecker : AccountChecker
    {
        public override CheckResult Check(Account loginAccount)
        {
            try
            {
                Account? authAccount = IsValidUsernameAndPassword(loginAccount);
                if (authAccount == null)
                {
                    return new CheckResult(false, "Username or password is incorrect!", authAccount);
                }

                // Nếu tên người dùng và mật khẩu hợp lệ, chuyển yêu cầu đến bước kiểm tra tiếp theo (nếu có)
                return _nextChecker != null ? _nextChecker.Check(authAccount) : new CheckResult(true, authAccount);
            }
            catch (Exception ex)
            {
                return new CheckResult(false, ex.Message, loginAccount);
            }
        }
        private Account? IsValidUsernameAndPassword(Account loginAccount)
        {
            // Kiểm tra tên người dùng và mật khẩu ở đây
            try
            {
                Account? authAccount = new AccountDAO().GetAccountByIdentifier(loginAccount.Username);
                if (authAccount == null)
                    return null;

                if (authAccount.Password != loginAccount.Password)
                    return null;

                return authAccount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class AccountLockedChecker : AccountChecker
    {
        public override CheckResult Check(Account account)
        {
            if (account.Locked)
            {
                // Nếu tài khoản đã bị khóa, không cho phép đăng nhập
                return new CheckResult(false, "Your account has been locked!", account);
            }

            // Nếu tài khoản không bị khóa, chuyển yêu cầu đến bước kiểm tra tiếp theo (nếu có)
            return _nextChecker != null ? _nextChecker.Check(account) : new CheckResult(true, account);
        }
    }

    public class AccountActiveChecker : AccountChecker
    {
        public override CheckResult Check(Account account)
        {
            if (!account.Active)
            {
                // Nếu tài khoản chưa được kích hoạt, chuyển màn hình đổi mật khẩu
                return new CheckResult(true, "Your account has not been activated!", account);
            }

            // Nếu tài khoản đã được kích hoạt, chuyển yêu cầu đến bước kiểm tra tiếp theo (nếu có)
            return _nextChecker != null ? _nextChecker.Check(account) : new CheckResult(true, account);
        }
    }

    public class AccountLoginHandler
    {
        private AccountChecker _checker;

        public AccountLoginHandler()
        {
            // Xây dựng chuỗi kiểm tra với các bước tương ứng
            var authChecker = new AccountAuthChecker();
            var lockedChecker = new AccountLockedChecker();
            var activeChecker = new AccountActiveChecker();

            // Thiết lập mối liên kết giữa các bước kiểm tra
            authChecker.SetNextChecker(lockedChecker);
            lockedChecker.SetNextChecker(activeChecker);

            _checker = authChecker;
        }

        public CheckResult HandleLogin(Account loginAccount)
        {
            // Bắt đầu kiểm tra từ bước đầu tiên trong chuỗi
            return _checker.Check(loginAccount);
        }
    }
}
