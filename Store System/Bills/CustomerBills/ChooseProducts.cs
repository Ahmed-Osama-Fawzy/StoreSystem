using Store_System.AppClasses;
using Store_System.AppClasses.Bills;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_System.Bills.CustomerBills
{
    public partial class ChooseProducts : Form
    {
        public ChooseProducts()
        {
            InitializeComponent();
        }
        int UserId , CustomerId , BillId;
        float ProductPrice;
        Product product = new Product();
        private void ProductName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = product.GetProducts(ProductName.Text);
            Products.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Products.Items.Add(dr["Name"]);
            }
        }
        public ChooseProducts(int CI , int UI , int BI)
        {
            InitializeComponent();
            UserId = UI;
            CustomerId = CI;
            BillId = BI;
        }
        private void InsertProduct_Click(object sender, EventArgs e)
        {
            string SProductName = Products.Text;
            string SProductAmount = ProductAmount.Text;
            if(!string.IsNullOrEmpty(SProductName) 
                && !string.IsNullOrEmpty(SProductAmount))
            {
                product.Name = SProductName;
                float Amount = float.Parse(SProductAmount);
                if(Amount > 100)
                {
                    ProductPrice = product.ReturnPriceFS();
                }
                else
                {
                    ProductPrice = product.ReturnPriceFO();
                }
                
            }
            else
            {
                MessageBox.Show("عفوا يجب اكمال البيانات اولا");
            }
        }
    }
}
