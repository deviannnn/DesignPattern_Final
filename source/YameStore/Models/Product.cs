using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public double PercentDiscount { get; set; }
        public int CategoryID { get; set; }
        public bool Active { get; set; }

        public Product() { }

        public Product(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Code = dataRow["Code"] != DBNull.Value ? (string)dataRow["Code"] : null;
            Name = (string)dataRow["Name"];
            Cost = Convert.ToDouble(dataRow["Cost"]);
            Price = Convert.ToDouble(dataRow["Price"]);
            PercentDiscount = Convert.ToDouble(dataRow["PercentDiscount"]);
            CategoryID = (int)dataRow["CategoryID"];
            Active = (bool)dataRow["Active"];
        }

        public Product(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            Code = reader["Code"] != DBNull.Value ? (string)reader["Code"] : null;
            Name = (string)reader["Name"];
            Cost = Convert.ToDouble(reader["Cost"]);
            Price = Convert.ToDouble(reader["Price"]);
            PercentDiscount = Convert.ToDouble(reader["PercentDiscount"]);
            CategoryID = (int)reader["CategoryID"];
            Active = (bool)reader["Active"];
        }
    }

}
