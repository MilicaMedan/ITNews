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
    public partial class EditProfileForm : Form
    {
        long idCurrentUser = 0;
        long idLanguageOfCurrentUser = 0;
        long idThemeOfCurrentUser = 0;
        StandardForm form = null;
        public EditProfileForm()
        {
            InitializeComponent();
        }

        public EditProfileForm(long idCurrentUser, long idL, long idT, StandardForm form) {
            this.form = form;
            form.Enabled = false;
            this.idCurrentUser = idCurrentUser;
            this.idLanguageOfCurrentUser = idL;
            this.idThemeOfCurrentUser = idT;

            string language = "";
            string theme = "";

            InitializeComponent();

            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.uusers
                             where a.idUser == idCurrentUser
                             select new
                             {
                                 idUser = a.idUser,
                                 passwordHash = a.passwordHash,
                                 userName = a.userName,
                                 idTheme = a.idTheme,
                                 idLanguage = a.idLanguage
                             }).ToList();

                var lista1 = (from a in db.llanguages
                             orderby a.idLanguage
                             select new
                             {
                                 idLanguage = a.idLanguage,
                                 name = a.name
                             }).ToList();

                for (int i = 0; i < lista1.Count; i++)
                {
                    this.cbLanguage.Items.Add(lista1.ElementAt(i).name);
                    if (lista1.ElementAt(i).idLanguage == lista.ElementAt(0).idLanguage) {
                        language = lista1.ElementAt(i).name;
                    }
                }

                var lista2 = (from a in db.themes
                             orderby a.idTheme
                             select new
                             {
                                 idTheme = a.idTheme,
                                 name = a.name
                             }).ToList();

                for (int i = 0; i < lista2.Count; i++)
                {
                    this.cbTheme.Items.Add(lista2.ElementAt(i).name);
                    if (lista2.ElementAt(i).idTheme == lista.ElementAt(0).idTheme)
                    {
                        theme = lista2.ElementAt(i).name;
                    }
                }

                if (lista.Count != 0) {
                    tbUserName.Text = lista.ElementAt(0).userName;
                    tbPassword.Text = lista.ElementAt(0).passwordHash;
                    cbLanguage.SelectedItem = language;
                    cbTheme.SelectedItem = theme;

                }
            }

            setLanguage();
            setTheme();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            form.Enabled = true;
            base.OnFormClosing(e);
        }


        private void bOk_Click(object sender, EventArgs e)
        {
            using (itNewsDb db = new itNewsDb()) {
                var lista = (from a in db.uusers
                             where a.idUser == idCurrentUser
                             select new
                             {
                                 idUser = a.idUser,
                                 passwordHash = a.passwordHash,
                                 userName = a.userName,
                                 idTheme = a.idTheme,
                                 idLanguage = a.idLanguage,
                                 isAdmin = a.isAdmin
                             }).ToList();




                if (lista.Count != 0) {
                    if ((!tbUserName.Text.Equals(lista.ElementAt(0).userName)) || (cbLanguage.SelectedIndex - 1) != lista.ElementAt(0).idLanguage || (cbTheme.SelectedIndex - 1) != lista.ElementAt(0).idTheme)
                    {
                        db.uusers.Find(lista.ElementAt(0).idUser).idLanguage = cbLanguage.SelectedIndex + 1;
                        db.uusers.Find(lista.ElementAt(0).idUser).idTheme = cbTheme.SelectedIndex + 1;
                        db.uusers.Find(lista.ElementAt(0).idUser).userName = tbUserName.Text;

                        db.SaveChanges();
                        if ((cbLanguage.SelectedIndex + 1) == 1)
                        {
                            MessageBox.Show("Uspješna izmjena!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Successful change!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                        this.form.Close();
                        this.form = new StandardForm(lista.ElementAt(0).idUser, (cbLanguage.SelectedIndex + 1), (cbTheme.SelectedIndex + 1), lista.ElementAt(0).isAdmin);
                        this.form.Show();
                        form.Enabled = true;
                        this.Close();
                    }
                }
            }
            
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm(this.idCurrentUser,this.idLanguageOfCurrentUser,this.idThemeOfCurrentUser,this).Show();
        }


        private void setLanguage()
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
                this.Text = "Change profile settings";
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.lLanguage.Text = rm.GetString("lLanguage", ci);
                this.lTheme.Text = rm.GetString("lTheme", ci);
                this.lUserName.Text = rm.GetString("lUserName", ci);
                this.lPassword.Text = rm.GetString("lPassword", ci);
                this.bChangePassword.Text = rm.GetString("bChangePassword", ci);
                this.bOk.Text = rm.GetString("bOk", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.Text = "Ažuriraj podešavanja profila";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.lLanguage.Text = rm.GetString("lLanguage", ci);
                this.lTheme.Text = rm.GetString("lTheme", ci);
                this.lUserName.Text = rm.GetString("lUserName", ci);
                this.lPassword.Text = rm.GetString("lPassword", ci);
                this.bChangePassword.Text = rm.GetString("bChangePassword", ci);
                this.bOk.Text = rm.GetString("bOk", ci);
            }
        }

        private void setTheme()
        {
            if (this.idThemeOfCurrentUser == 1)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.bChangePassword.BackColor = SystemColors.ControlLight;
                this.bOk.BackColor = SystemColors.ControlLight;
            }
            else if (this.idThemeOfCurrentUser == 3)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.lLanguage.ForeColor = Color.White;
                this.lTheme.ForeColor = Color.White;
                this.lPassword.ForeColor = Color.White;
                this.lUserName.ForeColor = Color.White;
                this.bOk.ForeColor = Color.White;
                this.bOk.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.bChangePassword.ForeColor = Color.White;
                this.bChangePassword.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }
    }
}
