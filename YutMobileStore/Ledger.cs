using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace YutMobileStore
{
    public partial class Ledger : Form
    {
        public Ledger()
        {
            InitializeComponent();
        }
        string connectionstring = @"Data Source=DESKTOP-2JBDRTC\SQLEXPRESS;Initial Catalog=YUTMobilesDB;Integrated Security=True";
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void Ledger_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT DISTINCT phoneModel, phoneVendor from cellPhones";
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    con.Open();
                    sda.Fill(dt);
                    DataRow dr = dt.NewRow();
                    dr[0] = 0;
                    dr[1] = "Select";
                    dt.Rows.InsertAt(dr, 0);
                    comboMobileVendor.DisplayMember = "phoneVendor";
                    comboMobileVendor.ValueMember = "phoneModel";
                    comboMobileVendor.DataSource = dt;
                    con.Close();
    
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = con;
                    Cmd.CommandText = "SELECT DISTINCT accessoryModel, accessoryVendor AS AccessoryVendor from cellAccessories";
                    SqlDataAdapter Sda = new SqlDataAdapter();
                    Sda.SelectCommand = Cmd;
                    DataTable Dt = new DataTable();
                    con.Open();
                    Sda.Fill(Dt);
                    DataRow Dr = Dt.NewRow();
                    Dr[0] = 0;
                    Dr[1] = "Select";
                    Dt.Rows.InsertAt(Dr, 0);
                    ComboAccessoryVendor.DisplayMember = "AccessoryVendor";
                    ComboAccessoryVendor.ValueMember = "accessoryModel";
                    ComboAccessoryVendor.DataSource = Dt;
                    con.Close();
            }
        }

        private void comboMobileVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                if (comboMobileVendor.Text == "Select")
                {
                    Ledger_Load(sender, e);
                }
                else if (comboMobileVendor.Text != "Select")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT phoneModel AS Phone, phonePrice AS Price, phoneUnits AS Quantity from cellPhones WHERE phoneVendor = '" + comboMobileVendor.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    con.Open();
                    sda.Fill(ds, "cellPhones");
                    con.Close();
                    ProductListGridView.DataSource = ds;
                    ProductListGridView.DataMember = "cellPhones";

                    con.Open();
                    
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = con;
                    cmd2.CommandText = "SELECT * from transactionLog Where transactionVendor= '" + comboMobileVendor.Text + "'";
                    cmd2.ExecuteNonQuery();
                    SqlDataAdapter sda2 = new SqlDataAdapter();
                    sda2.SelectCommand = cmd2;
                    DataSet ds1 = new DataSet();
                    sda2.Fill(ds1, "transactionLog");
                    con.Close();
                    TransactionLogGridView.DataSource = ds1;
                    TransactionLogGridView.DataMember = "transactionLog";
                }
            }
           
        }
      
        private void ComboAccessoryVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                if (ComboAccessoryVendor.Text == "Select")
                {
                    Ledger_Load(sender, e);
                }
                else if (ComboAccessoryVendor.Text != "Select")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT accessoryModel AS Model, accessoryPrice AS Price, accessoryUnits AS Quantity from cellAccessories WHERE accessoryVendor = '" + ComboAccessoryVendor.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    con.Open();
                    sda.Fill(ds, "cellAccessories");
                    con.Close();
                    ProductListGridView.DataSource = ds;
                    ProductListGridView.DataMember = "cellAccessories";
                }
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }
    }
}
