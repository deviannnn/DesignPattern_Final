using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class InvoiceDetail
    {
        public int ID { get; set; }
        public int InvoiceID { get; set; }
        public int ProductSizeID { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Origin { get; set; }
        public double Discount { get; set; }
        public double Amount { get; set; }
        public int ExchangeQuantity { get; set; }

        public InvoiceDetail() { }

        public InvoiceDetail(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            InvoiceID = (int)dataRow["InvoiceID"];
            ProductSizeID = (int)dataRow["ProductSizeID"];
            SKU = (string)dataRow["SKU"];
            Quantity = (int)dataRow["Quantity"];
            Price = Convert.ToDouble(dataRow["Price"]);
            Origin = Convert.ToDouble(dataRow["Origin"]);
            Discount = Convert.ToDouble(dataRow["Discount"]);
            Amount = Convert.ToDouble(dataRow["Amount"]);
            ExchangeQuantity = (int)dataRow["ExchangeQuantity"];
        }

        public InvoiceDetail(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            InvoiceID = (int)reader["InvoiceID"];
            ProductSizeID = (int)reader["ProductSizeID"];
            SKU = (string)reader["SKU"];
            Quantity = (int)reader["Quantity"];
            Price = Convert.ToDouble(reader["Price"]);
            Origin = Convert.ToDouble(reader["Origin"]);
            Discount = Convert.ToDouble(reader["Discount"]);
            Amount = Convert.ToDouble(reader["Amount"]);
            ExchangeQuantity = (int)reader["ExchangeQuantity"];
        }
    }

}
