namespace work
{
    partial class home2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMin = new Button();
            btnMax = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            pnlFmLo = new Panel();
            panel1 = new Panel();
            btnLogout = new Button();
            pnlNav = new Panel();
            btnMedTracker = new Button();
            btnMedApp = new Button();
            button1 = new Button();
            panel2 = new Panel();
            btnInOut = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMin
            // 
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(833, 0);
            btnMin.Margin = new Padding(3, 4, 3, 4);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(26, 31);
            btnMin.TabIndex = 11;
            btnMin.Text = "__";
            btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Location = new Point(866, 0);
            btnMax.Margin = new Padding(3, 4, 3, 4);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(26, 31);
            btnMax.TabIndex = 10;
            btnMax.Text = "+";
            btnMax.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(899, 0);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 31);
            btnClose.TabIndex = 9;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(251, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 39);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Dashboard";
            // 
            // pnlFmLo
            // 
            pnlFmLo.BackColor = Color.White;
            pnlFmLo.Dock = DockStyle.Bottom;
            pnlFmLo.Location = new Point(186, 100);
            pnlFmLo.Name = "pnlFmLo";
            pnlFmLo.Size = new Size(765, 477);
            pnlFmLo.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnInOut);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pnlNav);
            panel1.Controls.Add(btnMedTracker);
            panel1.Controls.Add(btnMedApp);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(0, 534);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(186, 43);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log Out";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Red;
            pnlNav.Location = new Point(0, 193);
            pnlNav.Margin = new Padding(3, 4, 3, 4);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(3, 100);
            pnlNav.TabIndex = 7;
            // 
            // btnMedTracker
            // 
            btnMedTracker.Dock = DockStyle.Top;
            btnMedTracker.FlatAppearance.BorderSize = 0;
            btnMedTracker.FlatStyle = FlatStyle.Flat;
            btnMedTracker.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedTracker.Location = new Point(0, 214);
            btnMedTracker.Name = "btnMedTracker";
            btnMedTracker.Size = new Size(186, 43);
            btnMedTracker.TabIndex = 4;
            btnMedTracker.Text = "Medical Tracker";
            btnMedTracker.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMedTracker.UseVisualStyleBackColor = true;
            btnMedTracker.Click += btnMedTracker_Click;
            // 
            // btnMedApp
            // 
            btnMedApp.Dock = DockStyle.Top;
            btnMedApp.FlatAppearance.BorderSize = 0;
            btnMedApp.FlatStyle = FlatStyle.Flat;
            btnMedApp.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedApp.Location = new Point(0, 171);
            btnMedApp.Name = "btnMedApp";
            btnMedApp.Size = new Size(186, 43);
            btnMedApp.TabIndex = 3;
            btnMedApp.Text = "Medical Appointments";
            btnMedApp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMedApp.UseVisualStyleBackColor = true;
            btnMedApp.Click += btnMedApp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 200);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 171);
            panel2.TabIndex = 0;
            // 
            // btnInOut
            // 
            btnInOut.Dock = DockStyle.Top;
            btnInOut.FlatAppearance.BorderSize = 0;
            btnInOut.FlatStyle = FlatStyle.Flat;
            btnInOut.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInOut.Location = new Point(0, 257);
            btnInOut.Name = "btnInOut";
            btnInOut.Size = new Size(186, 43);
            btnInOut.TabIndex = 10;
            btnInOut.Text = "Sign In And Out";
            btnInOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInOut.UseVisualStyleBackColor = true;
            btnInOut.Click += btnInOut_Click;
            // 
            // home2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(951, 577);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(pnlFmLo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "home2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "home2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnMax;
        private Button btnClose;
        private Label lblTitle;
        private Panel pnlFmLo;
        private Panel panel1;
        private Panel pnlNav;
        private Button btnMedTracker;
        private Button btnMedApp;
        private Button button1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnInOut;
    }
}