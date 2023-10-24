namespace Store_System.Supplier
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.AccountType = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SupplierAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.InsertSupplier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SupplierPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SupplierWhatsapp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SupplierCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountType
            // 
            this.AccountType.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccountType.FormattingEnabled = true;
            this.AccountType.ItemHeight = 25;
            this.AccountType.Items.AddRange(new object[] {
            "شركة",
            "مصنع",
            "محل",
            "موزع"});
            this.AccountType.Location = new System.Drawing.Point(164, 429);
            this.AccountType.Name = "AccountType";
            this.AccountType.Size = new System.Drawing.Size(250, 29);
            this.AccountType.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(41, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 108;
            this.label6.Text = "نوع المورد";
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearData.Location = new System.Drawing.Point(234, 484);
            this.ClearData.Name = "ClearData";
            this.ClearData.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.ClearData.Size = new System.Drawing.Size(181, 56);
            this.ClearData.TabIndex = 107;
            this.ClearData.Text = "افراغ البيانات";
            this.ClearData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClearData.UseVisualStyleBackColor = false;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(40, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 106;
            this.label5.Text = "العنوان";
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierAddress.Location = new System.Drawing.Point(164, 217);
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.Size = new System.Drawing.Size(250, 31);
            this.SupplierAddress.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(33, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 104;
            this.label4.Text = "التاريخ";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date.Location = new System.Drawing.Point(164, 115);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(250, 31);
            this.Date.TabIndex = 103;
            // 
            // InsertSupplier
            // 
            this.InsertSupplier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertSupplier.Location = new System.Drawing.Point(23, 484);
            this.InsertSupplier.Name = "InsertSupplier";
            this.InsertSupplier.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InsertSupplier.Size = new System.Drawing.Size(181, 56);
            this.InsertSupplier.TabIndex = 102;
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
            this.label3.Location = new System.Drawing.Point(140, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 101;
            this.label3.Text = "اضافة مستخدم جديد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 100;
            this.label2.Text = "رقم المستخدم ";
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserID.Location = new System.Drawing.Point(164, 67);
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Size = new System.Drawing.Size(250, 31);
            this.UserID.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(33, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "اسم المورد";
            // 
            // SupplierName
            // 
            this.SupplierName.AcceptsReturn = true;
            this.SupplierName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierName.Location = new System.Drawing.Point(164, 166);
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(250, 31);
            this.SupplierName.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 111;
            this.label7.Text = "رقم الهاتف";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierPhone.Location = new System.Drawing.Point(165, 272);
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.Size = new System.Drawing.Size(250, 31);
            this.SupplierPhone.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(18, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 113;
            this.label8.Text = "رقم الواتس";
            // 
            // SupplierWhatsapp
            // 
            this.SupplierWhatsapp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierWhatsapp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierWhatsapp.Location = new System.Drawing.Point(165, 331);
            this.SupplierWhatsapp.Name = "SupplierWhatsapp";
            this.SupplierWhatsapp.Size = new System.Drawing.Size(250, 31);
            this.SupplierWhatsapp.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(33, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 115;
            this.label9.Text = "المدينة";
            // 
            // SupplierCity
            // 
            this.SupplierCity.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SupplierCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupplierCity.Location = new System.Drawing.Point(165, 379);
            this.SupplierCity.Name = "SupplierCity";
            this.SupplierCity.Size = new System.Drawing.Size(250, 31);
            this.SupplierCity.TabIndex = 114;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 552);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SupplierCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SupplierWhatsapp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SupplierPhone);
            this.Controls.Add(this.AccountType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SupplierAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.InsertSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "اضافة مورد جديد";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AccountType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SupplierAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Button InsertSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SupplierPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SupplierWhatsapp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SupplierCity;
    }
}