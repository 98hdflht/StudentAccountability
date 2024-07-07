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
    public partial class New_Student : Form
    {
        public New_Student()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server = localhost; uid = client; pwd = 2015JPjk; database = work";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "insert into current_students(WCN, Full_Name, Room, DAS, Group_Number, Building, Cell_Number, DOD, FIIN, SSN, DOB) values('" + this.txtWCN.Text + "', '" + this.txtName.Text + "', '" + this.txtRoomNum.Text + "', '" + this.txtDAS.Text + "', '" + this.txtGroup.Text + "', '" + this.txtBuilding.Text + "', '" + this.txtPhoneNum.Text + "', '" + this.txtDOD.Text + "', '" + this.txtFIIN.Text + "', '" + this.txtSSN.Text + "', '" + this.txtDOB.Text + "');";
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

        private void New_Student_Load(object sender, EventArgs e)
        {

        }
    }
}
