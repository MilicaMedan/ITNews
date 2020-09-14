namespace ITNews
{
    partial class UserControlLogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbSrpski = new System.Windows.Forms.RadioButton();
            this.rbEngleski = new System.Windows.Forms.RadioButton();
            this.lSignUp = new System.Windows.Forms.Label();
            this.bSignUp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lUserName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.rbSrpski, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbEngleski, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lSignUp, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bSignUp, 2, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.89655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.10345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ITNews.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(145, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUserName.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lUserName.Location = new System.Drawing.Point(3, 189);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(136, 34);
            this.lUserName.TabIndex = 1;
            this.lUserName.Text = "Korisničko ime :";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbUserName, 2);
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbUserName.Location = new System.Drawing.Point(3, 226);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(292, 26);
            this.tbUserName.TabIndex = 2;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPassword.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lPassword.Location = new System.Drawing.Point(3, 258);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(136, 30);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Lozinka :";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbPassword, 2);
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbPassword.Location = new System.Drawing.Point(3, 291);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(292, 26);
            this.tbPassword.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(301, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbSrpski
            // 
            this.rbSrpski.AutoSize = true;
            this.rbSrpski.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSrpski.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbSrpski.Location = new System.Drawing.Point(301, 3);
            this.rbSrpski.Name = "rbSrpski";
            this.rbSrpski.Size = new System.Drawing.Size(64, 23);
            this.rbSrpski.TabIndex = 6;
            this.rbSrpski.TabStop = true;
            this.rbSrpski.Text = "Srpski";
            this.rbSrpski.UseVisualStyleBackColor = true;
            this.rbSrpski.CheckedChanged += new System.EventHandler(this.rbSrpski_CheckedChanged);
            // 
            // rbEngleski
            // 
            this.rbEngleski.AutoSize = true;
            this.rbEngleski.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEngleski.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rbEngleski.Location = new System.Drawing.Point(371, 3);
            this.rbEngleski.Name = "rbEngleski";
            this.rbEngleski.Size = new System.Drawing.Size(79, 23);
            this.rbEngleski.TabIndex = 7;
            this.rbEngleski.TabStop = true;
            this.rbEngleski.Text = "Engleski";
            this.rbEngleski.UseVisualStyleBackColor = true;
            this.rbEngleski.CheckedChanged += new System.EventHandler(this.rbEngleski_CheckedChanged);
            // 
            // lSignUp
            // 
            this.lSignUp.AllowDrop = true;
            this.lSignUp.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lSignUp, 2);
            this.lSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSignUp.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lSignUp.Location = new System.Drawing.Point(3, 347);
            this.lSignUp.Name = "lSignUp";
            this.lSignUp.Size = new System.Drawing.Size(292, 34);
            this.lSignUp.TabIndex = 8;
            this.lSignUp.Text = "Nemate korisnički nalog?";
            this.lSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bSignUp
            // 
            this.bSignUp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.bSignUp, 2);
            this.bSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSignUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bSignUp.FlatAppearance.BorderSize = 0;
            this.bSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSignUp.Font = new System.Drawing.Font("Poor Richard", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bSignUp.Location = new System.Drawing.Point(301, 350);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(178, 28);
            this.bSignUp.TabIndex = 9;
            this.bSignUp.Text = "Kreiraj nalog";
            this.bSignUp.UseVisualStyleBackColor = false;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // UserControlLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlLogIn";
            this.Size = new System.Drawing.Size(482, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbSrpski;
        private System.Windows.Forms.RadioButton rbEngleski;
        private System.Windows.Forms.Label lSignUp;
        private System.Windows.Forms.Button bSignUp;
    }
}
