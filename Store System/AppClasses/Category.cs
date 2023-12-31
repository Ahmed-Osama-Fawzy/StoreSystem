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
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int ProductsNumber { get; set; }
        public bool Active { get; set; }
        public int UserID { get; set; }
        public DataBase DB = new DataBase("dbo", "Category");
        public DataBase XDB = new DataBase("dbo", "Product");
        public int ReturnID(string N)
        {
            DataTable dt = DB.SelectOne("Name", N, "false", "ID");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
                return ID;
            }
            else
            {
                return -1;
            }
        }
        public bool Insert()
        {
            if(this.ReturnID(Name) == -1)
            {
                bool Inserted = DB.Insert("Name", Name, "false", "ProductsAmount", $"{0}", "true", "CreaterID", $"{UserID}", "true", "CreatedDate", Date, "false", "Active", $"{1}", "true");
                return Inserted;
            }
            else
            {
                MessageBox.Show("هذا القسم تم اضافتة مسبقا");
                return false;
            }
        }
        public bool PlusOne()
        {
            bool Updated = DB.CustomUpdate($"UPDATE Category SET ProductsAmount += 1 WHERE ID = {ID}");
            return Updated;
        }
        public bool Update(string NewName)
        {
            if (this.ReturnID(Name) != -1)
            {
                int Id = this.ReturnID(Name);
                bool Updated = DB.Update("Id", $"{Id}", "true", "Name", NewName, "false");
                return Updated;
            }
            else
            {
                MessageBox.Show("عفوا هذا القسم غير موجود");
                return false;
            }
        }
        public bool Remove()
        {
            bool Removed = false;
            int id  = ReturnID(Name);
            if(id != 0)
            {
                bool Updated = DB.Update("Id", $"{id}", "true", "Active", "NULL" , "true");
                if(Updated) { Removed = true; }
            }
            else
            {
                MessageBox.Show("عفوا هذا القسم غير موجود");
                Removed = false;
            }
            return Removed;
        }
        public DataTable SelectAll()
        {
            DataTable dt = DB.SelectOne("Active",$"{1}","true");
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }
        public DataTable Search(string S)
        {
            DataTable dt = DB.SelectLike(S,"Name");
            return dt;
        }
    }
}
