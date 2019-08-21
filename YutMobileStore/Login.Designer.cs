namespace YutMobileStore
{
    partial class Login
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
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LabelAdmin = new System.Windows.Forms.Label();
            this.LabelEmployee = new System.Windows.Forms.Label();
            this.AdminRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeradio = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextUsername
            // 
            this.TextUsername.BackColor = System.Drawing.Color.White;
            this.TextUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUsername.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUsername.ForeColor = System.Drawing.Color.Black;
            this.TextUsername.Location = new System.Drawing.Point(120, 271);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(250, 31);
            this.TextUsername.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(115, 315);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 26);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password:";
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.White;
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPassword.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.Color.Black;
            this.TextPassword.Location = new System.Drawing.Point(120, 344);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(250, 31);
            this.TextPassword.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.employeeradio);
            this.panel1.Controls.Add(this.AdminRadioButton);
            this.panel1.Controls.Add(this.LabelEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.TextUsername);
            this.panel1.Controls.Add(this.TextPassword);
            this.panel1.Controls.Add(this.LabelAdmin);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Location = new System.Drawing.Point(442, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 538);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::YutMobileStore.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(145, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 161);
            this.panel2.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Username.Location = new System.Drawing.Point(115, 242);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(109, 26);
            this.Username.TabIndex = 4;
            this.Username.Text = "Username:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Black;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(120, 436);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(250, 41);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LabelAdmin
            // 
            this.LabelAdmin.AutoSize = true;
            this.LabelAdmin.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelAdmin.Location = new System.Drawing.Point(118, 393);
            this.LabelAdmin.Name = "LabelAdmin";
            this.LabelAdmin.Size = new System.Drawing.Size(68, 23);
            this.LabelAdmin.TabIndex = 0;
            this.LabelAdmin.Text = "Admin:";
            // 
            // LabelEmployee
            // 
            this.LabelEmployee.AutoSize = true;
            this.LabelEmployee.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEmployee.Location = new System.Drawing.Point(220, 393);
            this.LabelEmployee.Name = "LabelEmployee";
            this.LabelEmployee.Size = new System.Drawing.Size(97, 23);
            this.LabelEmployee.TabIndex = 6;
            this.LabelEmployee.Text = "Employee:";
            // 
            // AdminRadioButton
            // 
            this.AdminRadioButton.AutoSize = true;
            this.AdminRadioButton.Location = new System.Drawing.Point(193, 398);
            this.AdminRadioButton.Name = "AdminRadioButton";
            this.AdminRadioButton.Size = new System.Drawing.Size(14, 13);
            this.AdminRadioButton.TabIndex = 7;
            this.AdminRadioButton.TabStop = true;
            this.AdminRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeeradio
            // 
            this.employeeradio.AutoSize = true;
            this.employeeradio.CausesValidation = false;
            this.employeeradio.Location = new System.Drawing.Point(323, 398);
            this.employeeradio.Name = "employeeradio";
            this.employeeradio.Size = new System.Drawing.Size(14, 13);
            this.employeeradio.TabIndex = 8;
            this.employeeradio.TabStop = true;
            this.employeeradio.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton AdminRadioButton;
        private System.Windows.Forms.Label LabelEmployee;
        private System.Windows.Forms.Label LabelAdmin;
        private System.Windows.Forms.RadioButton employeeradio;
    }
}

