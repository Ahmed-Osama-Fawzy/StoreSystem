using Store_System.AppClasses.Bills;
using Store_System.Bills;
using Store_System.Bills.SupplierBills;
using Store_System.Category;
using Store_System.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        public string AccountType = "";
        public string UserID = "";
        public Home(string S , string N)
        {
            InitializeComponent();
            AccountType = S;
            UserID = N;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             
        }

        private void InsertCustomer_Click(object sender, EventArgs e)
        {
            Customer.Add NewForm = new Customer.Add(UserID);
            NewForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category.Add NewForm = new Category.Add(UserID);
            NewForm.ShowDialog();
        }

        private void InsertUser_Click(object sender, EventArgs e)
        {
            if(AccountType == "مالك")
            {
                User.Add NewForm = new User.Add(UserID);
                NewForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("عفوا هذه الخدمة غير متاحة لنوع هذا الحساب");
            }
            
        }

        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            Supplier.Add NewForm = new Supplier.Add(UserID);
            NewForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnterBill_Click(object sender, EventArgs e)
        {
            NewBill NewForm = new NewBill(UserID);
            NewForm.ShowDialog();
        }

        private void CreateBill_Click(object sender, EventArgs e)
        {
            Bills.CustomerBill NewForm = new Bills.CustomerBill();
            NewForm.ShowDialog();
        }
    }
}
