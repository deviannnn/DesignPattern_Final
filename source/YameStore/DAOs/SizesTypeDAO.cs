using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class SizesTypeDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public SizesTypeDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(SizesType sizeType)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO SIZE_TYPE (Name, Description, Active) 
                            VALUES (@Name, @Description, @Active)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Name", sizeType.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@Description", sizeType.Description);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", sizeType.Active);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting size type: " + ex.Message);
                return false;
            }
        }

        public List<SizesType> GetAll()
        {
            List<SizesType> sizeTypes = new List<SizesType>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM SIZE_TYPE";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sizeTypes.Add(new SizesType(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all size types: " + ex.Message);
            }
            return sizeTypes;
        }

        public SizesType GetById(int id)
        {
            SizesType sizeType = null;
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM SIZE_TYPE WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        sizeType = new SizesType(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting size type by ID: " + ex.Message);
            }
            return sizeType;
        }

        public bool Update(SizesType sizeType)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE SIZE_TYPE 
                                    SET Name = @Name, Description = @Description, Active = @Active
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Name", sizeType.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@Description", sizeType.Description);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", sizeType.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", sizeType.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating size type: " + ex.Message);
                return false;
            }
        }
    }
}
