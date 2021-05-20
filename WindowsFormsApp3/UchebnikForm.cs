using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UchebnikForm : Form
    {
        Uchebniki uch;
        public UchebnikForm(string predmet, string schoolClass, string author)
        {
            InitializeComponent();
            if (Form1.IsDarkTheme)
            {
                BackColor = Color.FromArgb(45, 45, 48);

                ForeColor = Color.FromArgb(255, 255, 255);

            }
            else
            {
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);

            }

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);

            foreach (Uchebniki uch1 in Form1.spisok)
            {
                /// Ищем нужный учебник
                if (predmet == uch1.discipline &&
                    author == uch1.Author)
                {
                    uch = uch1;
                    break;
                }
            }

            Text = predmet + " (" + author + ", " + schoolClass + " класс)";

            f1(predmet, schoolClass, author);
        }
        void f1(string predmet, string schoolClass, string author)
        {
            panel1.Controls.Clear();

            if (uch.link == "")
                button2.Visible = false;

            //Рейтинг
            for (int i = 0; i < uch.Rating; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackgroundImage = Properties.Resources.star3;
                pic.Click += new EventHandler(OpenUchebnik);
                pic.BackgroundImageLayout = ImageLayout.Zoom;
                pic.Location = new Point(50 * i, 20);
                pic.Size = new Size(50, 50);
                panel1.Controls.Add(pic);
                pic.Tag = (i + 1);
            }
            for (int i = uch.Rating; i<8;  i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackgroundImage = Properties.Resources.falsestar3;
                pic.BackgroundImageLayout = ImageLayout.Zoom;
                pic.Click += new EventHandler(OpenUchebnik);
                pic.Location = new Point(50 * i, 20);
                pic.Size = new Size(50, 50);
                panel1.Controls.Add(pic);
                pic.Tag = (i + 1);
            }


            try
            {
                pictureBox1.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - обложка.png");
                pictureBox2.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - темы.png");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - обложка.jpg");
                    pictureBox2.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - темы.jpg");
                }
                catch (Exception)
                {
                } 
            }
            //pictureBox2.Load("../../Resources/" + predmet + "/" + picAdress + " - темы.png");
        }



        public void OpenUchebnik(object sender, EventArgs e)
        {
            int rate1 = Convert.ToInt32(((PictureBox)sender).Tag.ToString());
            uch.Rating = rate1;
            f1(uch.discipline, uch.schoolClass.ToString(), uch.Author);
            MessageBox.Show("Изменено");
        }
        private void translate(Dictionary<string, string> Words)
        {
            Text = Words["Обложка и содержание"];
        }

        private void FormFisica_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void starClick(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.zakladka.Add(uch);
            MessageBox.Show("Вы добавили учебник в избранные");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uch.Rating = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient link = new WebClient();
            link.DownloadFileAsync(new Uri(uch.link), "1.pdf");
            MessageBox.Show("Сохранено");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
