namespace work
{
    partial class Accountability
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
            dataView = new DataGridView();
            txtWCN = new TextBox();
            btnAccount = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(4, 78);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 29;
            dataView.Size = new Size(784, 361);
            dataView.TabIndex = 0;
            // 
            // txtWCN
            // 
            txtWCN.Location = new Point(139, 22);
            txtWCN.Name = "txtWCN";
            txtWCN.Size = new Size(125, 27);
            txtWCN.TabIndex = 1;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(417, 22);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(94, 29);
            btnAccount.TabIndex = 10;
            btnAccount.Text = "Mark";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(642, 20);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Accountability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(btnReset);
            Controls.Add(btnAccount);
            Controls.Add(txtWCN);
            Controls.Add(dataView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accountability";
            Text = "Accountability";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView;
        private TextBox txtWCN;
        private Button btnAccount;
        private Button btnReset;
    }
}