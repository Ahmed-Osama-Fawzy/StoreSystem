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
    public partial class ShowCategories : Form
    {
        public ShowCategories()
        {
            InitializeComponent();
            AppClasses.Category category = new AppClasses.Category();
            Categories.DataSource = category.SelectAll();
        }

        private void ShowFull_Load(object sender, EventArgs e)
        {

        }
    }
}
