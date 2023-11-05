using Store_System.AppClasses;
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

namespace Store_System.Bills.SupplierBills
{
    public partial class CloseBill : Form
    {
        public CloseBill()
        {
            InitializeComponent();
        }
        public CloseBill(int UI , int BI , int SI)
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString();
            supplierbill.BillID = BI;
            supplierbill.SupplierID = SI;
            ItemsNumber.Text = supplierbill.TotalItems().ToString();
            BillPrice.Text = supplierbill.TotalPrice().ToString();
            SupplieMoney.Text = supplierbill.SupplierMoney().ToString();
            UserID.Text = UI.ToString();
        }
        private SupplierBill supplierbill = new SupplierBill();
        private void button2_Click(object sender, EventArgs e)
        {
            string SBillPrice = BillPrice.Text;
            string SBillInMoney = BillInMoney.Text;
            string SBillRest = BillRest.Text;
            if (!string.IsNullOrEmpty(SBillInMoney))
            {
                MainBill mainbill = new MainBill();
                mainbill.ID = supplierbill.BillID;
                mainbill.FullPrice = float.Parse(SBillPrice);
                mainbill.InMoney = float.Parse(SBillInMoney);
                mainbill.NetMoney = float.Parse(SBillRest);
                if (mainbill.CloseBill(supplierbill.SupplierID))
                {
                    MessageBox.Show("تم حفظ الفاتورة بنجاح");
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا ما في انهاء الفاتورة");
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
             
        }
        private void BillInMoney_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BillInMoney.Text))
            {
                BillRest.Text = (float.Parse(BillPrice.Text.ToString()) - float.Parse(BillInMoney.Text.ToString())).ToString();
            }
        }
    }
}
