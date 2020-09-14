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
    public partial class AddAdminForm : Form
    {

        Dictionary<string, long> userIds = new Dictionary<string, long>();
        StandardForm sForm = null;

        public AddAdminForm()
        {
            InitializeComponent();
        }
        public AddAdminForm(StandardForm sForm)
        {
            this.sForm = sForm;
            sForm.Enabled = false;
            InitializeComponent();
            userIds = new Dictionary<string, long>();
            string selectItem = "";
            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.uusers
                             where a.isAdmin == false
                             orderby a.idUser
                             select new
                             {
                                 idUser = a.idUser,
                                 userName = a.userName,
                             }).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    if (i == 0) { selectItem = lista.ElementAt(i).userName; }
                    userIds.Add(lista.ElementAt(i).userName, lista.ElementAt(i).idUser);
                    this.comboBox1.Items.Add(lista.ElementAt(i).userName);
                }

            }

            this.comboBox1.SelectedItem = selectItem ;
            setLanguage();
            setTheme();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sForm.Enabled = true;
            base.OnFormClosing(e);
        }
        private void bDodaj_Click(object sender, EventArgs e)
        {
            long userId = userIds[this.comboBox1.Text];

            using (itNewsDb db = new itNewsDb()) {
                var lista = (from a in db.uusers
                             where a.idUser == userId
                             select new
                             {
                                 idUser = a.idUser,
                                 userName = a.userName,
                                 passwordHash =a.passwordHash,
                                 isAdmin = a.isAdmin,
                                 idTheme = a.idTheme,
                                 idLanguage = a.idLanguage
                             }).ToList();

                if (lista.Count != 0) {
                    db.uusers.Find(lista.ElementAt(0).idUser).isAdmin = true;
                    db.SaveChanges();

                    if (this.sForm.getidLanguageOfCurrentUser() == 1)
                    {
                        MessageBox.Show("Uspješno dodavanje admina!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Successful ading!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    sForm.Enabled = true;
                    this.Close();
                }
            }


        }


        private void setLanguage()
        {
            if (this.sForm.getidLanguageOfCurrentUser() == 2)
            {
                CultureInfo ci = new CultureInfo("en-US");
                getRes(ci);
            }
            else if (this.sForm.getidLanguageOfCurrentUser() == 1)
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
                this.Text = "Add admin";
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.lSelectUser.Text = rm.GetString("lSelectUser", ci);
                this.bDodaj.Text = rm.GetString("bDodaj", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.Text = "Dodajte admina";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.lSelectUser.Text = rm.GetString("lSelectUser", ci);
                this.bDodaj.Text = rm.GetString("bDodaj", ci);

            }
        }

        private void setTheme() {
            if (this.sForm.getidThemeOfCurrentUser() == 1) {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.bDodaj.BackColor = SystemColors.ControlLight;
            }
            else if (this.sForm.getidThemeOfCurrentUser() == 3) {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.lSelectUser.ForeColor = Color.White;
                this.bDodaj.ForeColor = Color.White;
                this.bDodaj.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }
    }
}
