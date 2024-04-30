using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public double PercentDiscount { get; set; }
        public bool Active { get; set; }

        public Customer() { }

        public Customer(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Code = (string)dataRow["CODE"];
            Phone = (string)dataRow["PHONE"];
            Name = (string)dataRow["NAME"];
            Point = (int)dataRow["POINT"];
            PercentDiscount = Convert.ToDouble(dataRow["PERCENT_DISCOUNT"]);
            Active = (bool)dataRow["ACTIVE"];
        }

        public Customer(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            Code = (string)reader["CODE"];
            Phone = (string)reader["PHONE"];
            Name = (string)reader["NAME"];
            Point = (int)reader["POINT"];
            PercentDiscount = Convert.ToDouble(reader["PERCENT_DISCOUNT"]);
            Active = (bool)reader["ACTIVE"];
        }
    }

}
