namespace YutMobileStore
{
    partial class Attendace
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
            this.LabelAttendance = new System.Windows.Forms.Label();
            this.panelAttendance = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.panelAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelAttendance
            // 
            this.LabelAttendance.AutoSize = true;
            this.LabelAttendance.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAttendance.ForeColor = System.Drawing.Color.Black;
            this.LabelAttendance.Location = new System.Drawing.Point(563, 61);
            this.LabelAttendance.Name = "LabelAttendance";
            this.LabelAttendance.Size = new System.Drawing.Size(262, 59);
            this.LabelAttendance.TabIndex = 13;
            this.LabelAttendance.Text = "Attendance";
            // 
            // panelAttendance
            // 
            this.panelAttendance.BackColor = System.Drawing.Color.DarkGray;
            this.panelAttendance.Controls.Add(this.dataGridView1);
            this.panelAttendance.Location = new System.Drawing.Point(31, 140);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(668, 540);
            this.panelAttendance.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.SalaryBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.LabelDate);
            this.panel1.Controls.Add(this.LabelEmployee);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(720, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 540);
            this.panel1.TabIndex = 15;
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.BackColor = System.Drawing.Color.Black;
            this.SalaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryBtn.FlatAppearance.BorderSize = 0;
            this.SalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryBtn.ForeColor = System.Drawing.Color.White;
            this.SalaryBtn.Location = new System.Drawing.Point(175, 476);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(272, 39);
            this.SalaryBtn.TabIndex = 16;
            this.SalaryBtn.Text = "Compute Salary";
            this.SalaryBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(258, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 33);
            this.textBox1.TabIndex = 15;
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.ForeColor = System.Drawing.Color.Black;
            this.LabelDate.Location = new System.Drawing.Point(53, 91);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(60, 26);
            this.LabelDate.TabIndex = 14;
            this.LabelDate.Text = "Date:";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.ForeColor = System.Drawing.Color.Black;
            this.LabelEmployee.Location = new System.Drawing.Point(53, 47);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(163, 26);
            this.LabelEmployee.TabIndex = 14;
            this.LabelEmployee.Text = "Employee Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(32, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 329);
            this.panel2.TabIndex = 0;
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
            this.LogOut.TabIndex = 16;
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
            this.BackBtn.TabIndex = 17;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Attendace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAttendance);
            this.Controls.Add(this.LabelAttendance);
            this.Name = "Attendace";
            this.Text = "Attendace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAttendance;
        private System.Windows.Forms.Panel panelAttendance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BackBtn;
    }
}