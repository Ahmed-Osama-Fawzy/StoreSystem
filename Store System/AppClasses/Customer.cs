using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_System.App_Class;

namespace Store_System.AppClasses
{
    internal class Customer
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Wahtsapp { get; set; }
        public string Mobile { get; set; }
        public string City { get; set; }
        public string AccountType { get; set; }
        public float InMoney { get; set; }
        public float OutMoney { get; set; }
        public float NetMoney { get; set; }
        public DataBase DB = new DataBase("dbo", "Customer");
        public bool Insert()
        {
            bool Inserted = DB.Insert(
                "UserID", $"{UserID}", "true",
                "Date", Date, "false",
                "Name", Name, "false",
                "Wahtsapp", Wahtsapp, "false",
                "Mobile", Mobile, "false",
                "Address", Address, "false",
                "City", City, "false",
                "AccountType", AccountType, "false",
                "InMoney", $"{0}", "true",
                "OutMoney", $"{0}", "true",
                "NetMoney", $"{0}", "true");
            return Inserted;
        }
        public DataTable GetCustomers()
        {
            return DB.GetData("Name");
        }
    }
}
