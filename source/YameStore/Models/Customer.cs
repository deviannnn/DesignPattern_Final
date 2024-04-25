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
        public string YameID { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public double Discount { get; set; }
        public bool Active { get; set; }

        public Customer() { }

        public Customer(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            YameID = (string)dataRow["YameID"];
            Phone = (string)dataRow["Phone"];
            Name = (string)dataRow["Name"];
            Point = (int)dataRow["Point"];
            Discount = Convert.ToDouble(dataRow["Discount"]);
            Active = (bool)dataRow["Active"];
        }

        public Customer(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            YameID = (string)reader["YameID"];
            Phone = (string)reader["Phone"];
            Name = (string)reader["Name"];
            Point = (int)reader["Point"];
            Discount = Convert.ToDouble(reader["Discount"]);
            Active = (bool)reader["Active"];
        }
    }

}
