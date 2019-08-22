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
using System.Drawing.Imaging;
using System.IO;

namespace YutMobileStore
{
    public partial class AddAccessories : Form
    {
        public AddAccessories()
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

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                if (TextPath.Text != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT into cellAccessories(accessoryBrand, accessoryModel, accessoryType,  accessoryUnits, accessoryPrice,  accessoryImage, accessoryBarcode, dateofentry, accessoryVendor)" +
                        "values('" + TextCompany.Text + "' , '" + TextModel.Text + "' , '" + TextType.Text + "' , '" + TextUnits.Text + "' , '" + TextPrice.Text + "' ,  '" + TextPath.Text + "'  , '" + TextBarcode.Text + "' " +
                        " , '" + TextDate.Text + "' , '" + TextVendor.Text + "' )";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Accessory data saved successfully!!");
                }
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (O.ShowDialog() == DialogResult.OK)
            {
                accessoryImage.Image = new Bitmap(O.FileName);
                accessoryImage.SizeMode = PictureBoxSizeMode.StretchImage;
                TextPath.Text = O.FileName;
            }
        }
    }
}
