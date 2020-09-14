using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITNews
{
    public partial class UserControlListArticles : UserControl
    {
        StandardForm s = null;

        public UserControlListArticles()
        {
            InitializeComponent();
        }
        public UserControlListArticles(StandardForm s)
        {
            this.s = s;
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            setTheme();
        }

        public TableLayoutPanel getPanel() {
            return this.panel1;
        }

        public void setStandardForm (StandardForm s) {
            this.s = s;
        }

        private void setTheme()
        {
            if (this.s.getidThemeOfCurrentUser() == 1)
            {
                this.panel1.BackColor = Color.White;
            }
            else if (this.s.getidThemeOfCurrentUser() == 3)
            {
                this.panel1.BackColor = SystemColors.ControlDark;
            }
        }
    }
}
