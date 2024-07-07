using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Org.BouncyCastle.Crypto.Engines;
using System.Web;

namespace work
{
    public partial class home : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnPersonalInfo.Height;
            pnlNav.Top = btnPersonalInfo.Top;
            pnlNav.Left = btnPersonalInfo.Left;
            btnPersonalInfo.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Personal Information";
            this.pnlFmLo.Controls.Clear();
            Personal_Info Personal_Info_Vrb = new Personal_Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPersonalInfo.Height;
            pnlNav.Top = btnPersonalInfo.Top;
            pnlNav.Left = btnPersonalInfo.Left;
            btnPersonalInfo.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Personal Information";
            this.pnlFmLo.Controls.Clear();
            Personal_Info Personal_Info_Vrb = new Personal_Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnMedApp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMedApp.Height;
            pnlNav.Top = btnMedApp.Top;
            pnlNav.Left = btnMedApp.Left;
            btnMedApp.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Medical Appointments";
            this.pnlFmLo.Controls.Clear();
            Medical_Appointments Personal_Info_Vrb = new Medical_Appointments() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnMedTracker_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMedTracker.Height;
            pnlNav.Top = btnMedTracker.Top;
            pnlNav.Left = btnMedTracker.Left;
            btnMedTracker.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Medical Tracker";
            this.pnlFmLo.Controls.Clear();
            Medical_Tracker Personal_Info_Vrb = new Medical_Tracker() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnEditInformation_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEditInformation.Height;
            pnlNav.Top = btnEditInformation.Top;
            pnlNav.Left = btnEditInformation.Left;
            btnEditInformation.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Edit Information";
            this.pnlFmLo.Controls.Clear();
            Edit_Info Personal_Info_Vrb = new Edit_Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnNewStudent.Height;
            pnlNav.Top = btnNewStudent.Top;
            pnlNav.Left = btnNewStudent.Left;
            btnNewStudent.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "New Student";
            this.pnlFmLo.Controls.Clear();
            New_Student Personal_Info_Vrb = new New_Student() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btnPersonalInfo_Leave(object sender, EventArgs e)
        {
            //btnPersonalInfo.BackColor = Color.FromArgb(160, 160, 160);
        }

        private void btnMedApp_Leave(object sender, EventArgs e)
        {
            //btnMedApp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMedTracker_Leave(object sender, EventArgs e)
        {
            //btnMedTracker.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEditInformation_Leave(object sender, EventArgs e)
        {
            //btnEditInformation.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnNewStudent_Leave(object sender, EventArgs e)
        {
            //btnNewStudent.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnInOut.Height;
            pnlNav.Top = btnInOut.Top;
            pnlNav.Left = btnInOut.Left;
            btnInOut.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Sign In & Out";
            this.pnlFmLo.Controls.Clear();
            inOut Personal_Info_Vrb = new inOut() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void accountability_Click(object sender, EventArgs e)
        {
            pnlNav.Height = accountability.Height;
            pnlNav.Top = accountability.Top;
            pnlNav.Left = accountability.Left;
            accountability.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Accountability";
            this.pnlFmLo.Controls.Clear();
            Accountability Personal_Info_Vrb = new Accountability() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void btn341_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn341.Height;
            pnlNav.Top = btn341.Top;
            pnlNav.Left = btn341.Left;
            btn341.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "341";
            this.pnlFmLo.Controls.Clear();
            work._341 Personal_Info_Vrb = new work._341() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
