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

namespace work
{
    public partial class home2 : Form
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

        public home2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnMedApp.Height;
            pnlNav.Top = btnMedApp.Top;
            pnlNav.Left = btnMedApp.Left;
            btnMedApp.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Medical Appointments";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            New_Student Personal_Info_Vrb = new New_Student() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Personal_Info_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFmLo.Controls.Add(Personal_Info_Vrb);
            Personal_Info_Vrb.Show();
        }
    }
}
