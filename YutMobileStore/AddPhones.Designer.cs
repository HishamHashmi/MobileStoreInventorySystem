﻿namespace YutMobileStore
{
    partial class AddPhones
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
            this.LabelPhones = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PhoneImage = new System.Windows.Forms.PictureBox();
            this.RadioNewPhone = new System.Windows.Forms.RadioButton();
            this.RadioOldPhone = new System.Windows.Forms.RadioButton();
            this.TextDate = new System.Windows.Forms.TextBox();
            this.TextBarcode = new System.Windows.Forms.TextBox();
            this.TextVendor = new System.Windows.Forms.TextBox();
            this.TextUnits = new System.Windows.Forms.TextBox();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.TextCompany = new System.Windows.Forms.TextBox();
            this.TextModel = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelBarcode = new System.Windows.Forms.Label();
            this.LabelNewPhone = new System.Windows.Forms.Label();
            this.LabelOldPhone = new System.Windows.Forms.Label();
            this.LabelCondition = new System.Windows.Forms.Label();
            this.LabelVendor = new System.Windows.Forms.Label();
            this.LabelUnits = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelModel = new System.Windows.Forms.Label();
            this.Labelbrand = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.TextPath = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPhones
            // 
            this.LabelPhones.AutoSize = true;
            this.LabelPhones.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhones.Location = new System.Drawing.Point(514, 69);
            this.LabelPhones.Name = "LabelPhones";
            this.LabelPhones.Size = new System.Drawing.Size(268, 59);
            this.LabelPhones.TabIndex = 0;
            this.LabelPhones.Text = "Add Phones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.BrowseBtn);
            this.panel1.Controls.Add(this.PhoneImage);
            this.panel1.Controls.Add(this.RadioNewPhone);
            this.panel1.Controls.Add(this.RadioOldPhone);
            this.panel1.Controls.Add(this.TextDate);
            this.panel1.Controls.Add(this.TextBarcode);
            this.panel1.Controls.Add(this.TextPath);
            this.panel1.Controls.Add(this.TextVendor);
            this.panel1.Controls.Add(this.TextUnits);
            this.panel1.Controls.Add(this.TextPrice);
            this.panel1.Controls.Add(this.TextCompany);
            this.panel1.Controls.Add(this.TextModel);
            this.panel1.Controls.Add(this.LabelDate);
            this.panel1.Controls.Add(this.LabelBarcode);
            this.panel1.Controls.Add(this.LabelNewPhone);
            this.panel1.Controls.Add(this.LabelOldPhone);
            this.panel1.Controls.Add(this.LabelCondition);
            this.panel1.Controls.Add(this.LabelVendor);
            this.panel1.Controls.Add(this.LabelUnits);
            this.panel1.Controls.Add(this.LabelPrice);
            this.panel1.Controls.Add(this.LabelModel);
            this.panel1.Controls.Add(this.Labelbrand);
            this.panel1.Location = new System.Drawing.Point(250, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 514);
            this.panel1.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(80, 418);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(300, 40);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.BackColor = System.Drawing.Color.Black;
            this.BrowseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBtn.FlatAppearance.BorderSize = 0;
            this.BrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBtn.ForeColor = System.Drawing.Color.White;
            this.BrowseBtn.Location = new System.Drawing.Point(489, 296);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(220, 40);
            this.BrowseBtn.TabIndex = 5;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // PhoneImage
            // 
            this.PhoneImage.BackColor = System.Drawing.Color.White;
            this.PhoneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PhoneImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneImage.Location = new System.Drawing.Point(488, 23);
            this.PhoneImage.Name = "PhoneImage";
            this.PhoneImage.Size = new System.Drawing.Size(220, 212);
            this.PhoneImage.TabIndex = 4;
            this.PhoneImage.TabStop = false;
            // 
            // RadioNewPhone
            // 
            this.RadioNewPhone.AutoSize = true;
            this.RadioNewPhone.Location = new System.Drawing.Point(176, 283);
            this.RadioNewPhone.Name = "RadioNewPhone";
            this.RadioNewPhone.Size = new System.Drawing.Size(14, 13);
            this.RadioNewPhone.TabIndex = 3;
            this.RadioNewPhone.TabStop = true;
            this.RadioNewPhone.UseVisualStyleBackColor = true;
            // 
            // RadioOldPhone
            // 
            this.RadioOldPhone.AutoSize = true;
            this.RadioOldPhone.Location = new System.Drawing.Point(119, 283);
            this.RadioOldPhone.Name = "RadioOldPhone";
            this.RadioOldPhone.Size = new System.Drawing.Size(14, 13);
            this.RadioOldPhone.TabIndex = 3;
            this.RadioOldPhone.TabStop = true;
            this.RadioOldPhone.UseVisualStyleBackColor = true;
            // 
            // TextDate
            // 
            this.TextDate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDate.Location = new System.Drawing.Point(488, 452);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(221, 31);
            this.TextDate.TabIndex = 2;
            // 
            // TextBarcode
            // 
            this.TextBarcode.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBarcode.Location = new System.Drawing.Point(488, 383);
            this.TextBarcode.Name = "TextBarcode";
            this.TextBarcode.Size = new System.Drawing.Size(221, 31);
            this.TextBarcode.TabIndex = 2;
            // 
            // TextVendor
            // 
            this.TextVendor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVendor.Location = new System.Drawing.Point(216, 305);
            this.TextVendor.Name = "TextVendor";
            this.TextVendor.Size = new System.Drawing.Size(200, 31);
            this.TextVendor.TabIndex = 2;
            // 
            // TextUnits
            // 
            this.TextUnits.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUnits.Location = new System.Drawing.Point(216, 166);
            this.TextUnits.Name = "TextUnits";
            this.TextUnits.Size = new System.Drawing.Size(200, 31);
            this.TextUnits.TabIndex = 2;
            // 
            // TextPrice
            // 
            this.TextPrice.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrice.Location = new System.Drawing.Point(216, 129);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(200, 31);
            this.TextPrice.TabIndex = 2;
            // 
            // TextCompany
            // 
            this.TextCompany.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCompany.Location = new System.Drawing.Point(216, 55);
            this.TextCompany.Name = "TextCompany";
            this.TextCompany.Size = new System.Drawing.Size(200, 31);
            this.TextCompany.TabIndex = 2;
            // 
            // TextModel
            // 
            this.TextModel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextModel.Location = new System.Drawing.Point(216, 92);
            this.TextModel.Name = "TextModel";
            this.TextModel.Size = new System.Drawing.Size(200, 31);
            this.TextModel.TabIndex = 2;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.Black;
            this.LabelDate.Location = new System.Drawing.Point(485, 426);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(53, 23);
            this.LabelDate.TabIndex = 0;
            this.LabelDate.Text = "Date:";
            // 
            // LabelBarcode
            // 
            this.LabelBarcode.AutoSize = true;
            this.LabelBarcode.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBarcode.ForeColor = System.Drawing.Color.Black;
            this.LabelBarcode.Location = new System.Drawing.Point(484, 357);
            this.LabelBarcode.Name = "LabelBarcode";
            this.LabelBarcode.Size = new System.Drawing.Size(81, 23);
            this.LabelBarcode.TabIndex = 0;
            this.LabelBarcode.Text = "Barcode:";
            // 
            // LabelNewPhone
            // 
            this.LabelNewPhone.AutoSize = true;
            this.LabelNewPhone.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNewPhone.ForeColor = System.Drawing.Color.Black;
            this.LabelNewPhone.Location = new System.Drawing.Point(162, 257);
            this.LabelNewPhone.Name = "LabelNewPhone";
            this.LabelNewPhone.Size = new System.Drawing.Size(48, 23);
            this.LabelNewPhone.TabIndex = 0;
            this.LabelNewPhone.Text = "New";
            // 
            // LabelOldPhone
            // 
            this.LabelOldPhone.AutoSize = true;
            this.LabelOldPhone.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOldPhone.ForeColor = System.Drawing.Color.Black;
            this.LabelOldPhone.Location = new System.Drawing.Point(109, 257);
            this.LabelOldPhone.Name = "LabelOldPhone";
            this.LabelOldPhone.Size = new System.Drawing.Size(38, 23);
            this.LabelOldPhone.TabIndex = 0;
            this.LabelOldPhone.Text = "Old";
            // 
            // LabelCondition
            // 
            this.LabelCondition.AutoSize = true;
            this.LabelCondition.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCondition.ForeColor = System.Drawing.Color.Black;
            this.LabelCondition.Location = new System.Drawing.Point(109, 224);
            this.LabelCondition.Name = "LabelCondition";
            this.LabelCondition.Size = new System.Drawing.Size(90, 23);
            this.LabelCondition.TabIndex = 0;
            this.LabelCondition.Text = "Condition";
            // 
            // LabelVendor
            // 
            this.LabelVendor.AutoSize = true;
            this.LabelVendor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVendor.ForeColor = System.Drawing.Color.Black;
            this.LabelVendor.Location = new System.Drawing.Point(66, 313);
            this.LabelVendor.Name = "LabelVendor";
            this.LabelVendor.Size = new System.Drawing.Size(73, 23);
            this.LabelVendor.TabIndex = 0;
            this.LabelVendor.Text = "Vendor:";
            // 
            // LabelUnits
            // 
            this.LabelUnits.AutoSize = true;
            this.LabelUnits.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUnits.ForeColor = System.Drawing.Color.Black;
            this.LabelUnits.Location = new System.Drawing.Point(66, 177);
            this.LabelUnits.Name = "LabelUnits";
            this.LabelUnits.Size = new System.Drawing.Size(58, 23);
            this.LabelUnits.TabIndex = 0;
            this.LabelUnits.Text = "Units:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Black;
            this.LabelPrice.Location = new System.Drawing.Point(66, 139);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(56, 23);
            this.LabelPrice.TabIndex = 0;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModel.ForeColor = System.Drawing.Color.Black;
            this.LabelModel.Location = new System.Drawing.Point(66, 100);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(67, 23);
            this.LabelModel.TabIndex = 0;
            this.LabelModel.Text = "Model:";
            // 
            // Labelbrand
            // 
            this.Labelbrand.AutoSize = true;
            this.Labelbrand.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelbrand.ForeColor = System.Drawing.Color.Black;
            this.Labelbrand.Location = new System.Drawing.Point(66, 62);
            this.Labelbrand.Name = "Labelbrand";
            this.Labelbrand.Size = new System.Drawing.Size(144, 23);
            this.Labelbrand.TabIndex = 0;
            this.Labelbrand.Text = "Company/Brand:";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Black;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Location = new System.Drawing.Point(1256, 1);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(110, 45);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.DarkRed;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(1140, 1);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(110, 45);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TextPath
            // 
            this.TextPath.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPath.Location = new System.Drawing.Point(488, 249);
            this.TextPath.Name = "TextPath";
            this.TextPath.Size = new System.Drawing.Size(220, 27);
            this.TextPath.TabIndex = 2;
            // 
            // AddPhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelPhones);
            this.Name = "AddPhones";
            this.Text = "Add Phones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPhones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PhoneImage;
        private System.Windows.Forms.RadioButton RadioNewPhone;
        private System.Windows.Forms.RadioButton RadioOldPhone;
        private System.Windows.Forms.TextBox TextBarcode;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.TextBox TextModel;
        private System.Windows.Forms.Label LabelNewPhone;
        private System.Windows.Forms.Label LabelOldPhone;
        private System.Windows.Forms.Label LabelCondition;
        private System.Windows.Forms.Label LabelUnits;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.Label Labelbrand;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.Label LabelBarcode;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox TextDate;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.TextBox TextUnits;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox TextCompany;
        private System.Windows.Forms.TextBox TextVendor;
        private System.Windows.Forms.Label LabelVendor;
        private System.Windows.Forms.TextBox TextPath;
    }
}