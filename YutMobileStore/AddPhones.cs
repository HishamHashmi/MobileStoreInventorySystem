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
    public partial class AddPhones : Form
    {
        public AddPhones()
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

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog O = new OpenFileDialog();
            O.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (O.ShowDialog() == DialogResult.OK)
            {
                PhoneImage.Image = new Bitmap(O.FileName);
                PhoneImage.SizeMode = PictureBoxSizeMode.StretchImage;
                TextPath.Text = O.FileName;
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                if (TextPath.Text != null)
                {
                    if (RadioNewPhone.Checked == true && RadioOldPhone.Checked == false)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "INSERT into cellPhones(phoneBrand, phoneModel, phonePrice, phoneUnits, phoneCondition, phoneImage, phoneBarcode, entryDate, phoneVendor)" +
                            "values('" + TextCompany.Text + "' , '" + TextModel.Text + "' , '" + TextPrice.Text + "' , '" + TextUnits.Text + "' , ' New Phone ',  '"+ TextPath.Text +"'  , '" + TextBarcode.Text + "' " +
                            " , '" + TextDate.Text + "' , '" + TextVendor.Text + "' )";
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Phone data saved successfully!!");
                    }
                    else
                    {
                        if (RadioNewPhone.Checked == false && RadioOldPhone.Checked == true)
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "INSERT into cellPhones(phoneBrand, phoneModel, phonePrice, phoneUnits, phoneCondition, phoneImage, phoneBarcode, entryDate, phoneVendor)" +
                                "values('" + TextCompany.Text + "' , '" + TextModel.Text + "' , '" + TextPrice.Text + "' , '" + TextUnits.Text + "' ,  ' Old Phone ' ,  '" + TextPath.Text + "'  , '" + TextBarcode.Text + "' " +
                                " , '" + TextDate.Text + "' , '" + TextVendor.Text + "' )";
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Phone Data stored successfully!!");
                        }
                    }
                }
            }
        }
    }
}
