using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
