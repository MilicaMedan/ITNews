namespace ITNews
{
    partial class EditProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bOk = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lLanguage = new System.Windows.Forms.Label();
            this.lTheme = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.43424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.Controls.Add(this.bOk, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbLanguage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lLanguage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lTheme, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTheme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bChangePassword, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bOk
            // 
            this.bOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOk.FlatAppearance.BorderSize = 0;
            this.bOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOk.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bOk.Location = new System.Drawing.Point(372, 211);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(62, 32);
            this.bOk.TabIndex = 12;
            this.bOk.Text = "Sačuvaj";
            this.bOk.UseVisualStyleBackColor = false;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbLanguage.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(178, 122);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(188, 31);
            this.cbLanguage.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbPassword.Location = new System.Drawing.Point(178, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(188, 30);
            this.tbPassword.TabIndex = 8;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLanguage.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lLanguage.Location = new System.Drawing.Point(3, 119);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(169, 38);
            this.lLanguage.TabIndex = 6;
            this.lLanguage.Text = "Jezik :";
            this.lLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lTheme
            // 
            this.lTheme.AutoSize = true;
            this.lTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTheme.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lTheme.Location = new System.Drawing.Point(3, 85);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(169, 34);
            this.lTheme.TabIndex = 5;
            this.lTheme.Text = "Tema :";
            this.lTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPassword.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lPassword.Location = new System.Drawing.Point(3, 44);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(169, 41);
            this.lPassword.TabIndex = 4;
            this.lPassword.Text = "Lozinka :";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUserName.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lUserName.Location = new System.Drawing.Point(3, 0);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(169, 44);
            this.lUserName.TabIndex = 0;
            this.lUserName.Text = "Korisničko ime :";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserName
            // 
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbUserName.Location = new System.Drawing.Point(178, 3);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(188, 30);
            this.tbUserName.TabIndex = 7;
            // 
            // cbTheme
            // 
            this.cbTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTheme.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(178, 88);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(188, 31);
            this.cbTheme.TabIndex = 9;
            // 
            // bChangePassword
            // 
            this.bChangePassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bChangePassword.FlatAppearance.BorderSize = 0;
            this.bChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChangePassword.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bChangePassword.Location = new System.Drawing.Point(372, 47);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(62, 35);
            this.bChangePassword.TabIndex = 11;
            this.bChangePassword.Text = "Promijeni";
            this.bChangePassword.UseVisualStyleBackColor = false;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProfileForm";
            this.Text = "EditProfileForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.Label lTheme;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.Button bOk;
    }
}