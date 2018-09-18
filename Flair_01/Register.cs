using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Flair_01
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            // Initialize fields
            String acctno = txtAcc.Text;
            String pin = txtPin.Text;
            String fName = txtFn.Text;
            String lName = txtLn.Text;
            String address = txtAd.Text;
            String dateOfBirth = txtDob.Text;
            String stramount;
            int intAmount;

            if ((acctno.Trim() == "") || (pin.Trim() == "") || (fName.Trim() == "") || (lName.Trim() == "") || (address.Trim() == "") || (dateOfBirth.Trim() == "") )
            {
                if (acctno.Trim() == "")
                {
                    txtAcc.BackColor = Color.LightBlue;
                }
                else if (pin.Trim() == "")
                {
                    txtPin.BackColor = Color.LightBlue;
                }
                else if (fName.Trim() == "")
                {
                    txtFn.BackColor = Color.LightBlue;
                }
                else if (lName.Trim() == "")
                {
                    txtLn.BackColor = Color.LightBlue;
                }
                else if (address.Trim() == "")
                {
                    txtAd.BackColor = Color.LightBlue;
                }
                else if (dateOfBirth.Trim() == "")
                {
                    txtDob.BackColor = Color.LightBlue;
                }
            }
            else
            {
                if (amountText.Text == "")
                {
                    stramount = "1000";
                    intAmount = Convert.ToInt32(stramount);
                }
                else
                {
                    stramount = amountText.Text;
                    intAmount = Convert.ToInt32(stramount);
                }
                if (pin.Length != 4)
                {
                    txtPin.BackColor = Color.LightBlue;
                    MessageBox.Show("PIN must be four digits");
                }
                else
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;";
                    string query = "INSERT INTO account_details VALUES ('" + acctno + "', '" + pin + "', '" + fName + "', '" + lName + "', '" + address + "', '" + dateOfBirth + "', '" + intAmount + "')";

                    MySqlConnection conn = new MySqlConnection(connectionString);
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.CommandTimeout = 60;
                    MySqlDataReader reader;

                    // Update the database using an exception
                    try
                    {
                        conn.Open();
                        reader = cmd.ExecuteReader();
                        conn.Close();
                        MessageBox.Show("Successful Registration");
                        using (StreamWriter writerBabs = File.CreateText("CurrentUser.txt"))
                        {
                            writerBabs.WriteLine(acctno);
                        }
                        this.Hide();
                        var HomePage = new HomePage();
                        HomePage.FormClosed += (s, args) => this.Close();
                        HomePage.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message); // Incase of any database problems
                    }
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // string data;
            // data = this.btnClear.Text;
            // data = data.Remove(data.Length - 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            var Login = new Login();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void txtDob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
