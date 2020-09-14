using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ITNews
{
    public partial class UserControlLogIn : UserControl
    {

        LogInForm logInForm = null;
        long idOfCurrentUser = 0;
        long idLanguageOfCurrentUser = 0;
        long idThemeOfCurrentUser = 0;
        bool isAdmin = false;

        public UserControlLogIn()
        {
            InitializeComponent();
        }

        public UserControlLogIn(LogInForm l) {
            this.logInForm = l;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            rbSrpski.Checked = true;
            setLanguage();
        }

        public RadioButton getRbSrpski() {
            return rbSrpski;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bSignUp_Click(object sender, EventArgs e)
        {
            UserControlSignIn u = new UserControlSignIn(this.logInForm,this);
            logInForm.getPanel().Controls.Add(u, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (tbUserName.Text.Equals("") || tbPassword.Text.Equals(""))
            {
                if (rbSrpski.Checked)
                {
                    MessageBox.Show("Morate unijeti sve podatke!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("You need to enter all the informations!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else {
                using (itNewsDb db = new itNewsDb())
                {
                    var lista = (from a in db.uusers
                                 where a.userName.Equals(tbUserName.Text)
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
                        UserControlSignIn u = new UserControlSignIn();
                        string hash = u.hashPassword(tbPassword.Text);
                        if (hash.Equals(lista.ElementAt(0).passwordHash))
                        {

                            idOfCurrentUser = lista.ElementAt(0).idUser;
                            idLanguageOfCurrentUser = lista.ElementAt(0).idLanguage;
                            idThemeOfCurrentUser = lista.ElementAt(0).idTheme;
                            isAdmin = lista.ElementAt(0).isAdmin;
                            
                        }
                    }
                }

                if (idOfCurrentUser == 0)
                {
                    if (rbSrpski.Checked)
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Wrong username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else {
                    new StandardForm(this.idOfCurrentUser, this.idLanguageOfCurrentUser, this.idThemeOfCurrentUser, this.isAdmin).Show();
                    this.logInForm.Hide();
                }
            }
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
                this.lSignUp.Text = rm.GetString("lSignUp", ci);
                this.bSignUp.Text = rm.GetString("bSignUp", ci);
                this.button1.Text = rm.GetString("button1", ci);

            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                this.logInForm.Text = "Prijavi se";
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.rbSrpski.Text = rm.GetString("rbSrpski", ci);
                this.rbEngleski.Text = rm.GetString("rbEngleski", ci);
                this.lUserName.Text = rm.GetString("lUserName", ci);
                this.lPassword.Text = rm.GetString("lPassword", ci);
                this.lSignUp.Text = rm.GetString("lSignUp", ci);
                this.bSignUp.Text = rm.GetString("bSignUp", ci);
                this.button1.Text = rm.GetString("button1", ci);
            }
        }

        private void rbSrpski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSrpski.Checked) { setLanguage(); }
        }

        private void rbEngleski_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEngleski.Checked) { setLanguage(); }
        }
    }
}
