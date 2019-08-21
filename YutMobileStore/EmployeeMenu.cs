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
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory I = new Inventory();
            I.Show();
        }
     
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void Phones_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddPhones AP = new AddPhones();
            AP.Show();

        }

        private void Accessories_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AddAccessories AA = new AddAccessories();
            AA.Show();
        }

        private void Ledger_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ledger L = new Ledger();
            L.Show();
        }

        private void Sale_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Sales S = new Sales();
            S.Show();
        }

        private void Stock_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Stocks St = new Stocks();
            St.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
        
        }

        private void ProductInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfo St = new ProductInfo();
            St.Show();
        }
    }
}
