using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class ProductSizeDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public ProductSizeDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(ProductSize productSize)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO PRODUCT_SIZE (ProductID, SizeID, SKU, Quantity, Active) 
                            VALUES (@ProductID, @SizeID, @SKU, @Quantity, @Active)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@ProductID", productSize.ProductID);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeID", productSize.SizeID);
                    databaseFactory.AddParameterWithValue(cmd, "@SKU", productSize.SKU);
                    databaseFactory.AddParameterWithValue(cmd, "@Quantity", productSize.Quantity);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", productSize.Active);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting product size: " + ex.Message);
                return false;
            }
        }

        public List<ProductSize> GetAll()
        {
            List<ProductSize> productSizes = new List<ProductSize>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM PRODUCT_SIZE";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        productSizes.Add(new ProductSize(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all product sizes: " + ex.Message);
            }
            return productSizes;
        }

        public ProductSize GetById(int id)
        {
            ProductSize productSize = null;
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM PRODUCT_SIZE WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", id);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        productSize = new ProductSize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting product size by ID: " + ex.Message);
            }
            return productSize;
        }

        public bool Update(ProductSize productSize)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE PRODUCT_SIZE 
                                    SET ProductID = @ProductID, SizeID = @SizeID, SKU = @SKU, Quantity = @Quantity, Active = @Active
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@ProductID", productSize.ProductID);
                    databaseFactory.AddParameterWithValue(cmd, "@SizeID", productSize.SizeID);
                    databaseFactory.AddParameterWithValue(cmd, "@SKU", productSize.SKU);
                    databaseFactory.AddParameterWithValue(cmd, "@Quantity", productSize.Quantity);
                    databaseFactory.AddParameterWithValue(cmd, "@Active", productSize.Active);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", productSize.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating product size: " + ex.Message);
                return false;
            }
        }
    }
}
