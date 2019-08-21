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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory I = new Inventory();
            I.Show();
        }

        private void Phones_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPhones AP = new AddPhones();
            AP.Show();
        }

        private void Accessories_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAccessories AA = new AddAccessories();
            AA.Show();
        }

        private void Ledger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ledger L = new Ledger();
            L.Show();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales S = new Sales();
            S.Show();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stocks St = new Stocks();
            St.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendace A = new Attendace();
            this.Show();
        }
    }
}
