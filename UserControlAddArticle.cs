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
    public partial class UserControlAddArticle : UserControl
    {
        StandardForm form = null;
        String language = "";

        public UserControlAddArticle(StandardForm form) {
            this.form = form;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from l in db.llanguages
                             orderby l.idLanguage
                             select new
                             {
                                 idLanguage = l.idLanguage,
                                 name = l.name
                             }).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    this.cbLanguage.Items.Add(lista.ElementAt(i).name);
                    if (lista.ElementAt(i).idLanguage == this.form.getidLanguageOfCurrentUser()) {
                        this.language = lista.ElementAt(i).name;
                    }
                }
            }
            this.cbLanguage.SelectedIndex = this.cbLanguage.FindStringExact(language);
            setLanguage();
            setTheme();
        }

        public UserControlAddArticle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String filename = openFileDialog1.FileName;
            try {
                pbPicture.Image = Image.FromFile(filename);
                pbPicture.ImageLocation = filename;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            using(itNewsDb db = new itNewsDb()){
                var article = new article()
                {
                    idArticle = (long)0,
                    title = this.tbTitle.Text,
                    text = this.tbText.Text,
                    idLanguage = this.cbLanguage.SelectedIndex + 1,
                    idUser = this.form.getIdOfCurrentUser(),
                    picture = ImageToByte(this.pbPicture.Image),
                    isTranslated = false,
                };

                db.articles.Add(article);
                db.SaveChanges();
            }
            if (this.form.getidLanguageOfCurrentUser() == 1)
            {
                MessageBox.Show("Članak uspješno kreiran!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Article created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            this.tbText.Text = "";
            this.tbTitle.Text = "";
            this.pbPicture.Image.Dispose();
            this.pbPicture.Image = null;
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


        private void setLanguage()
        {
            if (this.form.getidLanguageOfCurrentUser() == 2)
            {
                CultureInfo ci = new CultureInfo("en-US");
                getRes(ci);
            }
            else if (this.form.getidLanguageOfCurrentUser() == 1)
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
                ResourceManager rm = new ResourceManager("ITNews.languageEng", a);
                this.lPicture.Text = rm.GetString("lPicture", ci);
                this.lText.Text = rm.GetString("lText", ci);
                this.lTitle.Text = rm.GetString("lTitle", ci);
                this.bAdd.Text = rm.GetString("bAdd", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.lPicture.Text = rm.GetString("lPicture", ci);
                this.lText.Text = rm.GetString("lText", ci);
                this.lTitle.Text = rm.GetString("lTitle", ci);
                this.bAdd.Text = rm.GetString("bAdd", ci);
            }
        }

        private void setTheme()
        {
            if (this.form.getidThemeOfCurrentUser() == 1)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.bAdd.BackColor = SystemColors.ControlLight;
            }
            else if (this.form.getidThemeOfCurrentUser() == 3)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDarkDark;
                this.lText.ForeColor = Color.White;
                this.lTitle.ForeColor = Color.White;
                this.lPicture.ForeColor = Color.White;
                this.bAdd.ForeColor = Color.White;
                this.bAdd.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }
    }
}
