using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class ProductSize
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int SizeID { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
        public bool Active { get; set; }
        public Product Product { get; set; }

        public ProductSize() { }

        public ProductSize(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            ProductID = (int)dataRow["ProductID"];
            SizeID = (int)dataRow["SizeID"];
            SKU = dataRow["SKU"] != DBNull.Value ? (string)dataRow["SKU"] : null;
            Quantity = (int)dataRow["Quantity"];
            Active = (bool)dataRow["Active"];
        }

        public ProductSize(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            ProductID = (int)reader["ProductID"];
            SizeID = (int)reader["SizeID"];
            SKU = reader["SKU"] != DBNull.Value ? (string)reader["SKU"] : null;
            Quantity = (int)reader["Quantity"];
            Active = (bool)reader["Active"];
        }
    }

}
