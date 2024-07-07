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
using Org.BouncyCastle.Bcpg;

namespace work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select user, Name, password, level from users where user = '" + this.txtUsername.Text.Trim() + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string pword, uname, level, uID;
                    uID = reader.GetString(0);
                    uname = reader.GetString(1);
                    pword = reader.GetString(2);
                    level = reader.GetString(3);

                    docInfo.name = uname;

                    if (txtUsername.Text == uID && txtPassword.Text == pword && Int32.Parse(level) == 1)
                    {
                        new home().Show();
                        this.Hide();
                    }
                    else if (txtUsername.Text == uID && txtPassword.Text == pword && Int32.Parse(level) == 2)
                    {
                        new home2().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}