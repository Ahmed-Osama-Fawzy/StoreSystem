using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool Insert()
        {
            bool Inserted = DB.Insert("Name",Name,"false","ProductsAmount",$"{0}","true","CreaterID",$"{UserID}","true","CreatedDate",Date,"false");
            return Inserted;
        }
    }
}
