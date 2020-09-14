namespace ITNews
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.lPasswordAgain = new System.Windows.Forms.Label();
            this.lOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.bChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.09126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.90874F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.tbPasswordAgain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNewPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lNewPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lPasswordAgain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lOldPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOldPassword, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bChange, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPasswordAgain
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbPasswordAgain, 2);
            this.tbPasswordAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPasswordAgain.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbPasswordAgain.Location = new System.Drawing.Point(137, 77);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.PasswordChar = '*';
            this.tbPasswordAgain.Size = new System.Drawing.Size(230, 26);
            this.tbPasswordAgain.TabIndex = 5;
            // 
            // tbNewPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbNewPassword, 2);
            this.tbNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNewPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbNewPassword.Location = new System.Drawing.Point(137, 40);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(230, 26);
            this.tbNewPassword.TabIndex = 4;
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNewPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lNewPassword.Location = new System.Drawing.Point(3, 37);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(128, 37);
            this.lNewPassword.TabIndex = 2;
            this.lNewPassword.Text = "Nova lozinka :";
            this.lNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPasswordAgain
            // 
            this.lPasswordAgain.AutoSize = true;
            this.lPasswordAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lPasswordAgain.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lPasswordAgain.Location = new System.Drawing.Point(3, 74);
            this.lPasswordAgain.Name = "lPasswordAgain";
            this.lPasswordAgain.Size = new System.Drawing.Size(128, 38);
            this.lPasswordAgain.TabIndex = 1;
            this.lPasswordAgain.Text = "Ponovljena lozinka :";
            this.lPasswordAgain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lOldPassword
            // 
            this.lOldPassword.AutoSize = true;
            this.lOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOldPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lOldPassword.Location = new System.Drawing.Point(3, 0);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(128, 37);
            this.lOldPassword.TabIndex = 0;
            this.lOldPassword.Text = "Stara lozinka :";
            this.lOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOldPassword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbOldPassword, 2);
            this.tbOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOldPassword.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbOldPassword.Location = new System.Drawing.Point(137, 3);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(230, 26);
            this.tbOldPassword.TabIndex = 3;
            // 
            // bChange
            // 
            this.bChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bChange.FlatAppearance.BorderSize = 0;
            this.bChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChange.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bChange.Location = new System.Drawing.Point(260, 185);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(107, 33);
            this.bChange.TabIndex = 6;
            this.bChange.Text = "Promijeni";
            this.bChange.UseVisualStyleBackColor = false;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 221);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Label lPasswordAgain;
        private System.Windows.Forms.Label lOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Button bChange;
    }
}