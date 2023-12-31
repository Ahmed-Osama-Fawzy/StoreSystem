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
    public partial class Category : Form
    {
        String UserID;
        String TheDate = DateTime.Now.ToString();
        public Category(String UI)
        {
            InitializeComponent();
            UserID = UI;
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            Add NewForm = new Add(UserID,TheDate);
            NewForm.ShowDialog();
        }

        private void UpdateCategory_Click(object sender, EventArgs e)
        {
            Modify NewForm = new Modify(UserID, TheDate);
            NewForm.ShowDialog();
        }

        private void RemoveCategory_Click(object sender, EventArgs e)
        {
            Remove NewForm = new Remove(UserID, TheDate);
            NewForm.ShowDialog();
        }

        private void ShowCategories_Click(object sender, EventArgs e)
        {
            ShowCategories NewForm = new ShowCategories();
            NewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CatID = NCategorySearch.Text;
            Modify NewForm = new Modify(UserID, TheDate,CatID);
            NewForm.ShowDialog();
        }

        private void RemoveSearch_Click(object sender, EventArgs e)
        {
            string CatID = NCategorySearch.Text;
            Remove NewForm = new Remove(UserID, TheDate, CatID);
            NewForm.ShowDialog();
        }

        private void CategoryName_TextChanged(object sender, EventArgs e)
        {
            AppClasses.Category category = new AppClasses.Category();
            string S = CategoryName.Text.ToString();
            if (!string.IsNullOrEmpty(S))
            {
                DataTable dt = category.Search(S);
                dt.Columns["Name"].ColumnName = "اقسم القسم";
                dt.Columns["ProductsAmount"].ColumnName = "عدد المنتجات";
                dt.Columns["CreaterID"].ColumnName = "الرقم التعريفي للمستخدم";
                dt.Columns["CreatedDate"].ColumnName = "تاريخ الاضافة";
                RetrivedData.DataSource = dt;
            }
        }

        private void RetrivedData_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            string SelectedId = RetrivedData.Rows[index].Cells[1].Value.ToString();
            NCategorySearch.Text = SelectedId;
        }
    }
}
