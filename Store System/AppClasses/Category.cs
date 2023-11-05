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
        public int UserID { get; set; }
        public DataBase DB = new DataBase("dbo", "Category");
        public DataBase XDB = new DataBase("dbo", "Products");
        public bool Insert()
        {
            bool Inserted = DB.Insert("Name",Name,"false","ProductsAmount",$"{0}","true","CreaterID",$"{UserID}","true","CreatedDate",Date,"false");
            return Inserted;
        }
        public int ReturnID(string N)
        {
            DataTable dt = DB.SelectOne("Name",N,"false","ID");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                ID = Convert.ToInt32(dr["ID"]);
                return ID;
            }
            else
            {
                MessageBox.Show("عفوا حدث خطا");
            }
            return -1;
        }
        public bool PlusOne()
        {
            bool Updated = DB.CustomUpdate($"UPDATE Category SET ProductsAmount += 1 WHERE ID = {ID}");
            return Updated;
        }
        public bool Update(string S)
        {
            bool Updated = DB.Update("Name",Name,"false","Name",S,"false");
            return Updated;
        }
        public bool Remove()
        {
            int id  = ReturnID(Name);
            if(id != 0)
            {
                bool DelCat = DB.Delete("Name", Name, "false");
                bool DelPro = XDB.Delete("CategoryID",$"{ID}","true");
                if (DelCat && DelPro)
                    return true;
            }
            return false;
        }
        public DataTable SelectAll()
        {
            DataTable dt = DB.Select("all");
            if (dt.Rows.Count > 0)
                return dt;
            return null;
        }

    }
}
