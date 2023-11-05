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
    internal class SupplierBill
    {
        public int BillID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }
        DataBase DB = new DataBase("dbo","SupplierBill");
        public bool Insert()
        {
            bool Inserted = DB.Insert(
                "BillID",$"{BillID}","true"
               ,"SupplierID",$"{SupplierID}","true"
               ,"ProductID",$"{ProductID}","true"
               ,"Amount",$"{Amount}","true"
               ,"Price",$"{Price}","true");
            return Inserted;
        }
        public int TotalItems()
        {
            DataTable dt = DB.CustomSelect($"SELECT COUNT(ProductID) AS ItemsNumber FROM SupplierBill WHERE BillID = {BillID} AND SupplierID = {SupplierID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["ItemsNumber"].ToString());
            }
            else return 0;
        }
        public float TotalPrice()
        {
            DataTable dt = DB.CustomSelect($"SELECT SUM(Amount*Price) AS TotalPrice FROM SupplierBill WHERE BillID = {BillID} AND SupplierID = {SupplierID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["TotalPrice"].ToString());
            }
            else return 0;
        }
        public float SupplierMoney()
        {
            DataTable dt = DB.CustomSelect($"SELECT NetMoney FROM Supplier WHERE ID = {SupplierID}");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return int.Parse(dr["NetMoney"].ToString());
            }
            else return 0;
        }
    }
}
