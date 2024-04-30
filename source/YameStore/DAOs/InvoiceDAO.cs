using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using YameStore.Models;
using YameDatabase;

namespace YameStore.DAOs
{
    public class InvoiceDAO
    {
        private readonly DatabaseFactory databaseFactory;

        public InvoiceDAO()
        {
            databaseFactory = DBFactoryManager.Instance.GetFactory();
        }

        public bool Insert(Invoice invoice)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"INSERT INTO INVOICE (AccountID, CustomerID, Code, CreatedDate, ExchangeDate, VoucherDate,
                                                        UsedExchange, UsedVoucher, TotalItem, TotalOrigin, DiscountAmount,
                                                        DiscountVoucher, TotalAmount, Receive, NextDiscountVoucher, MinAmountRequired) 
                                    VALUES (@AccountID, @CustomerID, @Code, @CreatedDate, @ExchangeDate, @VoucherDate,
                                            @UsedExchange, @UsedVoucher, @TotalItem, @TotalOrigin, @DiscountAmount,
                                            @DiscountVoucher, @TotalAmount, @Receive, @NextDiscountVoucher, @MinAmountRequired)";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@AccountID", invoice.AccountID);
                    databaseFactory.AddParameterWithValue(cmd, "@CustomerID", invoice.CustomerID);
                    databaseFactory.AddParameterWithValue(cmd, "@Code", invoice.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@CreatedDate", invoice.CreatedDate);
                    databaseFactory.AddParameterWithValue(cmd, "@ExchangeDate", invoice.ExchangeDate);
                    databaseFactory.AddParameterWithValue(cmd, "@VoucherDate", invoice.VoucherDate);
                    databaseFactory.AddParameterWithValue(cmd, "@UsedExchange", invoice.UsedExchange);
                    databaseFactory.AddParameterWithValue(cmd, "@UsedVoucher", invoice.UsedVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalItem", invoice.TotalItem);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalOrigin", invoice.TotalOrigin);
                    databaseFactory.AddParameterWithValue(cmd, "@DiscountAmount", invoice.DiscountAmount);
                    databaseFactory.AddParameterWithValue(cmd, "@DiscountVoucher", invoice.DiscountVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalAmount", invoice.TotalAmount);
                    databaseFactory.AddParameterWithValue(cmd, "@Receive", invoice.Receive);
                    databaseFactory.AddParameterWithValue(cmd, "@NextDiscountVoucher", invoice.NextDiscountVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@MinAmountRequired", invoice.MinAmountRequired);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while inserting invoice: " + ex.Message);
                return false;
            }
        }

        public Invoice? GetByCode(string code)
        {
            try
            {
                Invoice? invoice = null;
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM INVOICE WHERE CODE = @CODE";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);
                    databaseFactory.AddParameterWithValue(cmd, "@CODE", code);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        invoice = new Invoice(reader);
                    }
                    return invoice;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error! An error occurred. Please try again later", ex);
            }
        }

        public List<Invoice> GetAll()
        {
            List<Invoice> invoices = new List<Invoice>();
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = "SELECT * FROM INVOICE";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        invoices.Add(new Invoice(reader));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all invoices: " + ex.Message);
            }
            return invoices;
        }

        public bool Update(Invoice invoice)
        {
            try
            {
                using (var conn = databaseFactory.CreateConnection())
                {
                    conn.Open();

                    var cmdText = @"UPDATE INVOICE 
                                    SET AccountID = @AccountID, CustomerID = @CustomerID, Code = @Code,
                                        CreatedDate = @CreatedDate, ExchangeDate = @ExchangeDate, VoucherDate = @VoucherDate,
                                        UsedExchange = @UsedExchange, UsedVoucher = @UsedVoucher, TotalItem = @TotalItem,
                                        TotalOrigin = @TotalOrigin, DiscountAmount = @DiscountAmount, DiscountVoucher = @DiscountVoucher,
                                        TotalAmount = @TotalAmount, Receive = @Receive, NextDiscountVoucher = @NextDiscountVoucher,
                                        MinAmountRequired = @MinAmountRequired
                                    WHERE ID = @ID";
                    var cmd = databaseFactory.CreateCommand(cmdText, conn);

                    databaseFactory.AddParameterWithValue(cmd, "@AccountID", invoice.AccountID);
                    databaseFactory.AddParameterWithValue(cmd, "@CustomerID", invoice.CustomerID);
                    databaseFactory.AddParameterWithValue(cmd, "@Code", invoice.Code);
                    databaseFactory.AddParameterWithValue(cmd, "@CreatedDate", invoice.CreatedDate);
                    databaseFactory.AddParameterWithValue(cmd, "@ExchangeDate", invoice.ExchangeDate);
                    databaseFactory.AddParameterWithValue(cmd, "@VoucherDate", invoice.VoucherDate);
                    databaseFactory.AddParameterWithValue(cmd, "@UsedExchange", invoice.UsedExchange);
                    databaseFactory.AddParameterWithValue(cmd, "@UsedVoucher", invoice.UsedVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalItem", invoice.TotalItem);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalOrigin", invoice.TotalOrigin);
                    databaseFactory.AddParameterWithValue(cmd, "@DiscountAmount", invoice.DiscountAmount);
                    databaseFactory.AddParameterWithValue(cmd, "@DiscountVoucher", invoice.DiscountVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@TotalAmount", invoice.TotalAmount);
                    databaseFactory.AddParameterWithValue(cmd, "@Receive", invoice.Receive);
                    databaseFactory.AddParameterWithValue(cmd, "@NextDiscountVoucher", invoice.NextDiscountVoucher);
                    databaseFactory.AddParameterWithValue(cmd, "@MinAmountRequired", invoice.MinAmountRequired);
                    databaseFactory.AddParameterWithValue(cmd, "@ID", invoice.ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating invoice: " + ex.Message);
                return false;
            }
        }
    }
}
