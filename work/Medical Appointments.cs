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

namespace work
{
    public partial class Medical_Appointments : Form
    {
        public Medical_Appointments()
        {
            InitializeComponent();
            FillData();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillData()
        {
            string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from medical_appointments;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into medical_appointments(WCN, Full_Name, Time, Date, Appointment_Type, Notes) values('" + this.txtWCN.Text + "', '" + this.txtName.Text + "', '" + this.txtTime.Text + "', '" + this.txtDate.Text + "', '" + this.txtType.Text + "', '" + this.txtNotes.Text + "');";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWCN.Clear();
            txtName.Clear();
            txtTime.Clear();
            txtDate.Clear();
            txtType.Clear();
            txtNotes.Clear();

        }
    }
}
