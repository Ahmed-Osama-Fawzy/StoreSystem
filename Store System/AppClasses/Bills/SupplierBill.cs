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
            bool Inserted = false;
            return Inserted;
        }
    }
}
