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
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public float Amount { get; set; }
        public float MainPrice { get; set; }
        public float OneProfit { get; set; }
        public float ManyProfit { get; set; }
        public string Unit { get; set; }
        DataBase DB = new DataBase("dbo", "Product");
        public bool Insert()
        {
            bool Inserted = DB.Insert(
                 "Name",Name,"false"
                ,"CategoryID",$"{CategoryID}","true"
                ,"Amount",$"{Amount}","true"
                ,"MainPrice",$"{MainPrice}","true"
                ,"OneProfit",$"{OneProfit}","true"
                ,"ManyProfit",$"{ManyProfit}","true"
                ,"Unit",Unit,"false");
            return Inserted;
        }
        public int ReturnID()
        {
            DataTable dt = DB.SelectOne("Name",Name,"false","ID");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
                return ID;
            }
            return -1;
        }
        public bool Increse(float N  , string S , char O)
        {
            bool Updated = false;
            if (S == "Amount")
                Updated = DB.CustomUpdate($"UPDATE Product SET {S} += {N} WHERE ID = {ID}");
            else
                Updated = DB.CustomUpdate($"UPDATE Product SET {S} {O} {N} WHERE ID = {ID}");
            return Updated;
        }   
    }
}
