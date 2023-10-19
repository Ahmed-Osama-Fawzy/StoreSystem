using Store_System.AppClasses;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string AccountType = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string SUsername = Convert.ToString(Username.Text);
            string SPassword = Convert.ToString(Password.Text);
            
            if(!string.IsNullOrEmpty(SUsername) && !string.IsNullOrEmpty(SPassword))
            {
                Login login = new Login(SUsername , SPassword);
                if (login.SearchAccount())
                {
                    AccountType = login.AccountType;
                    Home NewForm = new Home(AccountType, Convert.ToString(login.ID));
                    NewForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال جميع البيانات");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
