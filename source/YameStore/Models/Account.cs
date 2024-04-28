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
        public string Username { get; set; }
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
            YameID = (string)dataRow["YAME_ID"];
            Gmail = (string)dataRow["GMAIL"];
            Phone = (string)dataRow["PHONE"];
            Password = (string)dataRow["PASSWORD"];
            Name = (string)dataRow["NAME"];
            Gender = (bool)dataRow["GENDER"];
            Address = (string)dataRow["ADDRESS"];
            Locked = (bool)dataRow["LOCKED"];
            Active = (bool)dataRow["ACTIVE"];
            Role = (string)dataRow["ROLE"];
        }

        public Account(DbDataReader reader)
        {
            ID = (int)reader["ID"];
            YameID = (string)reader["YAME_ID"];
            Gmail = (string)reader["GMAIL"];
            Phone = (string)reader["PHONE"];
            Password = (string)reader["PASSWORD"];
            Name = (string)reader["NAME"];
            Gender = (bool)reader["GENDER"];
            Address = (string)reader["ADDRESS"];
            Locked = (bool)reader["LOCKED"];
            Active = (bool)reader["ACTIVE"];
            Role = (string)reader["ROLE"];
        }
    }
}
