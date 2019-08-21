namespace YutMobileStore
{
    partial class Ledger
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
            this.LabelLedger = new System.Windows.Forms.Label();
            this.PanelLedger = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.TextDate = new System.Windows.Forms.TextBox();
            this.TextVoucher = new System.Windows.Forms.TextBox();
            this.TransactionLogGridView = new System.Windows.Forms.DataGridView();
            this.ProductListGridView = new System.Windows.Forms.DataGridView();
            this.ComboVendor = new System.Windows.Forms.ComboBox();
            this.LabelTransactionLog = new System.Windows.Forms.Label();
            this.LabelProductList = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelVoucher = new System.Windows.Forms.Label();
            this.LabelVendor = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PanelLedger.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLogGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLedger
            // 
            this.LabelLedger.AutoSize = true;
            this.LabelLedger.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLedger.Location = new System.Drawing.Point(511, 69);
            this.LabelLedger.Name = "LabelLedger";
            this.LabelLedger.Size = new System.Drawing.Size(169, 59);
            this.LabelLedger.TabIndex = 3;
            this.LabelLedger.Text = "Ledger";
            // 
            // PanelLedger
            // 
            this.PanelLedger.BackColor = System.Drawing.Color.DarkGray;
            this.PanelLedger.Controls.Add(this.panel1);
            this.PanelLedger.Controls.Add(this.AddBtn);
            this.PanelLedger.Controls.Add(this.TextDate);
            this.PanelLedger.Controls.Add(this.TextVoucher);
            this.PanelLedger.Controls.Add(this.TransactionLogGridView);
            this.PanelLedger.Controls.Add(this.ProductListGridView);
            this.PanelLedger.Controls.Add(this.ComboVendor);
            this.PanelLedger.Controls.Add(this.LabelTransactionLog);
            this.PanelLedger.Controls.Add(this.LabelProductList);
            this.PanelLedger.Controls.Add(this.LabelDate);
            this.PanelLedger.Controls.Add(this.LabelVoucher);
            this.PanelLedger.Controls.Add(this.LabelVendor);
            this.PanelLedger.Location = new System.Drawing.Point(128, 157);
            this.PanelLedger.Name = "PanelLedger";
            this.PanelLedger.Size = new System.Drawing.Size(1035, 532);
            this.PanelLedger.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LabelTotal);
            this.panel1.Location = new System.Drawing.Point(465, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 58);
            this.panel1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 37);
            this.textBox1.TabIndex = 1;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(60, 17);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(65, 29);
            this.LabelTotal.TabIndex = 0;
            this.LabelTotal.Text = "Total";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(63, 447);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(353, 48);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // TextDate
            // 
            this.TextDate.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDate.Location = new System.Drawing.Point(465, 464);
            this.TextDate.Name = "TextDate";
            this.TextDate.Size = new System.Drawing.Size(223, 31);
            this.TextDate.TabIndex = 3;
            // 
            // TextVoucher
            // 
            this.TextVoucher.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVoucher.Location = new System.Drawing.Point(63, 410);
            this.TextVoucher.Name = "TextVoucher";
            this.TextVoucher.Size = new System.Drawing.Size(353, 31);
            this.TextVoucher.TabIndex = 3;
            // 
            // TransactionLogGridView
            // 
            this.TransactionLogGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionLogGridView.Location = new System.Drawing.Point(465, 65);
            this.TransactionLogGridView.Name = "TransactionLogGridView";
            this.TransactionLogGridView.Size = new System.Drawing.Size(500, 302);
            this.TransactionLogGridView.TabIndex = 2;
            // 
            // ProductListGridView
            // 
            this.ProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListGridView.Location = new System.Drawing.Point(63, 113);
            this.ProductListGridView.Name = "ProductListGridView";
            this.ProductListGridView.Size = new System.Drawing.Size(353, 254);
            this.ProductListGridView.TabIndex = 2;
            // 
            // ComboVendor
            // 
            this.ComboVendor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboVendor.FormattingEnabled = true;
            this.ComboVendor.Location = new System.Drawing.Point(219, 31);
            this.ComboVendor.Name = "ComboVendor";
            this.ComboVendor.Size = new System.Drawing.Size(197, 31);
            this.ComboVendor.TabIndex = 1;
            // 
            // LabelTransactionLog
            // 
            this.LabelTransactionLog.AutoSize = true;
            this.LabelTransactionLog.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTransactionLog.Location = new System.Drawing.Point(665, 31);
            this.LabelTransactionLog.Name = "LabelTransactionLog";
            this.LabelTransactionLog.Size = new System.Drawing.Size(142, 23);
            this.LabelTransactionLog.TabIndex = 0;
            this.LabelTransactionLog.Text = "Transaction Log:";
            // 
            // LabelProductList
            // 
            this.LabelProductList.AutoSize = true;
            this.LabelProductList.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductList.Location = new System.Drawing.Point(58, 78);
            this.LabelProductList.Name = "LabelProductList";
            this.LabelProductList.Size = new System.Drawing.Size(112, 23);
            this.LabelProductList.TabIndex = 0;
            this.LabelProductList.Text = "Product List:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(460, 435);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(60, 26);
            this.LabelDate.TabIndex = 0;
            this.LabelDate.Text = "Date:";
            // 
            // LabelVoucher
            // 
            this.LabelVoucher.AutoSize = true;
            this.LabelVoucher.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVoucher.Location = new System.Drawing.Point(58, 379);
            this.LabelVoucher.Name = "LabelVoucher";
            this.LabelVoucher.Size = new System.Drawing.Size(91, 26);
            this.LabelVoucher.TabIndex = 0;
            this.LabelVoucher.Text = "Voucher:";
            // 
            // LabelVendor
            // 
            this.LabelVendor.AutoSize = true;
            this.LabelVendor.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVendor.Location = new System.Drawing.Point(57, 36);
            this.LabelVendor.Name = "LabelVendor";
            this.LabelVendor.Size = new System.Drawing.Size(140, 26);
            this.LabelVendor.TabIndex = 0;
            this.LabelVendor.Text = "Vendor Name:";
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
            this.LogOut.TabIndex = 5;
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
            // Ledger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.PanelLedger);
            this.Controls.Add(this.LabelLedger);
            this.Name = "Ledger";
            this.Text = "Ledger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelLedger.ResumeLayout(false);
            this.PanelLedger.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLogGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLedger;
        private System.Windows.Forms.Panel PanelLedger;
        private System.Windows.Forms.TextBox TextVoucher;
        private System.Windows.Forms.DataGridView ProductListGridView;
        private System.Windows.Forms.ComboBox ComboVendor;
        private System.Windows.Forms.Label LabelProductList;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelVendor;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TransactionLogGridView;
        private System.Windows.Forms.Label LabelTransactionLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextDate;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelVoucher;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BackBtn;
    }
}