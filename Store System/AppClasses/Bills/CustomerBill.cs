using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_System.App_Class;

namespace Store_System.AppClasses.Bills
{
    internal class CustomerBill
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }
        DataBase DB = new DataBase("dbo", "CustomerBill");
        public bool Insert()
        {
            bool Inserted = DB.Insert(
                "BillID", $"{BillID}", "true"
               , "CustomerID", $"{CustomerID}", "true"
               , "ProductID", $"{ProductID}", "true"
               , "Amount", $"{Amount}", "true"
               , "Price", $"{Price}", "true");
            return Inserted;
        }
        public float TotalItems()
        {
            DataTable dt = DB.CustomSelect($"SELECT COUNT(ProductID) AS ItemsNumber FROM CustomerBill WHERE BillID = {BillID} AND CustomerID = {CustomerID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["ItemsNumber"].ToString());
            }
            else return 0;
        }
        public float TotalPrice()
        {
            DataTable dt = DB.CustomSelect($"SELECT SUM(Amount*Price) AS TotalPrice FROM CustomerBill WHERE BillID = {BillID} AND CustomerID = {CustomerID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["TotalPrice"].ToString());
            }
            else return 0;
        }
        public float CustomerMoney()
        {
            DataTable dt = DB.CustomSelect($"SELECT NetMoney FROM Customer WHERE ID = {CustomerID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["NetMoney"].ToString());
            }
            else return 0;
        }

    }
}
