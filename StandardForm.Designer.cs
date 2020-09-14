namespace ITNews
{
    partial class StandardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bLogOut = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bSeeArticle = new System.Windows.Forms.Button();
            this.bAddArticle = new System.Windows.Forms.Button();
            this.bAddAdmin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.77078F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Controls.Add(this.bLogOut, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bSettings, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // bLogOut
            // 
            this.bLogOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bLogOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.bLogOut.FlatAppearance.BorderSize = 0;
            this.bLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogOut.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bLogOut.Location = new System.Drawing.Point(709, 3);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(82, 33);
            this.bLogOut.TabIndex = 0;
            this.bLogOut.Text = "Odjavi se";
            this.bLogOut.UseVisualStyleBackColor = false;
            this.bLogOut.Click += new System.EventHandler(this.bLogOut_Click);
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.Transparent;
            this.bSettings.BackgroundImage = global::ITNews.Properties.Resources.settings1;
            this.bSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSettings.FlatAppearance.BorderSize = 0;
            this.bSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSettings.Location = new System.Drawing.Point(659, 3);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(44, 33);
            this.bSettings.TabIndex = 1;
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.bSeeArticle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bAddArticle, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.bAddAdmin, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(132, 399);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // bSeeArticle
            // 
            this.bSeeArticle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bSeeArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bSeeArticle.FlatAppearance.BorderSize = 0;
            this.bSeeArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeeArticle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeeArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bSeeArticle.Location = new System.Drawing.Point(3, 3);
            this.bSeeArticle.Name = "bSeeArticle";
            this.bSeeArticle.Size = new System.Drawing.Size(126, 34);
            this.bSeeArticle.TabIndex = 0;
            this.bSeeArticle.Text = "Pregledaj članke";
            this.bSeeArticle.UseVisualStyleBackColor = false;
            this.bSeeArticle.Click += new System.EventHandler(this.bSeeArticle_Click);
            // 
            // bAddArticle
            // 
            this.bAddArticle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAddArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddArticle.FlatAppearance.BorderSize = 0;
            this.bAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddArticle.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddArticle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bAddArticle.Location = new System.Drawing.Point(3, 43);
            this.bAddArticle.Name = "bAddArticle";
            this.bAddArticle.Size = new System.Drawing.Size(126, 34);
            this.bAddArticle.TabIndex = 1;
            this.bAddArticle.Text = "Dodaj članak";
            this.bAddArticle.UseVisualStyleBackColor = false;
            this.bAddArticle.Click += new System.EventHandler(this.bAddArticle_Click);
            // 
            // bAddAdmin
            // 
            this.bAddAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bAddAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bAddAdmin.FlatAppearance.BorderSize = 0;
            this.bAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddAdmin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bAddAdmin.Location = new System.Drawing.Point(3, 83);
            this.bAddAdmin.Name = "bAddAdmin";
            this.bAddAdmin.Size = new System.Drawing.Size(126, 34);
            this.bAddAdmin.TabIndex = 2;
            this.bAddAdmin.Text = "Dodaj admina";
            this.bAddAdmin.UseVisualStyleBackColor = false;
            this.bAddAdmin.Click += new System.EventHandler(this.bAddAdmin_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.ColumnCount = 1;
            this.panel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(141, 48);
            this.panel4.Name = "panel4";
            this.panel4.RowCount = 1;
            this.panel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel4.Size = new System.Drawing.Size(656, 399);
            this.panel4.TabIndex = 2;
            // 
            // StandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StandardForm";
            this.Text = "Standardna forma";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel panel4;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bSeeArticle;
        private System.Windows.Forms.Button bAddArticle;
        private System.Windows.Forms.Button bAddAdmin;
    }
}