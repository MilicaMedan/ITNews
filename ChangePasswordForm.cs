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
    public partial class ChangePasswordForm : Form
    {
        long idCurrentUser = 0;
        long idLanguageOfCurrentUser = 0;
        long idThemeOfCurrentUser = 0;
        EditProfileForm form = null;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(long idCurrentUser, long idL, long idT, EditProfileForm form)
        {
            this.form = form;
            form.Enabled = false;
            this.idCurrentUser = idCurrentUser;
            this.idLanguageOfCurrentUser = idL;
            this.idThemeOfCurrentUser = idT;
            InitializeComponent();
            setLanguage();
            setTheme();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            form.Enabled = true;
            base.OnFormClosing(e);
        }

        private void bChange_Click(object sender, EventArgs e)
        {
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

                UserControlSignIn u = new UserControlSignIn();
                string hash = u.hashPassword(tbOldPassword.Text);

                if (tbNewPassword.Text.Equals("") || tbOldPassword.Text.Equals("") || tbPasswordAgain.Text.Equals("")) {
                    if (lista.ElementAt(0).idLanguage == 1)
                    {
                        MessageBox.Show("Morate unijeti sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("You must enter all the information !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
                else if (lista.Count != 0 && lista.ElementAt(0).passwordHash.Equals(hash) && tbNewPassword.Text.Equals(tbPasswordAgain.Text))
                {
                    db.uusers.Find(lista.ElementAt(0).idUser).passwordHash = u.hashPassword(tbNewPassword.Text);
                    db.SaveChanges();
                    if (lista.ElementAt(0).idLanguage == 1)
                    {
                        MessageBox.Show("Uspješna izmjena!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Successful change!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    form.Enabled = true;
                    this.Close();
                }
                else {
                    if (lista.ElementAt(0).idLanguage == 1)
                    {
                        MessageBox.Show("Netačna stara lozinka ili se lozinke ne poklapaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect old password or passwords dont match!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
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
                this.Text = "Change password";
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.lNewPassword.Text = rm.GetString("lNewPassword", ci);
                this.lOldPassword.Text = rm.GetString("lOldPassword", ci);
                this.lPasswordAgain.Text = rm.GetString("lPasswordAgain", ci);
                this.bChange.Text = rm.GetString("bChange", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.Text = "Promijeni lozinku";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.lNewPassword.Text = rm.GetString("lNewPassword", ci);
                this.lOldPassword.Text = rm.GetString("lOldPassword", ci);
                this.lPasswordAgain.Text = rm.GetString("lPasswordAgain", ci);
                this.bChange.Text = rm.GetString("bChange", ci);
            }
        }

        private void setTheme()
        {
            if (this.idThemeOfCurrentUser == 1)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.bChange.BackColor = SystemColors.ControlLight;
            }
            else if (this.idThemeOfCurrentUser == 3)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.lNewPassword.ForeColor = Color.White;
                this.lOldPassword.ForeColor = Color.White;
                this.lPasswordAgain.ForeColor = Color.White;
                this.bChange.ForeColor = Color.White;
                this.bChange.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

    }
}
