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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
            string balance;
            string accountNumber = File.ReadAllText("CurrentUser.txt");
            string query = "SELECT Amount FROM account_details WHERE Account_No = '" + accountNumber + "'";

            using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm"))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        balance = dr.GetString(0);
                        lblCurrentBal.Text = balance;
                        lblAvailableBal.Text = balance;
                    }
                    conn.Close();
                }
            }
        }

        private void lblCurrentBal_Click(object sender, EventArgs e)
        {
            
        }

        private void homeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var HomePage = new HomePage();
            HomePage.FormClosed += (s, args) => this.Close();
            HomePage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Balance_Load(object sender, EventArgs e)
        {

        }
    }
}
