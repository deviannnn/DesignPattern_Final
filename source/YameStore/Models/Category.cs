using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SizeTypeID { get; set; }
        public bool Active { get; set; }

        public Category() { }

        public Category(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Name = (string)dataRow["Name"];
            SizeTypeID = (int)dataRow["SizeTypeID"];
            Active = (bool)dataRow["Active"];
        }

        public Category(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            Name = (string)reader["Name"];
            SizeTypeID = (int)reader["SizeTypeID"];
            Active = (bool)reader["Active"];
        }
    }

}
