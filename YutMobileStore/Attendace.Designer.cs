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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1276, 562);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Attendace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LabelAttendance);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Attendace";
            this.Text = "Attendace";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAttendance;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}