using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITNews
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            UserControlLogIn u = new UserControlLogIn(this);
            InitializeComponent();
            panel1.Controls.Add(u, 0, 0);
            u.Dock = DockStyle.Fill;
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            System.Windows.Forms.Application.Exit();
        }
        public TableLayoutPanel getPanel() {
            return this.panel1;
        }
    }
}
