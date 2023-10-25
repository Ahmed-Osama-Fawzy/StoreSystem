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
using Workshop_System.App_Class;

namespace Store_System.Bills.SupplierBills
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
        }
        public int supplierid;
        public int billid;
        public Enter(int SI , int BI)
        {
            InitializeComponent();
            supplierid = SI;
            billid = BI;
            DataBase DB = new DataBase("dbo", "Category");
            DataTable dt = DB.Select("Name");
            CategoryName.DisplayMember = "Name";
            CategoryName.ValueMember = "Name";
            if (dt.Rows.Count > 0)
            {
                CategoryName.DataSource = dt; CategoryName.Enabled = true;
            }
            else
                CategoryName.Enabled = false;
        }
        private void InsertSupplier_Click(object sender, EventArgs e)
        {
            string SCategory = CategoryName.Text;
            AppClasses.Category category = new AppClasses.Category();
            int CategoryId = category.ReturnID(SCategory);
            string Name = ProductName.Text;
            string Amount = ProductAmount.Text;
            string Price = ProductPrice.Text;
            string Unit = ProductUnit.Text;
            string One = ProductNetPriceOne.Text;
            string Many = ProductNetPriceMany.Text;
            if(!string.IsNullOrEmpty(Name) 
                && !string.IsNullOrEmpty(Amount)
                && !string.IsNullOrEmpty(Price)
                && !string.IsNullOrEmpty(Unit)
                && !string.IsNullOrEmpty(One)
                && !string.IsNullOrEmpty(Many)) 
            {
                Product product = new Product();
                product.Name = Name;
                product.Amount = float.Parse(Amount);
                product.MainPrice = float.Parse(Price);
                product.Unit = Unit;
                product.OneProfit = float.Parse(One);
                product.ManyProfit = float.Parse(Many);
                product.CategoryID = CategoryId;
                int ID = product.ReturnID();
                if (ID == -1)
                {
                    if (product.Insert())
                    {
                        SupplierBill supplierBill = new SupplierBill();
                        supplierBill.BillID = billid;
                        supplierBill.SupplierID = supplierid;
                        supplierBill.ProductID = product.ReturnID();
                        supplierBill.Amount = product.Amount;
                        supplierBill.Price = product.MainPrice;
                        if (supplierBill.Insert())
                        {
                            if (category.PlusOne())
                            {
                                MessageBox.Show("تم الاضافة بنجاح");
                                CategoryName.SelectedItem = null;
                                ProductName.Text = string.Empty;
                                ProductAmount.Text = string.Empty;
                                ProductPrice.Text = string.Empty;
                                ProductUnit.Text = string.Empty;
                                ProductNetPriceOne.Text = string.Empty;
                                ProductNetPriceMany.Text = string.Empty;
                            }
                        }
                    }
                }
                else
                {
                    if (product.Increse(product.Amount,"Amount",' ') 
                        && product.Increse(product.MainPrice,"MainPrice",'=')
                        && product.Increse(product.OneProfit, "OneProfit",'=')
                        && product.Increse(product.ManyProfit, "ManyProfit",'='))
                    {
                        MessageBox.Show("تم الاضافة بنجاح");
                        CategoryName.SelectedItem = null;
                        ProductName.Text = string.Empty;
                        ProductAmount.Text = string.Empty;
                        ProductPrice.Text = string.Empty;
                        ProductUnit.Text = string.Empty;
                        ProductNetPriceOne.Text = string.Empty;
                        ProductNetPriceMany.Text = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("عفوا يجب ادخال البيانات كاملة");
            }
        }
        private void ClearData_Click(object sender, EventArgs e)
        {
            CategoryName.SelectedItem = null;
            ProductName.Text = string.Empty;
            ProductAmount.Text = string.Empty;
            ProductPrice.Text = string.Empty;
            ProductUnit.Text = string.Empty;
            ProductNetPriceOne.Text = string.Empty;
            ProductNetPriceMany.Text = string.Empty;
        }
    }
}
