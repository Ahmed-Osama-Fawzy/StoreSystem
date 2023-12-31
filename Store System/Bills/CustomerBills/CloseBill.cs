using Store_System.AppClasses.Bills;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.Bills.CustomerBills
{
    public partial class CloseBill : Form
    {
        public CloseBill()
        {
            InitializeComponent();
        }
        public CloseBill(int U , int B)
        {
            InitializeComponent();
            customerill.BillID = B;

        }
        private CustomerBill customerill = new CustomerBill();
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
