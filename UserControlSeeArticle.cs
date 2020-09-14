using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace ITNews
{
    public partial class UserControlSeeArticle : UserControl
    {
        StandardForm form = null;

        public UserControlSeeArticle()
        {
            InitializeComponent();
        }

        public UserControlSeeArticle(int idArticle, StandardForm form) {
            this.Dock = DockStyle.Fill;
            this.form = form;

            string title = "";
            string text = "";
            string author = "";
            byte[] picture;

            InitializeComponent();
            //this.tbText.ScrollBars. = ScrollBarVisibility.Visible;
            using (itNewsDb db = new itNewsDb())
            {
                var lista = (from a in db.articles
                             join u in db.uusers on a.idUser equals u.idUser
                             where a.idArticle == idArticle
                             orderby a.idArticle
                             select new
                             {
                                 idArticle = a.idArticle,
                                 title = a.title,
                                 picture = a.picture,
                                 text = a.text,
                                 author = u.userName
                             }).ToList();

                title = lista.ElementAt(0).title;
                text = lista.ElementAt(0).text;
                author = lista.ElementAt(0).author;
                picture = lista.ElementAt(0).picture;
            }

            this.tbTitle.Text = title;
            this.tbText.Text = text;
            this.tbAuthor.Text = author;
            this.pbPicture.Image = ByteToImage(picture);
            setLanguage();
            setTheme();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

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
                this.lAuthor.Text = rm.GetString("lAuthor", ci);


            }
            else if (ci.ToString().Equals("sr-Latn-RS"))
            {
                ResourceManager rm = new ResourceManager("ITNews.languageSrp", a);
                this.lAuthor.Text = rm.GetString("lAuthor", ci);
            }
        }


        private void setTheme()
        {
            if (this.form.getidThemeOfCurrentUser() == 1)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
                this.tbText.BackColor = SystemColors.ButtonFace;
                this.tbTitle.BackColor = SystemColors.ButtonFace;
                this.tbAuthor.BackColor = SystemColors.ButtonFace;
            }
            else if (this.form.getidThemeOfCurrentUser() == 3)
            {
                this.tableLayoutPanel1.BackColor = SystemColors.ControlDark;
                this.lAuthor.ForeColor = Color.White;
                this.tbTitle.ForeColor = Color.White;
                this.tbText.ForeColor = Color.White; ;
                this.tbAuthor.ForeColor = Color.White;
                this.tbText.BackColor = SystemColors.ControlDark;
                this.tbTitle.BackColor = SystemColors.ControlDark;
                this.tbAuthor.BackColor = SystemColors.ControlDark;
            }
        }
    }
}
