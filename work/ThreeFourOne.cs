using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace work
{
    public partial class _341 : Form
    {
        public _341()
        {
            InitializeComponent();
        }

        private void _341_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select * from current_students where WCN = '" + this.txtWCN.Text.Trim() + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtWCN.Text = reader.GetString(0);
                    txtName.Text = reader.GetString(1);

                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string reason = cbReason.SelectedItem.ToString();
                int points = 0;
                if (reason == "Late")
                {
                    points = 1;
                }
                else if (reason == "Left without signing out")
                {
                    points = 1;
                }
                else if (reason == "Failed room inspection")
                {
                    points = 2;
                }
                else if (reason == "Smoking in room")
                {
                    points = 5;
                }
                else if (reason == "Cellphone violation")
                {
                    points = 1;
                };
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into writeup(WCN, Full_Name, Reason, Points, Time, Date, MAL) values('" + this.txtWCN.Text + "', '" + this.txtName.Text + "', '" + @reason + "', '" + @points + "', '" + this.txtTime.Text + "', '" + this.txtDate.Text + "', '" + this.txtMAL.Text + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Information Submitted");
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
