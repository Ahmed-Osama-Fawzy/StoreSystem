using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_System.AppClasses
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public float FullAmount { get; set; }
        public float MainPrice { get; set; }
        public float OneProfit { get; set; }
        public float ManyProfit { get; set; }
        public float Unit { get; set; }
    }
}
