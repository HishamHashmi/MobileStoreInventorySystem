namespace YutMobileStore
{
    partial class Sales
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
            this.LabelSales = new System.Windows.Forms.Label();
            this.PanelSales = new System.Windows.Forms.Panel();
            this.InvoiceBtn = new System.Windows.Forms.Button();
            this.TextDate = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PanelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSales
            // 
            this.LabelSales.AutoSize = true;
            this.LabelSales.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSales.ForeColor = System.Drawing.Color.Black;
            this.LabelSales.Location = new System.Drawing.Point(616, 68);
            this.LabelSales.Name = "LabelSales";
            this.LabelSales.Size = new System.Drawing.Size(131, 59);
            this.LabelSales.TabIndex = 12;
            this.LabelSales.Text = "Sales";
            // 
            // PanelSales
            // 
            this.PanelSales.BackColor = System.Drawing.Color.DarkGray;
            this.PanelSales.Controls.Add(this.InvoiceBtn);
            this.PanelSales.Controls.Add(this.TextDate);
            this.PanelSales.Controls.Add(this.comboBox1);
            this.PanelSales.Controls.Add(this.SalesGridView);
            this.PanelSales.Controls.Add(this.LabelDate);
            this.PanelSales.Controls.Add(this.LabelEmployee);
            this.PanelSales.Location = new System.Drawing.Point(148, 146);
            this.PanelSales.Name = "PanelSales";
            this.PanelSales.Size = new System.Drawing.Size(1062, 544);
            this.PanelSales.TabIndex = 13;
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.BackColor = System.Drawing.Color.Black;
            this.InvoiceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvoiceBtn.FlatAppearance.BorderSize = 0;
            this.InvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.InvoiceBtn.Location = new System.Drawing.Point(682, 312);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(307, 50);
            this.InvoiceBtn.TabIndex = 15;
            this.InvoiceBtn.Text = "Generate Invoice";
            this.InvoiceBtn.UseVisualStyleBackColor = false;
            // 
            // TextDate
            // 
            this.TextDate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDate.Location = new System.Drawing.Point(681, 250);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(308, 31);
            this.TextDate.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(681, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 31);
            this.comboBox1.TabIndex = 13;
            // 
            // SalesGridView
            // 
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Location = new System.Drawing.Point(34, 49);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.Size = new System.Drawing.Size(623, 467);
            this.SalesGridView.TabIndex = 0;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.Black;
            this.LabelDate.Location = new System.Drawing.Point(676, 209);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(60, 26);
            this.LabelDate.TabIndex = 12;
            this.LabelDate.Text = "Date:";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.ForeColor = System.Drawing.Color.Black;
            this.LabelEmployee.Location = new System.Drawing.Point(676, 122);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(163, 26);
            this.LabelEmployee.TabIndex = 12;
            this.LabelEmployee.Text = "Employee Name:";
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
            this.LogOut.TabIndex = 14;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
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
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.PanelSales);
            this.Controls.Add(this.LabelSales);
            this.Name = "Sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelSales.ResumeLayout(false);
            this.PanelSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSales;
        private System.Windows.Forms.Panel PanelSales;
        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.TextBox TextDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.Button InvoiceBtn;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BackBtn;
    }
}