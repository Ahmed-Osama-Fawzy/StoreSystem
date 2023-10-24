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
            Supplier.DisplayMember = "Name";
            Supplier.ValueMember = "Name";
            if (dt.Rows.Count > 0) {
                Supplier.DataSource = dt; Supplier.Enabled = true;
            }else
                Supplier.Enabled = false;
        }

        private void NewBill_Load(object sender, EventArgs e)
        {

        }

        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string SSupplier = Supplier.Text;
            if (!string.IsNullOrEmpty(SSupplier))
            {
                
            }
        }
    }
}
