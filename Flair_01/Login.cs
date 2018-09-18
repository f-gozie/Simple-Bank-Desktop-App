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
    public partial class Login : Form
    {
        public string acctno = "";
        public string pin = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string data;
            // data = this.txtPinput.Text;
            // data = data.Remove(data.Length - 1);
            // this.txtPinput.Text = data;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            acctno = txtAccinput.Text;
            pin = txtPinput.Text;
            
            if ((acctno.Trim() == "") || (pin.Trim() == ""))
            {
                if (acctno.Trim() == "")
                {
                    txtAccinput.BackColor = Color.LightPink;
                }
                else if (pin.Trim() == "")
                {
                    txtPinput.BackColor = Color.LightPink;
                }
            }
            else
            {
                string acctno = "";
                string pin = "";
                string query = "SELECT * FROM account_details WHERE( (Account_No = @acctno) AND (PIN = @pin))";

                using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@acctno", txtAccinput.Text.Trim());
                        cmd.Parameters.AddWithValue("@pin", txtPinput.Text.Trim());
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                acctno = reader["Account_No"].ToString();
                                pin = reader["PIN"].ToString();
                            }
                            conn.Close();
                        }
                    }
                }
                if (txtPinput.Text != pin)
                {
                    MessageBox.Show("Invalid Details");
                }
                else
                {
                    MessageBox.Show("Successful Login");

                    using (StreamWriter writerBabs = File.CreateText("CurrentUser.txt"))
                    {
                        writerBabs.WriteLine(acctno);
                    }
                    this.Hide();
                    var HomePage = new HomePage();
                    // HomePage.Closed += (s, args) => this.Close();
                    HomePage.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Register = new Register();
            Register.Closed += (s, args) => this.Close();
            Register.Show();
        }
    }
}