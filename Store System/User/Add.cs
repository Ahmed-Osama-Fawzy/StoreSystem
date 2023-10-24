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

namespace Store_System.User
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

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void InsertUser_Click(object sender, EventArgs e)
        {
            string SUserID = UserID.Text;
            string SUsernamr = Username.Text;
            string SPassword = UserPassword.Text;
            string SAccountType = AccountType.Text;
            if(!string .IsNullOrEmpty(SUserID) 
            && !string .IsNullOrEmpty(SUserID)
            && !string .IsNullOrEmpty(SUserID) 
            && !string.IsNullOrEmpty(SAccountType))
            {
                AppClasses.User user = new AppClasses.User();
                user.UserID = Convert.ToInt32(SUserID);
                user.Username = SUsernamr;
                user.Password = SPassword;
                user.AccountType = SAccountType;
                if (user.Insert())
                {
                    MessageBox.Show("تم اضافة المستخدم بنجاح");
                    Username.Text = string.Empty;
                    UserPassword.Text = string.Empty;
                    AccountType.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا في اضافة المستخدم");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال البيانات كاملة");
            }
        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            Username.Text = string.Empty;
            UserPassword.Text = string.Empty;
            AccountType.SelectedItem = null;
        }
    }
}
