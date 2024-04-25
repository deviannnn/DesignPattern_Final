using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class Sizes
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int SizesTypeID { get; set; }
        public bool Active { get; set; }

        public Sizes() { }

        public Sizes(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Code = (string)dataRow["Code"];
            Name = (string)dataRow["Name"];
            SizesTypeID = (int)dataRow["SizeTypeID"];
            Active = (bool)dataRow["Active"];
        }

        public Sizes(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            Code = (string)reader["Code"];
            Name = (string)reader["Name"];
            SizesTypeID = (int)reader["SizeTypeID"];
            Active = (bool)reader["Active"];
        }
    }

}
