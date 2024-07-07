namespace work
{
    partial class Medical_Appointments
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtWCN = new TextBox();
            txtTime = new TextBox();
            txtType = new TextBox();
            txtName = new TextBox();
            txtDate = new TextBox();
            txtNotes = new TextBox();
            btnSearch = new Button();
            btnSave = new Button();
            btnClear = new Button();
            dataView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "WCN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 7);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(374, 7);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Appointment Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 54);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 54);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 54);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Notes";
            // 
            // txtWCN
            // 
            txtWCN.BackColor = Color.Gainsboro;
            txtWCN.BorderStyle = BorderStyle.None;
            txtWCN.Location = new Point(6, 24);
            txtWCN.Margin = new Padding(3, 2, 3, 2);
            txtWCN.Name = "txtWCN";
            txtWCN.Size = new Size(83, 16);
            txtWCN.TabIndex = 6;
            // 
            // txtTime
            // 
            txtTime.BackColor = Color.Gainsboro;
            txtTime.BorderStyle = BorderStyle.None;
            txtTime.Location = new Point(222, 24);
            txtTime.Margin = new Padding(3, 2, 3, 2);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(109, 16);
            txtTime.TabIndex = 7;
            // 
            // txtType
            // 
            txtType.BackColor = Color.Gainsboro;
            txtType.BorderStyle = BorderStyle.None;
            txtType.Location = new Point(374, 24);
            txtType.Margin = new Padding(3, 2, 3, 2);
            txtType.Name = "txtType";
            txtType.Size = new Size(270, 16);
            txtType.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Gainsboro;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Location = new Point(6, 71);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 16);
            txtName.TabIndex = 9;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.Gainsboro;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Location = new Point(223, 71);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(109, 16);
            txtDate.TabIndex = 10;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.Gainsboro;
            txtNotes.BorderStyle = BorderStyle.None;
            txtNotes.Location = new Point(374, 71);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(270, 26);
            txtNotes.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGray;
            btnSearch.Location = new Point(94, 17);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGray;
            btnSave.Location = new Point(10, 91);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Location = new Point(118, 91);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataView
            // 
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(6, 117);
            dataView.Margin = new Padding(3, 2, 3, 2);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 29;
            dataView.Size = new Size(683, 212);
            dataView.TabIndex = 15;
            dataView.CellContentClick += dataView_CellContentClick;
            // 
            // Medical_Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(dataView);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnSearch);
            Controls.Add(txtNotes);
            Controls.Add(txtDate);
            Controls.Add(txtName);
            Controls.Add(txtType);
            Controls.Add(txtTime);
            Controls.Add(txtWCN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Medical_Appointments";
            Text = "Medical_Appointments";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtWCN;
        private TextBox txtTime;
        private TextBox txtType;
        private TextBox txtName;
        private TextBox txtDate;
        private TextBox txtNotes;
        private Button btnSearch;
        private Button btnSave;
        private Button btnClear;
        private DataGridView dataView;
    }
}