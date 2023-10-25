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
using Workshop_System.App_Class;

namespace Store_System.Bills.SupplierBills
{
    public partial class NewBill : Form
    {
        public NewBill()
        {
            InitializeComponent();
        }

        public NewBill(string S)
        {
            InitializeComponent();
            UserID.Text = S;
            Date.Text = DateTime.Now.ToString();
            DataBase DB = new DataBase("dbo", "Supplier");
            DataTable dt = DB.Select("Name");
            SupplierName.DisplayMember = "Name";
            SupplierName.ValueMember = "Name";
            if (dt.Rows.Count > 0) {
                SupplierName.DataSource = dt; SupplierName.Enabled = true;
            }else
                SupplierName.Enabled = false;
        }
        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string suppliername = SupplierName.Text;
            if (!string.IsNullOrEmpty(suppliername))
            {
                int userid = Convert.ToInt32(UserID.Text);
                string sdate = Date.Text;
                MainBill newbill = new MainBill();
                newbill.UserID = userid;
                newbill.Date = sdate;
                AppClasses.Supplier supplier = new AppClasses.Supplier();
                int supplierid = supplier.ReturnID(suppliername);
                
                if (newbill.Insert())
                {
                    int billid = newbill.ReturnID();
                    if(billid != -1)
                    {
                        Enter NewForm = new Enter(supplierid,billid);
                        NewForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خطا ما 1");
                    }
                }
                else
                {
                    MessageBox.Show("2 عفوا حدث خطا ما");
                }
            }
        }
    }
}
