﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace YutMobileStore
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (loginfo.userIdentify == "Admin")
            {
                this.Hide();
                Home H = new Home();
                H.Show();
            }
            else if (loginfo.userIdentify == "Employee")
            {
                this.Hide();
                EmployeeMenu EM = new EmployeeMenu();
                EM.Show();
            }
        }
    }
}
