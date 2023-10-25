using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop_System.App_Class;

namespace Store_System.AppClasses.Bills
{
    internal class MainBill
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Date { get; set; }
        public int ProductsNumber { get; set; }
        public float FullPrice { get; set; }
        public float InMoney { get; set; }
        public float NetMoney { get; set; }
        public DataBase DB = new DataBase("dbo","Bill");
        public bool Insert()
        {
            bool Inserted = DB.Insert("UserID", $"{UserID}","true");
            return Inserted;
        }
        public int ReturnID()
        {
            DataTable dt = DB.CustomSelect("SELECT TOP 1 ID FROM Bill order by ID DESC");
            if(dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
                return ID;
            }
            return -1;
        }
    }
}
