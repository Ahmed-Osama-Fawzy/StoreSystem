using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Store_System.AppClasses;
namespace Store_System.Supplier
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
            string SName = SupplierName.Text;
            string SAddress = SupplierAddress.Text;
            string SMobile = SupplierPhone.Text;
            string SEmail = SupplierWhatsapp.Text;
            string SCity = SupplierCity.Text;
            string SAccountType = AccountType.Text;
            string SUserID = UserID.Text;
            if(!string.IsNullOrEmpty(SName) 
                && !string.IsNullOrEmpty(SAddress)
                && !string.IsNullOrEmpty(SMobile)
                && !string.IsNullOrEmpty(SEmail)
                && !string.IsNullOrEmpty(SCity)
                && !string.IsNullOrEmpty(SAccountType)
                && !string.IsNullOrEmpty(SUserID))
            {
                AppClasses.Supplier supplier = new AppClasses.Supplier();
                supplier.Name = SName;
                supplier.Address = SAddress;
                supplier.Mobile = SMobile;
                supplier.Wahtsapp = SEmail;
                supplier.City = SCity;
                supplier.UserID = Convert.ToInt32(SUserID);
                supplier.AccountType = AccountType.Text;
                if (supplier.Insert())
                {
                    MessageBox.Show("تم اضافة المورد بنجاح");
                    SupplierName.Text = string.Empty;
                    SupplierAddress.Text = string.Empty;
                    SupplierPhone.Text = string.Empty;
                    SupplierWhatsapp.Text = string.Empty;
                    SupplierCity.Text = string.Empty;
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

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            SupplierName.Text = string.Empty;
            SupplierAddress.Text = string.Empty;
            SupplierPhone.Text = string.Empty;
            SupplierWhatsapp.Text = string.Empty;
            SupplierCity.Text = string.Empty;
            AccountType.SelectedItem = null;
        }
    }
}
