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
    public partial class HomePage : Form
    {
        public HomePage()
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
                        labelHello.Text = name.ToString();

                        lblAccno.Text = "Account Number: " + accountNumber;
                    }
                    conn.Close();
                }
            }
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Balance = new Balance();
            Balance.Closed += (s, args) => this.Close();
            Balance.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Deposit = new Deposit();
            Deposit.FormClosed += (s, args) => this.Close();
            Deposit.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Withdraw = new Withdraw();
            Withdraw.FormClosed += (s, args) => this.Close();
            Withdraw.Show();
        }

        private void lblAccno_Click(object sender, EventArgs e)
        {

        }

        private void lblInquiry_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Transfer = new Transfer();
            Transfer.FormClosed += (s, args) => this.Close();
            Transfer.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Thank you for banking with us. Please return soon ;)");
            this.Hide();
            var Login = new Login();
            Login.FormClosed += (s, args) => this.Close();
            Login.Show();
        }

        private void labelHello_Click(object sender, EventArgs e)
        {

        }
    }
}