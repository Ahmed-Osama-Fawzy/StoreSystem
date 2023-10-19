using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.AppClasses
{
    internal class CategoryClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int UserID { get; set; }
        public DataBase DB = new DataBase("dbo", "Category");
        public bool Insert()
        {
            bool Inserted = DB.Insert("Name",Name,"false","ProductsAmount",$"{0}","true","CreaterID",$"{UserID}","true","CreatedDate",Date,"false");
            return Inserted;
        }
    }
}
