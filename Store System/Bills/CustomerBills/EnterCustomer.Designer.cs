namespace Store_System.Bills.CustomerBills
{
    partial class EnterCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterCustomer));
            this.label3 = new System.Windows.Forms.Label();
            this.InsertSupplier = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.TextBox();
            this.CustomersInput = new System.Windows.Forms.TextBox();
            this.Clients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(125, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 177;
            this.label3.Text = "استخراج فاتورة جديدة";
            // 
            // InsertSupplier
            // 
            this.InsertSupplier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InsertSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertSupplier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InsertSupplier.Location = new System.Drawing.Point(127, 445);
            this.InsertSupplier.Name = "InsertSupplier";
            this.InsertSupplier.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.InsertSupplier.Size = new System.Drawing.Size(181, 56);
            this.InsertSupplier.TabIndex = 176;
            this.InsertSupplier.Text = "استخراج الفاتورة";
            this.InsertSupplier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InsertSupplier.UseVisualStyleBackColor = false;
            this.InsertSupplier.Click += new System.EventHandler(this.InsertSupplier_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(46, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 25);
            this.label10.TabIndex = 174;
            this.label10.Text = "العميل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(43, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 173;
            this.label4.Text = "التاريخ";
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date.Location = new System.Drawing.Point(159, 143);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(250, 31);
            this.Date.TabIndex = 172;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 171;
            this.label2.Text = "رقم المستخدم ";
            // 
            // UserID
            // 
            this.UserID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserID.Location = new System.Drawing.Point(159, 80);
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Size = new System.Drawing.Size(250, 31);
            this.UserID.TabIndex = 170;
            // 
            // CustomersInput
            // 
            this.CustomersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersInput.Location = new System.Drawing.Point(159, 194);
            this.CustomersInput.Name = "CustomersInput";
            this.CustomersInput.Size = new System.Drawing.Size(250, 26);
            this.CustomersInput.TabIndex = 179;
            this.CustomersInput.TextChanged += new System.EventHandler(this.CustomersInput_TextChanged);
            // 
            // Clients
            // 
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.FormattingEnabled = true;
            this.Clients.ItemHeight = 25;
            this.Clients.Location = new System.Drawing.Point(159, 235);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(250, 204);
            this.Clients.TabIndex = 178;
            // 
            // EnterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 510);
            this.Controls.Add(this.CustomersInput);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InsertSupplier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استخراج فاتورة جديدة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InsertSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox CustomersInput;
        private System.Windows.Forms.ListBox Clients;
    }
}