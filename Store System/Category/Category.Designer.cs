namespace Store_System.Category
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.AddCategory = new System.Windows.Forms.Button();
            this.UpdateCategory = new System.Windows.Forms.Button();
            this.RemoveCategory = new System.Windows.Forms.Button();
            this.ShowCategories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.RetrivedData = new System.Windows.Forms.DataGridView();
            this.NCategorySearch = new System.Windows.Forms.TextBox();
            this.UpdateSearch = new System.Windows.Forms.Button();
            this.RemoveSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RetrivedData)).BeginInit();
            this.SuspendLayout();
            // 
            // AddCategory
            // 
            this.AddCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddCategory.Location = new System.Drawing.Point(12, 22);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.AddCategory.Size = new System.Drawing.Size(184, 49);
            this.AddCategory.TabIndex = 69;
            this.AddCategory.Text = "اضافة قسم";
            this.AddCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddCategory.UseVisualStyleBackColor = false;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // UpdateCategory
            // 
            this.UpdateCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateCategory.Location = new System.Drawing.Point(202, 22);
            this.UpdateCategory.Name = "UpdateCategory";
            this.UpdateCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.UpdateCategory.Size = new System.Drawing.Size(184, 49);
            this.UpdateCategory.TabIndex = 70;
            this.UpdateCategory.Text = "تحديث بيانات قسم";
            this.UpdateCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateCategory.UseVisualStyleBackColor = false;
            this.UpdateCategory.Click += new System.EventHandler(this.UpdateCategory_Click);
            // 
            // RemoveCategory
            // 
            this.RemoveCategory.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCategory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveCategory.Location = new System.Drawing.Point(392, 22);
            this.RemoveCategory.Name = "RemoveCategory";
            this.RemoveCategory.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.RemoveCategory.Size = new System.Drawing.Size(184, 49);
            this.RemoveCategory.TabIndex = 71;
            this.RemoveCategory.Text = "حذف بيانات قسم";
            this.RemoveCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveCategory.UseVisualStyleBackColor = false;
            this.RemoveCategory.Click += new System.EventHandler(this.RemoveCategory_Click);
            // 
            // ShowCategories
            // 
            this.ShowCategories.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ShowCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCategories.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowCategories.Location = new System.Drawing.Point(582, 22);
            this.ShowCategories.Name = "ShowCategories";
            this.ShowCategories.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ShowCategories.Size = new System.Drawing.Size(184, 49);
            this.ShowCategories.TabIndex = 72;
            this.ShowCategories.Text = "عرض بيانات الاقسام";
            this.ShowCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ShowCategories.UseVisualStyleBackColor = false;
            this.ShowCategories.Click += new System.EventHandler(this.ShowCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "ابحث عن قسم";
            // 
            // CategoryName
            // 
            this.CategoryName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryName.Location = new System.Drawing.Point(159, 97);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(295, 31);
            this.CategoryName.TabIndex = 73;
            this.CategoryName.TextChanged += new System.EventHandler(this.CategoryName_TextChanged);
            // 
            // RetrivedData
            // 
            this.RetrivedData.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.RetrivedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RetrivedData.Location = new System.Drawing.Point(12, 143);
            this.RetrivedData.Name = "RetrivedData";
            this.RetrivedData.Size = new System.Drawing.Size(625, 211);
            this.RetrivedData.TabIndex = 75;
            this.RetrivedData.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RetrivedData_RowHeaderMouseClick);
            // 
            // NCategorySearch
            // 
            this.NCategorySearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCategorySearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NCategorySearch.Location = new System.Drawing.Point(471, 97);
            this.NCategorySearch.Name = "NCategorySearch";
            this.NCategorySearch.ReadOnly = true;
            this.NCategorySearch.Size = new System.Drawing.Size(105, 31);
            this.NCategorySearch.TabIndex = 76;
            // 
            // UpdateSearch
            // 
            this.UpdateSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateSearch.Location = new System.Drawing.Point(643, 180);
            this.UpdateSearch.Name = "UpdateSearch";
            this.UpdateSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.UpdateSearch.Size = new System.Drawing.Size(123, 49);
            this.UpdateSearch.TabIndex = 77;
            this.UpdateSearch.Text = "تحديث بيانات";
            this.UpdateSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateSearch.UseVisualStyleBackColor = false;
            this.UpdateSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveSearch
            // 
            this.RemoveSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RemoveSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveSearch.Location = new System.Drawing.Point(643, 256);
            this.RemoveSearch.Name = "RemoveSearch";
            this.RemoveSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.RemoveSearch.Size = new System.Drawing.Size(123, 49);
            this.RemoveSearch.TabIndex = 78;
            this.RemoveSearch.Text = "حذف بيانات";
            this.RemoveSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveSearch.UseVisualStyleBackColor = false;
            this.RemoveSearch.Click += new System.EventHandler(this.RemoveSearch_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 366);
            this.Controls.Add(this.RemoveSearch);
            this.Controls.Add(this.UpdateSearch);
            this.Controls.Add(this.NCategorySearch);
            this.Controls.Add(this.RetrivedData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.ShowCategories);
            this.Controls.Add(this.RemoveCategory);
            this.Controls.Add(this.UpdateCategory);
            this.Controls.Add(this.AddCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الاقسام";
            ((System.ComponentModel.ISupportInitialize)(this.RetrivedData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button UpdateCategory;
        private System.Windows.Forms.Button RemoveCategory;
        private System.Windows.Forms.Button ShowCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.DataGridView RetrivedData;
        private System.Windows.Forms.TextBox NCategorySearch;
        private System.Windows.Forms.Button UpdateSearch;
        private System.Windows.Forms.Button RemoveSearch;
    }
}