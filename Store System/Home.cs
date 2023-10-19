using Store_System.Category;
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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add(UserID);
            NewForm.ShowDialog();
        }
    }
}
