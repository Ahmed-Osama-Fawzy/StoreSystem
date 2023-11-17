namespace Store_System.Bills.CustomerBills
{
    partial class ChooseProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseProducts));
            this.Products = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertProduct = new System.Windows.Forms.Button();
            this.ModifyProduct = new System.Windows.Forms.Button();
            this.RemoveProduct = new System.Windows.Forms.Button();
            this.FinishBill = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BillData)).BeginInit();
            this.SuspendLayout();
            // 
            // Products
            // 
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.FormattingEnabled = true;
            this.Products.ItemHeight = 25;
            this.Products.Location = new System.Drawing.Point(366, 24);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(409, 104);
            this.Products.TabIndex = 181;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 183;
            this.label4.Text = "اسم المنتج";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductName.Location = new System.Drawing.Point(110, 34);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(250, 31);
            this.ProductName.TabIndex = 184;
            this.ProductName.TextChanged += new System.EventHandler(this.ProductName_TextChanged);
            // 
            // ProductAmount
            // 
            this.ProductAmount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductAmount.Location = new System.Drawing.Point(110, 88);
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Size = new System.Drawing.Size(250, 31);
            this.ProductAmount.TabIndex = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 186;
            this.label1.Text = "العدد";
            // 
            // InsertProduct
            // 
            this.InsertProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertProduct.Location = new System.Drawing.Point(17, 146);
            this.InsertProduct.Name = "InsertProduct";
            this.InsertProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InsertProduct.Size = new System.Drawing.Size(181, 56);
            this.InsertProduct.TabIndex = 188;
            this.InsertProduct.Text = "اضافة المنتج";
            this.InsertProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InsertProduct.UseVisualStyleBackColor = false;
            this.InsertProduct.Click += new System.EventHandler(this.InsertProduct_Click);
            // 
            // ModifyProduct
            // 
            this.ModifyProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ModifyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModifyProduct.Location = new System.Drawing.Point(204, 146);
            this.ModifyProduct.Name = "ModifyProduct";
            this.ModifyProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ModifyProduct.Size = new System.Drawing.Size(181, 56);
            this.ModifyProduct.TabIndex = 189;
            this.ModifyProduct.Text = "تعديل المنتج";
            this.ModifyProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ModifyProduct.UseVisualStyleBackColor = false;
            // 
            // RemoveProduct
            // 
            this.RemoveProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveProduct.Location = new System.Drawing.Point(407, 146);
            this.RemoveProduct.Name = "RemoveProduct";
            this.RemoveProduct.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.RemoveProduct.Size = new System.Drawing.Size(181, 56);
            this.RemoveProduct.TabIndex = 190;
            this.RemoveProduct.Text = "حذف المنتج";
            this.RemoveProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveProduct.UseVisualStyleBackColor = false;
            // 
            // FinishBill
            // 
            this.FinishBill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.FinishBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FinishBill.Location = new System.Drawing.Point(594, 146);
            this.FinishBill.Name = "FinishBill";
            this.FinishBill.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.FinishBill.Size = new System.Drawing.Size(181, 56);
            this.FinishBill.TabIndex = 191;
            this.FinishBill.Text = "انهاء الفاتورة";
            this.FinishBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FinishBill.UseVisualStyleBackColor = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TotalPrice.Location = new System.Drawing.Point(135, 524);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Size = new System.Drawing.Size(250, 31);
            this.TotalPrice.TabIndex = 193;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 192;
            this.label2.Text = "اجمال السعر";
            // 
            // ProductsNumber
            // 
            this.ProductsNumber.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductsNumber.Location = new System.Drawing.Point(525, 524);
            this.ProductsNumber.Name = "ProductsNumber";
            this.ProductsNumber.ReadOnly = true;
            this.ProductsNumber.Size = new System.Drawing.Size(250, 31);
            this.ProductsNumber.TabIndex = 195;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(402, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 194;
            this.label3.Text = "عدد المنتجات";
            // 
            // BillData
            // 
            this.BillData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillData.Location = new System.Drawing.Point(17, 208);
            this.BillData.Name = "BillData";
            this.BillData.Size = new System.Drawing.Size(758, 307);
            this.BillData.TabIndex = 187;
            // 
            // ChooseProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 562);
            this.Controls.Add(this.ProductsNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinishBill);
            this.Controls.Add(this.RemoveProduct);
            this.Controls.Add(this.ModifyProduct);
            this.Controls.Add(this.InsertProduct);
            this.Controls.Add(this.BillData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductAmount);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseProducts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اختيار منتجات الفاتورة";
            ((System.ComponentModel.ISupportInitialize)(this.BillData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertProduct;
        private System.Windows.Forms.Button ModifyProduct;
        private System.Windows.Forms.Button RemoveProduct;
        private System.Windows.Forms.Button FinishBill;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductsNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView BillData;
    }
}