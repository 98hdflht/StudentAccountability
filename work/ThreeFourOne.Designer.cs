namespace work
{
    partial class _341
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
            txtName = new TextBox();
            txtWCN = new TextBox();
            txtDate = new TextBox();
            txtTime = new TextBox();
            txtMAL = new TextBox();
            cbReason = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(381, 27);
            txtName.TabIndex = 0;
            // 
            // txtWCN
            // 
            txtWCN.Location = new Point(620, 54);
            txtWCN.Name = "txtWCN";
            txtWCN.Size = new Size(125, 27);
            txtWCN.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(115, 255);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(218, 27);
            txtDate.TabIndex = 2;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(538, 255);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(210, 27);
            txtTime.TabIndex = 3;
            // 
            // txtMAL
            // 
            txtMAL.Location = new Point(115, 340);
            txtMAL.Name = "txtMAL";
            txtMAL.Size = new Size(332, 27);
            txtMAL.TabIndex = 4;
            // 
            // cbReason
            // 
            cbReason.FormattingEnabled = true;
            cbReason.Items.AddRange(new object[] { "Late", "Left without signing out", "Failed room inspection", "Smoking in room", "Cellphone violation" });
            cbReason.Location = new Point(115, 176);
            cbReason.Name = "cbReason";
            cbReason.Size = new Size(633, 28);
            cbReason.TabIndex = 5;
            cbReason.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(538, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 56);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "WCN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 179);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 9;
            label3.Text = "Reason";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 255);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 10;
            label4.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 254);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 343);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "MAL";
            label6.Click += label6_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(538, 112);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 39);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // _341
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 404);
            Controls.Add(btnSearch);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(cbReason);
            Controls.Add(txtMAL);
            Controls.Add(txtTime);
            Controls.Add(txtDate);
            Controls.Add(txtWCN);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "_341";
            Text = "_341";
            Load += _341_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtWCN;
        private TextBox txtDate;
        private TextBox txtTime;
        private TextBox txtMAL;
        private ComboBox cbReason;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSearch;
    }
}