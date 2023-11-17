using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Store_System.AppClasses;
using Store_System.AppClasses.Bills;

namespace Store_System.Bills.CustomerBills
{
    public partial class EnterCustomer : Form
    {
        public EnterCustomer()
        {
            InitializeComponent();
        }
        public EnterCustomer(string UI)
        {
            InitializeComponent();
            UserID.Text = UI;
            Date.Text = DateTime.Now.ToString();
        }
        AppClasses.Customer customer = new AppClasses.Customer();
        private void CustomersInput_TextChanged(object sender, EventArgs e)
        {
            string search = CustomersInput.Text;
            DataTable dt = customer.GetCustomers(search);
            Clients.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Clients.Items.Add(dr["Name"]);
            }
        }

        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string UserId = UserID.Text;
            string SData = Date.Text;
            string CustomerName = Clients.Text;
            if (!string.IsNullOrEmpty(CustomerName))
            {
                int Customerid = customer.ReturnId(CustomerName);
                int Userid = int.Parse(UserId);
                if(Customerid > 0)
                {
                    MainBill newbill = new MainBill();
                    newbill.UserID = Userid;
                    if (newbill.Insert())
                    {
                        int Id = newbill.ReturnID();
                        if (Id > 0)
                        {
                            ChooseProducts NewForm = new ChooseProducts(Customerid, Userid, id);
                            NewForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("عفوا لقد حدث خطا ما");
                        }
                    }
                    else
                    {
                        MessageBox.Show("عفوا حدث خكا في انشاء الفاتورة");
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب اختيار اسم العميل اولا");
            }
        }
    }
}
