using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YutMobileStore
{
    public partial class AddPhones : Form
    {
        public AddPhones()
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
