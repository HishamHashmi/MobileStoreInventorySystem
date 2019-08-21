namespace YutMobileStore
{
    partial class Stocks
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
            this.LabelStock = new System.Windows.Forms.Label();
            this.PanelStock = new System.Windows.Forms.Panel();
            this.ComboSearch = new System.Windows.Forms.ComboBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.StockGridView = new System.Windows.Forms.DataGridView();
            this.LogOut = new System.Windows.Forms.Button();
            this.PanelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStock.ForeColor = System.Drawing.Color.Black;
            this.LabelStock.Location = new System.Drawing.Point(578, 68);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(230, 59);
            this.LabelStock.TabIndex = 12;
            this.LabelStock.Text = "Edit Stock";
            // 
            // PanelStock
            // 
            this.PanelStock.BackColor = System.Drawing.Color.DarkGray;
            this.PanelStock.Controls.Add(this.StockGridView);
            this.PanelStock.Controls.Add(this.ComboSearch);
            this.PanelStock.Controls.Add(this.LabelSearch);
            this.PanelStock.Location = new System.Drawing.Point(181, 152);
            this.PanelStock.Name = "PanelStock";
            this.PanelStock.Size = new System.Drawing.Size(995, 544);
            this.PanelStock.TabIndex = 13;
            // 
            // ComboSearch
            // 
            this.ComboSearch.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSearch.FormattingEnabled = true;
            this.ComboSearch.Location = new System.Drawing.Point(140, 60);
            this.ComboSearch.Name = "ComboSearch";
            this.ComboSearch.Size = new System.Drawing.Size(725, 34);
            this.ComboSearch.TabIndex = 0;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.ForeColor = System.Drawing.Color.Black;
            this.LabelSearch.Location = new System.Drawing.Point(135, 28);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(89, 29);
            this.LabelSearch.TabIndex = 12;
            this.LabelSearch.Text = "Search:";
            // 
            // StockGridView
            // 
            this.StockGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockGridView.Location = new System.Drawing.Point(140, 111);
            this.StockGridView.Name = "StockGridView";
            this.StockGridView.Size = new System.Drawing.Size(725, 406);
            this.StockGridView.TabIndex = 13;
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
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.PanelStock);
            this.Controls.Add(this.LabelStock);
            this.Name = "Stocks";
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PanelStock.ResumeLayout(false);
            this.PanelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Panel PanelStock;
        private System.Windows.Forms.DataGridView StockGridView;
        private System.Windows.Forms.ComboBox ComboSearch;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Button LogOut;
    }
}