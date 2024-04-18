using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YameDatabase;

namespace YameStore.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string YameID { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public string Role { get; set; }
        public Account() { }

        public Account(DataRow dataRow)
        {
            ID = (int)dataRow["ID"];
            YameID = (string)dataRow["YameID"];
            Gmail = (string)dataRow["Gmail"];
            Phone = (string)dataRow["Phone"];
            Password = (string)dataRow["Password"];
            Name = (string)dataRow["Name"];
            Gender = (bool)dataRow["Gender"];
            Address = (string)dataRow["Address"];
            Locked = (bool)dataRow["Locked"];
            Active = (bool)dataRow["Active"];
            Role = (string)dataRow["Role"];
        }

        public Account(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            YameID = (string)reader["YameID"];
            Gmail = (string)reader["Gmail"];
            Phone = (string)reader["Phone"];
            Password = (string)reader["Password"];
            Name = (string)reader["Name"];
            Gender = (bool)reader["Gender"];
            Address = (string)reader["Address"];
            Locked = (bool)reader["Locked"];
            Active = (bool)reader["Active"];
            Role = (string)reader["Role"];
        }
    }
}
