using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class ProductDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public ProductDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Product product)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO PRODUCT (Code, Name, Cost, Price, PercentDiscount, CategoryID, Active) 
                                    VALUES (@Code, @Name, @Cost, @Price, @PercentDiscount, @CategoryID, @Active)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Code", product.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", product.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@Cost", product.Cost);
                    databaseFactory.AddParameterWithValue(cmd, "@Price", product.Price);
                    databaseFactory.AddParameterWithValue(cmd, "@PercentDiscount", product.PercentDiscount);
                    databaseFactory.AddParameterWithValue(cmd, "@CategoryID", product.CategoryID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", product.Active);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting product: " + ex.Message);
                return false;
            }
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM PRODUCT";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        products.Add(new Product(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all products: " + ex.Message);
            }
            return products;
        }

        public Product GetById(int id)
        {
            Product product = null;
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM PRODUCT WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        product = new Product(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting product by ID: " + ex.Message);
            }
            return product;
        }

        public bool Update(Product product)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE PRODUCT 
                                    SET Code = @Code, Name = @Name, Cost = @Cost, Price = @Price,
                                        PercentDiscount = @PercentDiscount, CategoryID = @CategoryID, Active = @Active
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@Code", product.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@Name", product.Name);
                    databaseFactory.AddParameterWithValue(cmd, "@Cost", product.Cost);
                    databaseFactory.AddParameterWithValue(cmd, "@Price", product.Price);
                    databaseFactory.AddParameterWithValue(cmd, "@PercentDiscount", product.PercentDiscount);
                    databaseFactory.AddParameterWithValue(cmd, "@CategoryID", product.CategoryID);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", product.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", product.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating product: " + ex.Message);
                return false;
            }
        }
    }
}
