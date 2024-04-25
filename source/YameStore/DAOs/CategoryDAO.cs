using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameDatabase;
using YameStore.Models;

namespace YameStore.DAOs
{
    public class CategoryDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public CategoryDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Category category)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO CATEGORY (Name, SizeTypeID, Active) 
                                    VALUES (@Name, @SizeTypeID, @Active)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Name", category.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeTypeID", category.SizeTypeID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", category.Active);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting category: " + ex.Message);
                return false;
            }
        }

        public List<Category> GetAll()
        {
            List<Category> list = new List<Category>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM CATEGORY";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var adapter = databaseFactory.CreateDataAdapter(cmd);
                    var table = new DataTable();
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new Category(row));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting category list: " + ex.Message);
            }
            return list;
        }

        public Category? GetById(int id)
        {
            Category? category = null;
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM CATEGORY WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        category = new Category(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting category by ID: " + ex.Message);
            }
            return category;
        }

        public bool Update(Category category)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE CATEGORY 
                                    SET Name = @Name, SizeTypeID = @SizeTypeID, Active = @Active
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Name", category.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeTypeID", category.SizeTypeID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", category.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", category.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating category: " + ex.Message);
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "DELETE FROM CATEGORY WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting category: " + ex.Message);
                return false;
            }
        }
    }
}
