using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class CustomerDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public CustomerDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Customer customer)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO CUSTOMER (CODE, PHONE, NAME) 
                                    VALUES (@YameID, @Phone, @Name)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@YameID", customer.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", customer.Phone);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", customer.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public List<Customer> GetAll()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM CUSTOMER";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var adapter = databaseFactory.CreateDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new Customer(row));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting customer list: " + ex.Message);
            }
            return list;
        }

        public Customer? GetByIdentifier(string identifier)
        {
            try
            {
                Customer? customer = null;
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM CUSTOMER WHERE CODE = @Identifier OR PHONE = @Identifier";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@Identifier", identifier);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        customer = new Customer(reader);
                    }
                }
                return customer;
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE CUSTOMER SET CODE = @Code, PHONE = @Phone, NAME = @Name, ACTIVE = @Active WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Code", customer.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Phone", customer.Phone);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", customer.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", customer.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", customer.ID);

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

                    var cmdText = "DELETE FROM CUSTOMER WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }
    }
}
