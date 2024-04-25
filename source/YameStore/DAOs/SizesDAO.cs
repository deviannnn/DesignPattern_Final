using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class SizesDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public SizesDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Sizes size)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO SIZES (Code, Name, SizeTypeID, Active) 
                            VALUES (@Code, @Name, @SizeTypeID, @Active)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Code", size.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", size.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeTypeID", size.SizesTypeID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", size.Active);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting size: " + ex.Message);
                return false;
            }
        }

        public List<Sizes> GetAll()
        {
            List<Sizes> sizes = new List<Sizes>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM SIZES";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sizes.Add(new Sizes(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all sizes: " + ex.Message);
            }
            return sizes;
        }

        public Sizes GetById(int id)
        {
            Sizes size = null;
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM SIZES WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        size = new Sizes(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting size by ID: " + ex.Message);
            }
            return size;
        }

        public bool Update(Sizes size)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE SIZES 
                                    SET Code = @Code, Name = @Name, SizeTypeID = @SizeTypeID, Active = @Active
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Code", size.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", size.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeTypeID", size.SizesTypeID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", size.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", size.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating size: " + ex.Message);
                return false;
            }
        }
    }
}
