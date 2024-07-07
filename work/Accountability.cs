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
    public partial class Accountability : Form
    {
        public Accountability()
        {
            InitializeComponent();
            FillData();
        }

        private void FillData()
        {
            string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string sql = "select WCN, Full_Name from accountability where Here = 0 order by WCN;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;
            con.Close();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "update accountability set Here = 1 where WCN = '" + this.txtWCN.Text + "';";
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
                txtWCN.Clear();
                FillData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "update accountability set Here = 0;";
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
                txtWCN.Clear();
                FillData();
            }
        }
    }
}
