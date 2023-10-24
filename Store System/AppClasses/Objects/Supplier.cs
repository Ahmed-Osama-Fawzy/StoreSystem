using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;

namespace Store_System.AppClasses
{
    internal class Supplier
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
        public DataBase DB = new DataBase("dbo", "Supplier");
        public bool Insert()
        {
            bool Inserted = DB.Insert(
                "Name",Name,"false",
                "Address" , Address ,"false",
                "Mobile" , Mobile ,"false",
                "Wahtsapp", Wahtsapp , "false",
                "City" , City , "false",
                "AccountType", AccountType, "false",
                "UserID" , $"{UserID}" , "true",
                "Date" , Date , "false",
                "InMoney" , $"{0}" , "true" ,
                "OutMoney", $"{0}", "true",
                "NetMoney", $"{0}", "true");
            return Inserted;
        }
        public int ReturnID(string N)
        {
            DataTable dt = DB.SelectOne("Name", N, "false", "ID");
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
                return ID;
            }
            else
            {
                MessageBox.Show("عفوا حدث خطا ما");
            }
            return -1;
        }
    }
}
