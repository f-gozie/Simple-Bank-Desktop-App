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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
            string name;

            string accountNumber = File.ReadAllText("CurrentUser.txt");
            string request = "SELECT FirstName, Account_No FROM account_details WHERE Account_No='" + accountNumber + "'";
            using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;"))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(request, conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        name = dr.GetString(0);
                        name = "Hello, " + name;
                        lblName.Text = name.ToString();
                    }
                    conn.Close();
                }
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (depositAmount.Text.Trim() == "")
            {
                depositAmount.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid amount");
            }
            else if ( Convert.ToInt32(depositAmount.Text) > 20000)
            {
                depositAmount.BackColor = Color.LightPink;
                MessageBox.Show("Cannot deposit more than 20,000");
            }
            else if (Convert.ToInt32(depositAmount.Text) < 0)
            {
                depositAmount.BackColor = Color.LightPink;
                MessageBox.Show("Negative values not allowed");
            }

            else
            {
                string strCurrentBalance, strNewBalance;
                int intCurrentBalance, intNewBalance, toBeCreditedBalance;
                string accountNumber;
                accountNumber = File.ReadAllText("CurrentUser.txt");

                string query = "SELECT Amount FROM account_details WHERE Account_No = '" + accountNumber + "'";
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                strCurrentBalance = dr.GetString(0);
                intCurrentBalance = Convert.ToInt32(strCurrentBalance);

                strNewBalance = depositAmount.Text;
                toBeCreditedBalance = Convert.ToInt32(strNewBalance);

                intNewBalance = toBeCreditedBalance + intCurrentBalance;
                strNewBalance = Convert.ToString(intNewBalance);
                conn.Close();

                string request = "UPDATE account_details SET Amount='" + intNewBalance + "' WHERE Account_No = '" + accountNumber + "' ;";
                MySqlCommand command = new MySqlCommand(request, conn);
                conn.Open();
                dr = command.ExecuteReader();
                conn.Close();
                MessageBox.Show("Your account has been credited with " + toBeCreditedBalance + " naira");
                this.Hide();
                var HomePage = new HomePage();
                HomePage.FormClosed += (s, args) => this.Close();
                HomePage.Show();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var HomePage = new HomePage();
            HomePage.FormClosed += (s, args) => this.Close();
            HomePage.Show();
        }
    }
}
