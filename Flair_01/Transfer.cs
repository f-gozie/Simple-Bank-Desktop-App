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
    public partial class Transfer : Form
    {
        public Transfer()
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
                        lblName.Text = name;
                    }
                    conn.Close();
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (transferAmount.Text.Trim() == "")
            {
                transferAmount.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a transfer amount");
            }
            else if (Convert.ToInt32(transferAmount.Text) < 0)
            {
                transferAmount.BackColor = Color.LightPink;
                MessageBox.Show("Negative values not allowed");
            }
            else
            {
                string strbalanceFirstPerson, strbalanceSecondPerson, accountNumberSecondPerson, strdeductibleAmount;
                int intbalanceFirstPerson, intbalanceSecondPerson, intdeductibleAmount;
                string accountNumberFirstPerson = File.ReadAllText("CurrentUser.txt");
                string query1 = "SELECT Amount FROM account_details WHERE Account_No = '" + accountNumberFirstPerson + "'";

                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;");

                conn.Open();
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                MySqlDataReader read = cmd1.ExecuteReader();

                accountNumberSecondPerson = receiverAccount.Text;

                read.Read();

                strbalanceFirstPerson = read.GetString(0);
                intbalanceFirstPerson = Convert.ToInt32(strbalanceFirstPerson);

                conn.Close();
                try
                {
                    string query2 = "SELECT Amount FROM account_details WHERE Account_No = '" + accountNumberSecondPerson + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);

                    conn.Open();
                    read = cmd2.ExecuteReader();

                    read.Read();

                    strbalanceSecondPerson = read.GetString(0);
                    intbalanceSecondPerson = Convert.ToInt32(strbalanceSecondPerson);

                    conn.Close();

                    strdeductibleAmount = transferAmount.Text;
                    intdeductibleAmount = Convert.ToInt32(strdeductibleAmount);
                    if (intbalanceFirstPerson < intdeductibleAmount)
                    {
                        transferAmount.BackColor = Color.LightPink;
                        MessageBox.Show("Cannot withdraw money that you don't have");
                    }
                    else
                    {
                        intbalanceFirstPerson = intbalanceFirstPerson - intdeductibleAmount;
                        intbalanceSecondPerson = intbalanceSecondPerson + intdeductibleAmount;

                        strbalanceFirstPerson = Convert.ToString(intbalanceFirstPerson);
                        strbalanceSecondPerson = Convert.ToString(intbalanceSecondPerson);

                        string query3 = "UPDATE account_details SET Amount = '" + intbalanceFirstPerson + "' WHERE Account_No = '" + accountNumberFirstPerson + "';";
                        MySqlCommand cmd3 = new MySqlCommand(query3, conn);

                        conn.Open();
                        read = cmd3.ExecuteReader();
                        conn.Close();

                        string query4 = "UPDATE account_details SET Amount = '" + intbalanceSecondPerson + "' WHERE Account_No = '" + accountNumberSecondPerson + "';";
                        MySqlCommand cmd4 = new MySqlCommand(query4, conn);

                        conn.Open();
                        read = cmd4.ExecuteReader();
                        conn.Close();

                        MessageBox.Show("You have successfully transferred " + intdeductibleAmount + "");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Account Number");
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var HomePage = new HomePage();
            HomePage.FormClosed += (s, args) => this.Close();
            HomePage.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
