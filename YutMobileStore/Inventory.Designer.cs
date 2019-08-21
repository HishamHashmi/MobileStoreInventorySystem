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
            this.Categories = new System.Windows.Forms.ComboBox();
            this.inventoryTitle = new System.Windows.Forms.Label();
            this.inventorydetails = new System.Windows.Forms.DataGridView();
            this.LogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydetails)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories
            // 
            this.Categories.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(521, 162);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(368, 31);
            this.Categories.TabIndex = 0;
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
            // inventorydetails
            // 
            this.inventorydetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorydetails.Location = new System.Drawing.Point(347, 226);
            this.inventorydetails.Name = "inventorydetails";
            this.inventorydetails.Size = new System.Drawing.Size(693, 418);
            this.inventorydetails.TabIndex = 2;
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.inventorydetails);
            this.Controls.Add(this.inventoryTitle);
            this.Controls.Add(this.Categories);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.inventorydetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Categories;
        private System.Windows.Forms.Label inventoryTitle;
        private System.Windows.Forms.DataGridView inventorydetails;
        private System.Windows.Forms.Button LogOut;
    }
}