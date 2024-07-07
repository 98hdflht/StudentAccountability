namespace work
{
    partial class inOut
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
            txtWCN = new TextBox();
            comboLocation = new ComboBox();
            btnSignout = new Button();
            dataView = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            txtTime = new TextBox();
            timeIn = new TextBox();
            btnSignin = new Button();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // txtWCN
            // 
            txtWCN.Location = new Point(69, 32);
            txtWCN.Name = "txtWCN";
            txtWCN.Size = new Size(125, 27);
            txtWCN.TabIndex = 1;
            // 
            // comboLocation
            // 
            comboLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLocation.FormattingEnabled = true;
            comboLocation.Items.AddRange(new object[] { "BX", "Pool", "Commissary", "Town", "Hospital", "Gym" });
            comboLocation.Location = new Point(210, 32);
            comboLocation.Name = "comboLocation";
            comboLocation.Size = new Size(151, 28);
            comboLocation.TabIndex = 2;
            // 
            // btnSignout
            // 
            btnSignout.Location = new Point(381, 32);
            btnSignout.Name = "btnSignout";
            btnSignout.Size = new Size(94, 29);
            btnSignout.TabIndex = 3;
            btnSignout.Text = "Sign Out";
            btnSignout.UseVisualStyleBackColor = true;
            btnSignout.MouseDown += btnSignout_MouseDown;
            btnSignout.MouseUp += btnSignout_MouseUp;
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(12, 67);
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 29;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(775, 372);
            dataView.TabIndex = 4;
            dataView.CellClick += dataView_CellClick;
            dataView.MouseUp += dataView_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "WCN";
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            txtName.Visible = false;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(318, 152);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 7;
            txtTime.Visible = false;
            // 
            // timeIn
            // 
            timeIn.Location = new Point(663, 32);
            timeIn.Name = "timeIn";
            timeIn.Size = new Size(125, 27);
            timeIn.TabIndex = 8;
            timeIn.Visible = false;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(501, 33);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(94, 29);
            btnSignin.TabIndex = 9;
            btnSignin.Text = "Sign In";
            btnSignin.UseVisualStyleBackColor = true;
            btnSignin.Click += btnSignin_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(519, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 10;
            txtID.Visible = false;
            // 
            // inOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(txtID);
            Controls.Add(btnSignin);
            Controls.Add(timeIn);
            Controls.Add(txtTime);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataView);
            Controls.Add(btnSignout);
            Controls.Add(comboLocation);
            Controls.Add(txtWCN);
            FormBorderStyle = FormBorderStyle.None;
            Name = "inOut";
            Text = "inOut";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWCN;
        private ComboBox comboLocation;
        private Button btnSignout;
        private DataGridView dataView;
        private Label label1;
        private TextBox txtName;
        private TextBox txtTime;
        private TextBox timeIn;
        private Button btnSignin;
        private TextBox txtID;
    }
}