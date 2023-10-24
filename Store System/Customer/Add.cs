using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.Customer
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        public Add(string S)
        {
            InitializeComponent();
            UserID.Text = S;
            Date.Text = DateTime.Now.ToString();
        }
        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string SName = CustomerName.Text;
            string SAddress = CustomerAddress.Text;
            string SMobile = CustomerPhone.Text;
            string SEmail = CustomerWhatsapp.Text;
            string SCity = CustomerCity.Text;
            string SAccountType = AccountType.Text;
            string SUserID = UserID.Text;
            if (!string.IsNullOrEmpty(SName)
                && !string.IsNullOrEmpty(SAddress)
                && !string.IsNullOrEmpty(SMobile)
                && !string.IsNullOrEmpty(SEmail)
                && !string.IsNullOrEmpty(SCity)
                && !string.IsNullOrEmpty(SAccountType)
                && !string.IsNullOrEmpty(SUserID))
            {
                AppClasses.Customer customer = new AppClasses.Customer();
                customer.Name = SName;
                customer.Wahtsapp = SAddress;
                customer.Mobile = SMobile;
                customer.Email = SEmail;
                customer.City = SCity;
                customer.UserID = Convert.ToInt32(SUserID);
                customer.AccountType = AccountType.Text;
                if (customer.Insert())
                {
                    MessageBox.Show("تم اضافة العميل بنجاح");
                    CustomerName.Text = string.Empty;
                    CustomerAddress.Text = string.Empty;
                    CustomerPhone.Text = string.Empty;
                    CustomerWhatsapp.Text = string.Empty;
                    CustomerCity.Text = string.Empty;
                    AccountType.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا في اضافة البيانات");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            CustomerName.Text = string.Empty;
            CustomerAddress.Text = string.Empty;
            CustomerPhone.Text = string.Empty;
            CustomerWhatsapp.Text = string.Empty;
            CustomerCity.Text = string.Empty;
            AccountType.SelectedItem = null;
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
