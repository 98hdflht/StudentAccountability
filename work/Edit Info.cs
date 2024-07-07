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
using Org.BouncyCastle.Asn1.X500;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace work
{
    public partial class Edit_Info : Form
    {
        public Edit_Info()
        {
            InitializeComponent();
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
                    txtRoomNum.Text = reader.GetString(2);
                    txtDAS.Text = reader.GetString(3);
                    txtGroup.Text = reader.GetString(4);
                    txtBuilding.Text = reader.GetString(5);
                    txtPhoneNum.Text = reader.GetString(6);
                    txtDOD.Text = reader.GetString(7);
                    txtFIIN.Text = reader.GetString(8);
                    txtSSN.Text = reader.GetString(9);
                    txtDOB.Text = reader.GetString(10);
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "update current_students set WCN = '" + this.txtWCN.Text + "', Full_Name = '" + this.txtName.Text + "', Room = '" + this.txtRoomNum.Text + "', DAS = '" + this.txtDAS.Text + "', Group_Number = '" + this.txtGroup.Text + "', Building = '" + this.txtBuilding.Text + "', Cell_Number = '" + this.txtPhoneNum.Text + "', DOD = '" + this.txtDOD.Text + "', FIIN = '" + this.txtFIIN.Text + "', SSN = '" + this.txtSSN.Text + "', DOB = '" + this.txtDOB.Text + "' where WCN = '" + this.txtWCN.Text.Trim() + "';";
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWCN.Clear();
            txtName.Clear();
            txtRoomNum.Clear();
            txtDAS.Clear();
            txtGroup.Clear();
            txtBuilding.Clear();
            txtPhoneNum.Clear();
            txtDOD.Clear();
            txtFIIN.Clear();
            txtSSN.Clear();
            txtDOB.Clear();
        }

        private void Edit_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
