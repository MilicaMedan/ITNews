using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ITNews
{
    public partial class UserControlSignIn : UserControl
    {
        LogInForm logInForm = null;
        UserControlLogIn ucLogIn = null;
        long idOfCurrentUser = 0;
        long idLanguageOfCurrentUser = 0;
        long idThemeOfCurrentUser = 0;
        bool isAdmin = false;

        public UserControlSignIn()
        {
            InitializeComponent();
        }

        public UserControlSignIn(LogInForm logInForm, UserControlLogIn ucLogIn)
        {
            //this.Dock = DockStyle.Fill;
            InitializeComponent();
            

            this.logInForm = logInForm;
            this.ucLogIn = ucLogIn;
            if (ucLogIn.getRbSrpski().Checked)
            {
                rbSrpski.Checked = true;
            }
            else {
                rbEngleski.Checked = true;
            }

            

            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.llanguages
                             orderby a.idLanguage
                             select new
                             {
                                 idLanguage = a.idLanguage,
                                 name = a.name
                             }).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    this.cbLanguage.Items.Add(lista.ElementAt(i).name);
                }

            }

            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.themes
                             orderby a.idTheme
                             select new
                             {
                                 idLanguage = a.idTheme,
                                 name = a.name
                             }).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    this.cbTheme.Items.Add(lista.ElementAt(i).name);
                }

            }


            cbLanguage.SelectedItem = "Srpski";
            cbTheme.SelectedItem = "Standardna";
            setLanguage();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            bool userNameUnique = true;
            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.uusers
                             select new
                             {
                                 userName = a.userName
                             }).ToList();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (tbUserName.Text.Equals(lista.ElementAt(i).userName))
                    {
                        userNameUnique = false;
                        break;
                    }
                }
            }

            if (tbPassword.Text.Equals("") || tbPasswordAgain.Text.Equals("") || tbUserName.Text.Equals("")) {

                if (rbSrpski.Checked)
                {
                    MessageBox.Show("Morate unijeti sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You need to enter all the informations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (!tbPasswordAgain.Text.Equals(tbPassword.Text))
            {
                if (rbSrpski.Checked)
                {
                    MessageBox.Show("Lozinke se ne poklapaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Passwords dont match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!userNameUnique)
            {

                if (rbSrpski.Checked)
                {
                    MessageBox.Show("Korisničko ime mora biti jedinstveno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Username must be unique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else {
                using (itNewsDb db = new itNewsDb())
                {
                    var user = new uuser()
                    {
                        idUser = 0,
                        userName = tbUserName.Text,
                        passwordHash = hashPassword(tbPassword.Text),
                        isAdmin = false,
                        idTheme = cbTheme.SelectedIndex + 1,
                        idLanguage = cbLanguage.SelectedIndex + 1
                    };

                    db.uusers.Add(user);
                    db.SaveChanges();

                    var lista = (from a in db.uusers
                                 where a.userName.Equals(tbUserName.Text)
                                 select new
                                 {
                                     idUser = a.idUser
                                 }).ToList();
                    if (lista.Count != 0) {
                        this.idOfCurrentUser = lista.ElementAt(0).idUser;
                        this.idLanguageOfCurrentUser = cbLanguage.SelectedIndex + 1;
                        this.idThemeOfCurrentUser = cbTheme.SelectedIndex + 1;
                        this.isAdmin = false;
                    }

                }



                new StandardForm(this.idOfCurrentUser,this.idLanguageOfCurrentUser,this.idThemeOfCurrentUser, this.isAdmin).Show();
                this.logInForm.Hide();
            }
        }

        public string hashPassword(string password) {
            byte[] salt = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 } ;

            var SaltSize = salt.Length;
            var HashSize = 20;

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1);
            var hash = pbkdf2.GetBytes(HashSize);

            // Combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$MYHASH$V1${0}${1}", 1, base64Hash);
        }

        private void setLanguage()
        {
            if (rbEngleski.Checked)
            {
                CultureInfo ci = new CultureInfo("en-US");
                getRes(ci);
            }
            else if (rbSrpski.Checked)
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
                this.logInForm.Text = "Log in";
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.rbSrpski.Text = rm.GetString("rbSrpski", ci);
                this.rbEngleski.Text = rm.GetString("rbEngleski", ci);
                this.lUserName.Text = rm.GetString("lUserName", ci);
                this.lPassword.Text = rm.GetString("lPassword", ci);
                this.lPasswordAgain.Text = rm.GetString("lPasswordAgain", ci);
                this.lTheme.Text = rm.GetString("lTheme", ci);
                this.lLanguage.Text = rm.GetString("lLanguage", ci);
                this.bCreate.Text = rm.GetString("bCreate", ci);

            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.logInForm.Text = "Prijavi se";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.rbSrpski.Text = rm.GetString("rbSrpski", ci);
                this.rbEngleski.Text = rm.GetString("rbEngleski", ci);
                this.lUserName.Text = rm.GetString("lUserName", ci);
                this.lPassword.Text = rm.GetString("lPassword", ci);
                this.lPasswordAgain.Text = rm.GetString("lPasswordAgain", ci);
                this.lTheme.Text = rm.GetString("lTheme", ci);
                this.lLanguage.Text = rm.GetString("lLanguage", ci);
                this.bCreate.Text = rm.GetString("bCreate", ci);

            }
        }

        private void rbSrpski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSrpski.Checked) { setLanguage();}
        }

        private void rbEngleski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEngleski.Checked) { setLanguage(); }
        }

        private void setTheme(string theme)
        {
            if (theme.Equals("Svijetla"))
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.bCreate.BackColor = SystemColors.ControlLight;
                this.lLanguage.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lUserName.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lPassword.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lTheme.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.bCreate.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.rbEngleski.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.rbSrpski.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            }
            else if (theme.Equals("Tamna"))
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.lLanguage.ForeColor = Color.White;
                this.lUserName.ForeColor = Color.White;
                this.lPassword.ForeColor = Color.White;
                this.lPasswordAgain.ForeColor = Color.White;
                this.lTheme.ForeColor = Color.White;
                this.bCreate.ForeColor = Color.White;
                this.bCreate.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                this.rbEngleski.ForeColor = Color.White;
                this.rbSrpski.ForeColor = Color.White;
            }
            else if (theme.Equals("Standardna")) {
                this.tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
                this.bCreate.BackColor = SystemColors.ActiveCaption;
                this.lLanguage.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lUserName.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lPassword.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lPasswordAgain.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.lTheme.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.bCreate.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.rbEngleski.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
                this.rbSrpski.ForeColor = System.Drawing.Color.FromArgb(0, 0, 64);
            }
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTheme(cbTheme.SelectedItem.ToString());
        }
    }
}
