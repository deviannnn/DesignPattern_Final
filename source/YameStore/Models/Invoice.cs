using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class Invoice
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public int CustomerID { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExchangeDate { get; set; }
        public DateTime VoucherDate { get; set; }
        public bool UsedExchange { get; set; }
        public bool UsedVoucher { get; set; }
        public int TotalItem { get; set; }
        public double TotalOrigin { get; set; }
        public double DiscountAmount { get; set; }
        public double DiscountVoucher { get; set; }
        public double TotalAmount { get; set; }
        public int Receive { get; set; }
        public double NextDiscountVoucher { get; set; }
        public int MinAmountRequired { get; set; }

        public Invoice() { }

        public Invoice(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            AccountID = (int)dataRow["AccountID"];
            CustomerID = (int)dataRow["CustomerID"];
            Code = dataRow["Code"] != DBNull.Value ? (string)dataRow["Code"] : null;
            CreatedDate = (DateTime)dataRow["CreatedDate"];
            ExchangeDate = (DateTime)dataRow["ExchangeDate"];
            VoucherDate = (DateTime)dataRow["VoucherDate"];
            UsedExchange = (bool)dataRow["UsedExchange"];
            UsedVoucher = (bool)dataRow["UsedVoucher"];
            TotalItem = (int)dataRow["TotalItem"];
            TotalOrigin = Convert.ToDouble(dataRow["TotalOrigin"]);
            DiscountAmount = Convert.ToDouble(dataRow["DiscountAmount"]);
            DiscountVoucher = Convert.ToDouble(dataRow["DiscountVoucher"]);
            TotalAmount = Convert.ToDouble(dataRow["TotalAmount"]);
            Receive = (int)dataRow["Receive"];
            NextDiscountVoucher = Convert.ToDouble(dataRow["NextDiscountVoucher"]);
            MinAmountRequired = (int)dataRow["MinAmountRequired"];
        }

        public Invoice(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            AccountID = (int)reader["AccountID"];
            CustomerID = (int)reader["CustomerID"];
            Code = reader["Code"] != DBNull.Value ? (string)reader["Code"] : null;
            CreatedDate = (DateTime)reader["CreatedDate"];
            ExchangeDate = (DateTime)reader["ExchangeDate"];
            VoucherDate = (DateTime)reader["VoucherDate"];
            UsedExchange = (bool)reader["UsedExchange"];
            UsedVoucher = (bool)reader["UsedVoucher"];
            TotalItem = (int)reader["TotalItem"];
            TotalOrigin = Convert.ToDouble(reader["TotalOrigin"]);
            DiscountAmount = Convert.ToDouble(reader["DiscountAmount"]);
            DiscountVoucher = Convert.ToDouble(reader["DiscountVoucher"]);
            TotalAmount = Convert.ToDouble(reader["TotalAmount"]);
            Receive = (int)reader["Receive"];
            NextDiscountVoucher = Convert.ToDouble(reader["NextDiscountVoucher"]);
            MinAmountRequired = (int)reader["MinAmountRequired"];
        }
    }

}
