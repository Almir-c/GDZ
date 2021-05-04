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

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);

            Text = predmet + " (" + author + ", " + schoolClass + " класс)";

            foreach (Uchebniki uch1 in Form1.spisok)
            {
                /// Ищем нужный учебник
                if (predmet == uch1.discipline &&
                    author == uch1.Author)
                {
                    uch = uch1;

                    if (uch.link == "")
                        button2.Visible = false;

                    //Рейтинг
                    for (int i = 0; i < uch.Rating; i++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.BackgroundImage = Properties.Resources.star3;
                        pic.BackgroundImageLayout = ImageLayout.Zoom;
                        pic.Location = new Point(100 + 50 * i, 320);
                        pic.Size = new Size(50, 50);
                        Controls.Add(pic);
                    }
                    break;
                }
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
