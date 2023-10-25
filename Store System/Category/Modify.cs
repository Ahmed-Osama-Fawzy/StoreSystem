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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }
        public Modify(string U)
        {
            InitializeComponent();
            UserID.Text = U;
            Date.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OldName = CategoryOldName.Text;
            string NewName = CategoryNewName.Text;
            AppClasses.Category category = new AppClasses.Category();
            if(!string.IsNullOrEmpty(OldName) && !string.IsNullOrEmpty(NewName))
            {
                category.Name = OldName;
                if (category.Update(NewName))
                {
                    MessageBox.Show("تم تحديث البيانات بنجاح ");
                    CategoryOldName.Text = string.Empty;
                    CategoryNewName.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("عفوا حدث خطا ما");
                }
            }
        }
    }
}
