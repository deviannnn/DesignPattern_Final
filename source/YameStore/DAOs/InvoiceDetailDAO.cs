using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class InvoiceDetailDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public InvoiceDetailDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(InvoiceDetail invoiceDetail)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO INVOICE_DETAIL (InvoiceID, ProductSizeID, SKU, Quantity, Price, Origin, Discount, Amount, ExchangeQuantity) 
                                    VALUES (@InvoiceID, @ProductSizeID, @SKU, @Quantity, @Price, @Origin, @Discount, @Amount, @ExchangeQuantity)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@InvoiceID", invoiceDetail.InvoiceID);
                    databaseFactory.AddParameterWithValue(cmd, "@ProductSizeID", invoiceDetail.ProductSizeID);
                    databaseFactory.AddParameterWithValue(cmd, "@SKU", invoiceDetail.SKU);
                    databaseFactory.AddParameterWithValue(cmd, "@Quantity", invoiceDetail.Quantity);
                    databaseFactory.AddParameterWithValue(cmd, "@Price", invoiceDetail.Price);
                    databaseFactory.AddParameterWithValue(cmd, "@Origin", invoiceDetail.Origin);
                    databaseFactory.AddParameterWithValue(cmd, "@Discount", invoiceDetail.Discount);
                    databaseFactory.AddParameterWithValue(cmd, "@Amount", invoiceDetail.Amount);
                    databaseFactory.AddParameterWithValue(cmd, "@ExchangeQuantity", invoiceDetail.ExchangeQuantity);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting invoice detail: " + ex.Message);
                return false;
            }
        }

        public List<InvoiceDetail> GetAll()
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM INVOICE_DETAIL";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        invoiceDetails.Add(new InvoiceDetail(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all invoice details: " + ex.Message);
            }
            return invoiceDetails;
        }

        public bool Update(InvoiceDetail invoiceDetail)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE INVOICE_DETAIL 
                                    SET InvoiceID = @InvoiceID, ProductSizeID = @ProductSizeID, SKU = @SKU,
                                        Quantity = @Quantity, Price = @Price, Origin = @Origin, 
                                        Discount = @Discount, Amount = @Amount, ExchangeQuantity = @ExchangeQuantity
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@InvoiceID", invoiceDetail.InvoiceID);
                    databaseFactory.AddParameterWithValue(cmd, "@ProductSizeID", invoiceDetail.ProductSizeID);
                    databaseFactory.AddParameterWithValue(cmd, "@SKU", invoiceDetail.SKU);
                    databaseFactory.AddParameterWithValue(cmd, "@Quantity", invoiceDetail.Quantity);
                    databaseFactory.AddParameterWithValue(cmd, "@Price", invoiceDetail.Price);
                    databaseFactory.AddParameterWithValue(cmd, "@Origin", invoiceDetail.Origin);
                    databaseFactory.AddParameterWithValue(cmd, "@Discount", invoiceDetail.Discount);
                    databaseFactory.AddParameterWithValue(cmd, "@Amount", invoiceDetail.Amount);
                    databaseFactory.AddParameterWithValue(cmd, "@ExchangeQuantity", invoiceDetail.ExchangeQuantity);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", invoiceDetail.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating invoice detail: " + ex.Message);
                return false;
            }
        }
    }
}
