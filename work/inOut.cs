using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace work
{
    public partial class inOut : Form
    {
        public inOut()
        {
            InitializeComponent();
            FillData();
            timeIn.Text = string.Format("{0:HH:mm}", DateTime.Now);
        }

        private void btnSignout_MouseDown(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "select WCN, Full_Name from current_students where WCN = '" + this.txtWCN.Text.Trim() + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtWCN.Text = reader.GetString(0);
                    txtName.Text = reader.GetString(1);
                    txtTime.Text = string.Format("{0:HH:mm}", DateTime.Now);
                }
                con.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSignout_MouseUp(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into in_out (WCN, Full_Name, Time_Out, Location) values ('" + this.txtWCN.Text + "', '" + this.txtName.Text + "', '" + this.txtTime.Text + "', '" + this.comboLocation.Text + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                con.Close();
                FillData();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FillData()
        {
            string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select ID, WCN, Full_Name, Location, Time_Out from in_out where Time_In = '00:00:00.0000' order by WCN;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;
            con.Close();

        }


        private void dataView_MouseUp(object sender, MouseEventArgs e)
        {

            FillData();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "update in_out set Time_In = '" + this.timeIn.Text + "' where ID = '" + this.txtID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                FillData();
            }
        }

        private void dataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dataView.SelectedRows[0].Cells[0].Value.ToString();
                txtWCN.Text = dataView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
