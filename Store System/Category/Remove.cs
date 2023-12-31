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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }
        public Remove(string UI, string D)
        {
            InitializeComponent();
            UserID.Text = UI;
            Date.Text = D;
        }
        public Remove(string UI, string D,string CID)
        {
            InitializeComponent();
            UserID.Text = UI;
            Date.Text = D;
            CategoryName.Text = CID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SName = CategoryName.Text;
            string TheDate = Date.Text;
            string Userid = UserID.Text;
            DialogResult result = MessageBox.Show("هل انت متاكد من حذف القسم , سوف يتم حذف جميع المنتجات بهذا القسم نهائيا" , "رسالة تاكيدية" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AppClasses.Category category = new AppClasses.Category();
                if (!string.IsNullOrEmpty(TheDate)
                    && !string.IsNullOrEmpty(Userid)
                    && !string.IsNullOrEmpty(SName))
                {
                    category.Name = SName;
                    if (category.Remove())
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        CategoryName.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("عفوا لم تتم عملية لحذف بنجاح");
                    }
                }
                else
                {
                    MessageBox.Show("عفوا يجب ادخال جميع البيانات للحذ");
                }
            }
        }
    }
}
