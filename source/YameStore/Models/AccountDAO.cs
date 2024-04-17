using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameDatabase;

namespace YameStore.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string YameID { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public string Role { get; set; }
        public Account() { }
    }

    public class AccountDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public AccountDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool InsertAccount(Account account)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO ACCOUNT (GMAIL, PHONE, PASSWORD, NAME, GENDER, ADDRESS, ROLE) 
                                VALUES (@Gmail, @Phone, @Password, @Name, @Gender, @Address, @Role)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    
                    // Thêm tham số
                    /*cmd.Parameters.Add(databaseFactory.CreateParameter("@YameID", account.YameID.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Gmail", account.Gmail.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Phone", account.Phone.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Password", account.Password.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Name", account.Name.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Gender", account.Gender));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Address", account.Address.Trim()));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Locked", account.Locked));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Active", account.Active));
                    cmd.Parameters.Add(databaseFactory.CreateParameter("@Role", account.Role.Trim()));
                    databaseFactory.AddParameterWithValue(cmd, "@YameID", account.YameID.Trim());*/
                    databaseFactory.AddParameterWithValue(cmd, "@Gmail", account.Gmail.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", account.Phone.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Password", account.Password.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Name", account.Name.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Gender", account.Gender);
                    databaseFactory.AddParameterWithValue(cmd, "@Address", account.Address.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Locked", account.Locked);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", account.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@Role", account.Role.Trim());

                    // Thực hiện lệnh SQL
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
