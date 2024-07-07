using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace work
{
    public partial class Medical_Tracker : Form
    {
        public Medical_Tracker()
        {
            InitializeComponent();
            FillData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "")
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
            else
            {
                try
                {
                    string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "select * from medical_tracker where Id = '" + this.txtID.Text.Trim() + "';";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtID.Text = reader.GetString(0);
                        txtWCN.Text = reader.GetString(1);
                        txtName.Text = reader.GetString(2);
                        txtSymptoms.Text = reader.GetString(3);
                        txtLocation.Text = reader.GetString(4);
                        txtDate.Text = reader.GetString(5);
                        txtTimeout.Text = reader.GetString(6);
                        txtTimein.Text = reader.GetString(7);
                        txtMissed.Text = reader.GetString(8);
                        txtQuarters.Text = reader.GetString(9);
                        txtNotes.Text = reader.GetString(10);
                    }
                    con.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTimein.Text == "")
            {
                try
                {
                    string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "insert into medical_tracker set WCN = '" + this.txtWCN.Text + "', Full_Name = '" + this.txtName.Text + "', ID = '" + this.txtID.Text + "', Symptoms = '" + this.txtSymptoms.Text + "', Location = '"+ this.txtLocation.Text +"', Date = '"+ this.txtDate.Text +"', Time_Out = '"+ this.txtTimeout.Text+"', Time_In = '"+ this.txtTimein.Text +"', Class_Time_Missed = '"+ this.txtMissed.Text +"', Quarters_Authorized = '"+ this.txtQuarters.Text +"', Notes = '"+ this.txtNotes.Text +"';";
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
            else
            {
                try
                {
                    string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = connstring;
                    con.Open();
                    string sql = "update medical_tracker set WCN = '" + this.txtWCN.Text + "', Full_Name = '" + this.txtName.Text + "', ID = '" + this.txtID.Text + "', Symptoms = '" + this.txtSymptoms.Text + "', Location = '" + this.txtLocation.Text + "', Date = '" + this.txtDate.Text + "', Time_Out = '" + this.txtTimeout.Text + "', Time_In = '" + this.txtTimein.Text + "', Class_Time_Missed = '" + this.txtMissed.Text + "', Quarters_Authorized = '" + this.txtQuarters.Text + "', Notes = '" + this.txtNotes.Text + "' where ID = '"+ this.txtID.Text +"';";
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWCN.Clear();
            txtName.Clear();
            txtID.Clear();
            txtSymptoms.Clear();
            txtLocation.Clear();
            txtDate.Clear();
            txtTimeout.Clear();
            txtTimein.Clear();
            txtMissed.Clear();
            txtQuarters.Clear();
            txtNotes.Clear();
        }

        private void FillData()
        {
            string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select * from medical_tracker order by Date;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;
            con.Close();
        }
    }
}
