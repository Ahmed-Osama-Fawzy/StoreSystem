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
namespace Store_System.Category
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            Date.Text = Convert.ToString(DateTime.Now);
        }

        public Add(string S)
        {
            InitializeComponent();
            UserID.Text = S;
            Date.Text = Convert.ToString(DateTime.Now);
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string CDate = Date.Text;
            string UserId = UserID.Text;
            string Name = CategoryName.Text;
            if(!string.IsNullOrEmpty(CDate) && !string.IsNullOrEmpty(UserId) && !string.IsNullOrEmpty(Name)) 
            {
                CategoryClass category = new CategoryClass();
                category.Name = Name;
                category.Date = CDate;
                category.UserID = Convert.ToInt32(UserId);
                bool Inserted = category.Insert();
                if(Inserted) {

                    MessageBox.Show("تم الاضافة بنجاح");
                }
                else
                {
                    MessageBox.Show("عفوا لا يمكن الاضافة");
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال البيانات كاملة اولا");
            }
        }
    }
}
