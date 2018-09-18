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

namespace Flair_01
{
    public partial class GetBalance : Form
    {
        public string accNo = "";
        public string pin = "";

        public GetBalance()
        {
            InitializeComponent();
        }

        private void chkBalance_Click(object sender, EventArgs e)
        {
            accNo = accnoText.Text;
            pin = pinText.Text;

            if ((accNo.Trim() == "") || (pin.Trim() == ""))
            {
                if (accNo.Trim() == "")
                {
                    accnoText.BackColor = Color.LightPink;
                }
                else if (pin.Trim() == "")
                {
                    pinText.BackColor = Color.LightPink;
                }
            }
            else
            {
                string accNo = "";
                string pin = "";
                string query = "SELECT * FROM account_details WHERE( (Account_No = @accNo) AND (PIN = @pin))";

                using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@accNo", accnoText.Text.Trim());
                        cmd.Parameters.AddWithValue("@pin", pinText.Text.Trim());
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                accNo = reader["Account_No"].ToString();
                                pin = reader["PIN"].ToString();
                            }
                            conn.Close();
                        }
                    }
                }
                if (pinText.Text != pin)
                {
                    MessageBox.Show("Invalid Details");
                }
                else
                {
                    string balance = "";
                    string request = "SELECT Amount FROM account_details WHERE Account_No='" + accNo + "' AND PIN='" + pin + "'";
                    using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=agozie;database=myatm;"))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(request, conn))
                        {
                            MySqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                balance = dr.GetString(0);
                                MessageBox.Show("Your balance is " + balance);
                            }
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}
