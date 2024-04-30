using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameDatabase;
using YameStore.Models;

namespace YameStore.DAOs
{
    public class AccountDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public AccountDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Account account)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO ACCOUNT (GMAIL, PHONE, PASSWORD, NAME, GENDER, ADDRESS) VALUES (@Gmail, @Phone, @Password, @Name, @Gender, @Address)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Gmail", account.Gmail.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", account.Phone.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Password", account.Password.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Name", account.Name.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Gender", account.Gender);
                    databaseFactory.AddParameterWithValue(cmd, "@Address", account.Address.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public List<Account> GetAll()
        {
            List<Account> list = new List<Account>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM ACCOUNT WHERE ROLE = 'STAFF'";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var adapter = databaseFactory.CreateDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        list.Add(new Account(table.Rows[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi khi lấy danh sách tài khoản: " + ex.Message);
            }
            return list;
        }

        public Account? GetAccountByIdentifier(string identifier)
        {
            try
            {
                Account? account = null;
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"SELECT * FROM ACCOUNT WHERE YAME_ID = @Identifier OR GMAIL = @Identifier OR PHONE = @Identifier";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@Identifier", identifier);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        account = new Account(reader);
                    }
                }
                return account;
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public bool Update(Account account)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE ACCOUNT 
                                SET GMAIL = @Gmail, PHONE = @Phone, PASSWORD = @Password, 
                                    NAME = @Name, GENDER = @Gender, ADDRESS = @Address, 
                                    LOCKED = @Locked, ACTIVE = @Active, ROLE = @Role 
                                WHERE ID = @Id";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Gmail", account.Gmail.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", account.Phone.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Password", account.Password.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Name", account.Name.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Gender", account.Gender);
                    databaseFactory.AddParameterWithValue(cmd, "@Address", account.Address.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Locked", account.Locked);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", account.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@Role", account.Role.Trim());
                    databaseFactory.AddParameterWithValue(cmd, "@Id", account.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "DELETE FROM ACCOUNT WHERE ID = @Id";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@Id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public bool CheckExistingGmail(string gmail)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT COUNT(*) FROM ACCOUNT WHERE GMAIL = @Gmail";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@Gmail", gmail);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public bool CheckExistingPhone(string phone)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT COUNT(*) FROM ACCOUNT WHERE PHONE = @Phone";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", phone);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }
    }
}
