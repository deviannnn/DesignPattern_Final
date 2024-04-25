using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YameStore.Models
{
    public class SizesType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

        public SizesType() { }

        public SizesType(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            Name = (string)dataRow["Name"];
            Description = dataRow["Description"] != DBNull.Value ? (string)dataRow["Description"] : null;
            Active = (bool)dataRow["Active"];
        }

        public SizesType(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            Name = (string)reader["Name"];
            Description = reader["Description"] != DBNull.Value ? (string)reader["Description"] : null;
            Active = (bool)reader["Active"];
        }
    }

}
