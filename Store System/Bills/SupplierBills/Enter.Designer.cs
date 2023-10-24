namespace Store_System.Bills.SupplierBills
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.label6 = new System.Windows.Forms.Label();
            this.ClearData = new System.Windows.Forms.Button();
            this.InsertSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductNetPriceOne = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductNetPriceMuch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductUnit = new System.Windows.Forms.ListBox();
            this.Category = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(43, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 146;
            this.label6.Text = "القسم";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearData.Location = new System.Drawing.Point(306, 333);
            this.ClearData.Name = "ClearData";
            this.ClearData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ClearData.Size = new System.Drawing.Size(181, 56);
            this.ClearData.TabIndex = 145;
            this.ClearData.Text = "افراغ البيانات";
            this.ClearData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClearData.UseVisualStyleBackColor = false;
            // 
            // InsertSupplier
            // 
            this.InsertSupplier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertSupplier.Location = new System.Drawing.Point(64, 333);
            this.InsertSupplier.Name = "InsertSupplier";
            this.InsertSupplier.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InsertSupplier.Size = new System.Drawing.Size(181, 56);
            this.InsertSupplier.TabIndex = 140;
            this.InsertSupplier.Text = " اضافة البيانات";
            this.InsertSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InsertSupplier.UseVisualStyleBackColor = false;
            this.InsertSupplier.Click += new System.EventHandler(this.InsertSupplier_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(292, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "اضافة منتجات فاتورة جديدة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(19, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 156;
            this.label1.Text = "اسم المنتج";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductName.Location = new System.Drawing.Point(148, 124);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(250, 31);
            this.ProductName.TabIndex = 157;
            // 
            // ProductAmount
            // 
            this.ProductAmount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductAmount.Location = new System.Drawing.Point(535, 124);
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Size = new System.Drawing.Size(250, 31);
            this.ProductAmount.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(430, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 158;
            this.label5.Text = "الكمية";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductPrice.Location = new System.Drawing.Point(148, 189);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.ReadOnly = true;
            this.ProductPrice.Size = new System.Drawing.Size(250, 31);
            this.ProductPrice.TabIndex = 161;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(19, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 160;
            this.label7.Text = "سعر الواحدة";
            // 
            // ProductNetPriceOne
            // 
            this.ProductNetPriceOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductNetPriceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNetPriceOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductNetPriceOne.Location = new System.Drawing.Point(591, 189);
            this.ProductNetPriceOne.Name = "ProductNetPriceOne";
            this.ProductNetPriceOne.ReadOnly = true;
            this.ProductNetPriceOne.Size = new System.Drawing.Size(192, 31);
            this.ProductNetPriceOne.TabIndex = 163;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(404, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 162;
            this.label8.Text = "مكسب الواحدة قطاعي";
            // 
            // ProductNetPriceMuch
            // 
            this.ProductNetPriceMuch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductNetPriceMuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNetPriceMuch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductNetPriceMuch.Location = new System.Drawing.Point(591, 246);
            this.ProductNetPriceMuch.Name = "ProductNetPriceMuch";
            this.ProductNetPriceMuch.ReadOnly = true;
            this.ProductNetPriceMuch.Size = new System.Drawing.Size(192, 31);
            this.ProductNetPriceMuch.TabIndex = 165;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(404, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 164;
            this.label9.Text = "مكسب الواحدة جملة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(19, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 166;
            this.label11.Text = "وحدة القياس";
            // 
            // ProductUnit
            // 
            this.ProductUnit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProductUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductUnit.FormattingEnabled = true;
            this.ProductUnit.ItemHeight = 25;
            this.ProductUnit.Location = new System.Drawing.Point(148, 245);
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.Size = new System.Drawing.Size(250, 29);
            this.ProductUnit.TabIndex = 167;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Category.FormattingEnabled = true;
            this.Category.ItemHeight = 25;
            this.Category.Location = new System.Drawing.Point(148, 72);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(250, 29);
            this.Category.TabIndex = 147;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(797, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 154;
            this.label12.Text = "المورد";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(907, 453);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(250, 29);
            this.listBox2.TabIndex = 155;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(549, 333);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.button1.Size = new System.Drawing.Size(181, 56);
            this.button1.TabIndex = 168;
            this.button1.Text = "انهاء الفاتورة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ProductNetPriceMuch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProductNetPriceOne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.InsertSupplier);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Enter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ادخل فاتورة مشتريات";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.Button InsertSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox ProductAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductNetPriceOne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductNetPriceMuch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox ProductUnit;
        private System.Windows.Forms.ListBox Category;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}