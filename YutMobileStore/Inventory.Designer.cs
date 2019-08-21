namespace YutMobileStore
{
    partial class Inventory
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
            this.inventoryTitle = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.PanelInventory = new System.Windows.Forms.Panel();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.inventorydetails = new System.Windows.Forms.DataGridView();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PanelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydetails)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryTitle
            // 
            this.inventoryTitle.AutoSize = true;
            this.inventoryTitle.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTitle.Location = new System.Drawing.Point(514, 69);
            this.inventoryTitle.Name = "inventoryTitle";
            this.inventoryTitle.Size = new System.Drawing.Size(375, 59);
            this.inventoryTitle.TabIndex = 1;
            this.inventoryTitle.Text = "Inventory Details";
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
            // 
            // PanelInventory
            // 
            this.PanelInventory.BackColor = System.Drawing.Color.DarkGray;
            this.PanelInventory.Controls.Add(this.LabelCategory);
            this.PanelInventory.Controls.Add(this.inventorydetails);
            this.PanelInventory.Controls.Add(this.Categories);
            this.PanelInventory.Location = new System.Drawing.Point(216, 147);
            this.PanelInventory.Name = "PanelInventory";
            this.PanelInventory.Size = new System.Drawing.Size(964, 551);
            this.PanelInventory.TabIndex = 4;
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCategory.Location = new System.Drawing.Point(129, 24);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(160, 26);
            this.LabelCategory.TabIndex = 5;
            this.LabelCategory.Text = "Select Category:";
            // 
            // inventorydetails
            // 
            this.inventorydetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorydetails.Location = new System.Drawing.Point(134, 111);
            this.inventorydetails.Name = "inventorydetails";
            this.inventorydetails.Size = new System.Drawing.Size(693, 418);
            this.inventorydetails.TabIndex = 4;
            // 
            // Categories
            // 
            this.Categories.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(134, 64);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(693, 31);
            this.Categories.TabIndex = 3;
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
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PanelInventory);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.inventoryTitle);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelInventory.ResumeLayout(false);
            this.PanelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inventoryTitle;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel PanelInventory;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.DataGridView inventorydetails;
        private System.Windows.Forms.ComboBox Categories;
        private System.Windows.Forms.Button BackBtn;
    }
}