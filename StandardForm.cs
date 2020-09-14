using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITNews
{
    public partial class StandardForm : Form
    {
        Dictionary<string, int> buttonsIds = new Dictionary<string, int>();
        long idOfCurrentUser = 0;
        long idLanguageOfCurrentUser = 0;
        long idThemeOfCurrentUser = 0;
        bool isAdmin = false;
        public StandardForm()
        {
            InitializeComponent();
        }

        public StandardForm(long id,long idL,long idT,bool isA) {
            this.idOfCurrentUser = id;
            this.idLanguageOfCurrentUser = idL;
            this.idThemeOfCurrentUser = idT;
            this.isAdmin = isA;

            InitializeComponent();
            bSeeArticle_Click(new object(), new EventArgs());
            if (!this.isAdmin) {
                this.bAddAdmin.Hide();
                this.bAddArticle.Hide();
            }

            setLanguage();
            setTheme();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //System.Windows.Forms.Application.Exit();
        }

        private void bSeeArticle_Click(object sender, EventArgs e)
        {
            buttonsIds = new Dictionary<string, int>(); ;
            string[,] naslovi = null;
            int duzina = 0;
            using (itNewsDb db = new itNewsDb()) {
                var lista = (from a in db.articles
                             where a.idLanguage == this.idLanguageOfCurrentUser
                             orderby a.idArticle
                             select new
                             {
                                 idArticle = a.idArticle,
                                 title = a.title
                             }).ToList();

                if (this.isAdmin) {
                    var lista1 = (from a in db.articles
                                  where a.idLanguage != this.idLanguageOfCurrentUser
                             orderby a.idArticle
                             select new
                             {
                                 idArticle = a.idArticle,
                                 title = a.title
                             }).ToList();

                    lista.AddRange(lista1);
                }

                duzina = lista.Count();
                naslovi = new string[duzina , 2];

                for (int i = 0; i < duzina; i++) {
                    naslovi[i , 0] = lista.ElementAt(i).idArticle.ToString();
                    naslovi[i , 1] = lista.ElementAt(i).title.ToString();
                }

            }



            UserControlListArticles u = new UserControlListArticles(this);
            u.setStandardForm(this);
            TableLayoutPanel panel = u.getPanel();
            panel.RowCount = duzina + 1;
            panel.RowStyles.Clear();
            for (int i = 0; i < duzina; i++) {
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            }
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            for (int i = 0; i < duzina; i++) {
                Button l = new Button();

                if (this.idThemeOfCurrentUser == 1)
                {
                    l.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                    l.BackColor = Color.White;
                }
                else if (this.idThemeOfCurrentUser == 2)
                {
                    l.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                    l.BackColor = SystemColors.GradientInactiveCaption;
                }
                else {
                    l.ForeColor = Color.White;
                    l.BackColor = SystemColors.ControlDark;
                }

                l.Name = "button" + i;
                l.Dock = DockStyle.Fill;
                l.Font = new Font("Poor Richard", 15);
                l.FlatStyle = FlatStyle.Flat;
                l.Text = naslovi[i , 1];
                l.FlatAppearance.BorderSize=0;
                l.TextAlign = ContentAlignment.MiddleLeft;
                l.Click += buttonClick;

                buttonsIds.Add(l.Name, int.Parse(naslovi[i , 0]));

                panel.Controls.Add(l, 0, i);


            }
            this.panel4.Controls.Add(u, 0, 0);

            

            u.Show();
        }

        private void bAddArticle_Click(object sender, EventArgs e)
        {
            UserControlAddArticle u= new UserControlAddArticle(this);
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(u, 0, 0);
        }

        private void bAddAdmin_Click(object sender, EventArgs e)
        {
            new AddAdminForm(this).Show();
        }

        private void buttonClick(object sender, EventArgs e) {
            var button = (Button)sender;
            int idArticle = buttonsIds[button.Name];
            UserControlSeeArticle u = new UserControlSeeArticle(idArticle,this);
            this.panel4.Controls.Clear();
            this.panel4.Controls.Add(u, 0, 0);
        }

        private void bSettings_Click(object sender, EventArgs e)
        {

            new EditProfileForm(this.idOfCurrentUser,this.idLanguageOfCurrentUser,this.idThemeOfCurrentUser,this).Show();
            
        }

        public long getIdOfCurrentUser() {
            return this.idOfCurrentUser;
        }

        public long getidLanguageOfCurrentUser()
        {
            return this.idLanguageOfCurrentUser;
        }

        public long getidThemeOfCurrentUser()
        {
            return this.idThemeOfCurrentUser;
        }


        private void bLogOut_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        public void setLanguage()
        {
            if (this.idLanguageOfCurrentUser == 2)
            {
                CultureInfo ci = new CultureInfo("en-US");
                getRes(ci);
            }
            else if (this.idLanguageOfCurrentUser == 1)
            {
                CultureInfo ci = new CultureInfo("sr-Latn-RS");
                getRes(ci);
            }
        }

        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("ITNews");
            if (ci.ToString().Equals("en-US"))
            {
                this.Text = "Standard form";
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.bLogOut.Text = rm.GetString("bLogOut", ci);
                this.bAddArticle.Text = rm.GetString("bAddArticle", ci);
                this.bAddAdmin.Text = rm.GetString("bAddAdmin", ci);
                this.bSeeArticle.Text = rm.GetString("bSeeArticle", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.Text = "Standardna forma";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.bLogOut.Text = rm.GetString("bLogOut", ci);
                this.bAddArticle.Text = rm.GetString("bAddArticle", ci);
                this.bAddAdmin.Text = rm.GetString("bAddAdmin", ci);
                this.bSeeArticle.Text = rm.GetString("bSeeArticle", ci);

            }
        }

        public void setTheme()
        {
            if (this.idThemeOfCurrentUser == 1)
            {
                this.tableLayoutPanel2.BackColor = SystemColors.ButtonFace;
                this.tableLayoutPanel3.BackColor = SystemColors.ButtonFace;
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.panel4.BackColor = Color.White;
                this.bAddAdmin.BackColor = SystemColors.ControlLight;
                this.bAddArticle.BackColor = SystemColors.ControlLight;
                this.bSeeArticle.BackColor = SystemColors.ControlLight;
                this.bLogOut.BackColor = SystemColors.ControlLight;

            }
            else if (this.idThemeOfCurrentUser == 3)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.tableLayoutPanel2.BackColor = SystemColors.ControlDarkDark;
                this.tableLayoutPanel3.BackColor = SystemColors.ControlDarkDark;
                this.panel4.BackColor = SystemColors.ControlDark;
                this.bLogOut.ForeColor = Color.White;
                this.bLogOut.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.bAddArticle.ForeColor = Color.White;
                this.bAddArticle.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.bAddAdmin.ForeColor = Color.White;
                this.bAddAdmin.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.bSeeArticle.ForeColor = Color.White;
                this.bSeeArticle.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }
    }
}
