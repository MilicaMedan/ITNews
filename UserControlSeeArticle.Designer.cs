namespace ITNews
{
    partial class UserControlSeeArticle
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.tbText = new System.Windows.Forms.RichTextBox();
            this.lAuthor = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.tbTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbPicture, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lAuthor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbAuthor, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.07463F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.92538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.tbTitle, 3);
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.Font = new System.Drawing.Font("Poor Richard", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbTitle.Location = new System.Drawing.Point(3, 3);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(650, 51);
            this.tbTitle.TabIndex = 0;
            // 
            // pbPicture
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbPicture, 3);
            this.pbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPicture.Location = new System.Drawing.Point(3, 60);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(650, 100);
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // tbText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbText, 3);
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.Font = new System.Drawing.Font("Poor Richard", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbText.Location = new System.Drawing.Point(3, 166);
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(650, 193);
            this.tbText.TabIndex = 2;
            this.tbText.Text = "";
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAuthor.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lAuthor.Location = new System.Drawing.Point(476, 362);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(79, 37);
            this.lAuthor.TabIndex = 3;
            this.lAuthor.Text = "Autor :";
            this.lAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAuthor
            // 
            this.tbAuthor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAuthor.Font = new System.Drawing.Font("Poor Richard", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbAuthor.Location = new System.Drawing.Point(561, 365);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(92, 23);
            this.tbAuthor.TabIndex = 4;
            // 
            // UserControlSeeArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlSeeArticle";
            this.Size = new System.Drawing.Size(656, 399);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.RichTextBox tbText;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.TextBox tbAuthor;
    }
}
