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
    public partial class Login : Form 
    {
        public Login()
        {
            InitializeComponent();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (TextUsername.Text == "admin" && TextPassword.Text == "yutadmin" && AdminRadioButton.Checked == true && employeeradio.Checked == false)
            {
                loginfo.userIdentify = "Admin";
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else if (TextUsername.Text == "employee" && TextPassword.Text == "yutemployee" && employeeradio.Checked == true && AdminRadioButton.Checked == false)
            {
                loginfo.userIdentify = "Employee";
                this.Hide();
                EmployeeMenu h = new EmployeeMenu();
                h.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!!");
            }
        }
    }
    public static class loginfo
    {
        public static string userIdentify;
    }
}
