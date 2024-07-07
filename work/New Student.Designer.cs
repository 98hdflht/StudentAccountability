namespace work
{
    partial class New_Student
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
            txtDOB = new TextBox();
            txtSSN = new TextBox();
            txtFIIN = new TextBox();
            txtDOD = new TextBox();
            txtPhoneNum = new TextBox();
            txtBuilding = new TextBox();
            txtGroup = new TextBox();
            txtDAS = new TextBox();
            txtRoomNum = new TextBox();
            txtName = new TextBox();
            txtWCN = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(255, 265);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(125, 27);
            txtDOB.TabIndex = 50;
            txtDOB.Text = "DD-MM-YY";
            // 
            // txtSSN
            // 
            txtSSN.Location = new Point(14, 265);
            txtSSN.Name = "txtSSN";
            txtSSN.Size = new Size(204, 27);
            txtSSN.TabIndex = 49;
            // 
            // txtFIIN
            // 
            txtFIIN.Location = new Point(494, 191);
            txtFIIN.Name = "txtFIIN";
            txtFIIN.Size = new Size(204, 27);
            txtFIIN.TabIndex = 48;
            // 
            // txtDOD
            // 
            txtDOD.Location = new Point(254, 191);
            txtDOD.Name = "txtDOD";
            txtDOD.Size = new Size(203, 27);
            txtDOD.TabIndex = 47;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(14, 191);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(203, 27);
            txtPhoneNum.TabIndex = 46;
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(546, 116);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(125, 27);
            txtBuilding.TabIndex = 45;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(254, 116);
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(125, 27);
            txtGroup.TabIndex = 44;
            // 
            // txtDAS
            // 
            txtDAS.Location = new Point(14, 116);
            txtDAS.Name = "txtDAS";
            txtDAS.Size = new Size(125, 27);
            txtDAS.TabIndex = 43;
            txtDAS.Text = "DD-MM-YY";
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(546, 39);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(125, 27);
            txtRoomNum.TabIndex = 42;
            // 
            // txtName
            // 
            txtName.Location = new Point(251, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 41;
            // 
            // txtWCN
            // 
            txtWCN.Location = new Point(14, 39);
            txtWCN.Name = "txtWCN";
            txtWCN.Size = new Size(143, 27);
            txtWCN.TabIndex = 40;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Location = new Point(482, 344);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 52);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightGray;
            btnSave.Location = new Point(150, 344);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 52);
            btnSave.TabIndex = 38;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(255, 243);
            label11.Name = "label11";
            label11.Size = new Size(40, 20);
            label11.TabIndex = 36;
            label11.Text = "DOB";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 243);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 35;
            label10.Text = "SSN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(494, 168);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 34;
            label9.Text = "FIIN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(254, 168);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 33;
            label8.Text = "DOD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 168);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 32;
            label7.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 93);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 31;
            label6.Text = "Building Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 93);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 30;
            label5.Text = "Group";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 93);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 29;
            label4.Text = "DAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 16);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 28;
            label3.Text = "Room Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 16);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 27;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 16);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 26;
            label1.Text = "WCN";
            // 
            // New_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 399);
            Controls.Add(txtDOB);
            Controls.Add(txtSSN);
            Controls.Add(txtFIIN);
            Controls.Add(txtDOD);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtBuilding);
            Controls.Add(txtGroup);
            Controls.Add(txtDAS);
            Controls.Add(txtRoomNum);
            Controls.Add(txtName);
            Controls.Add(txtWCN);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "New_Student";
            Text = "New_Student";
            Load += New_Student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDOB;
        private TextBox txtSSN;
        private TextBox txtFIIN;
        private TextBox txtDOD;
        private TextBox txtPhoneNum;
        private TextBox txtBuilding;
        private TextBox txtGroup;
        private TextBox txtDAS;
        private TextBox txtRoomNum;
        private TextBox txtName;
        private TextBox txtWCN;
        private Button btnClear;
        private Button btnSave;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}