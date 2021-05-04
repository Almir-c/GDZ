using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PredmetForm : Form
    {
        string predmet;
        public PredmetForm(string predmet1)
        {
            predmet = predmet1;
            InitializeComponent();

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);



            int x = 10;

            //Бегаем по всем учебникам
            foreach (Uchebniki uch in Form1.spisok)
            {
                //Если предмет норм
                if (uch.discipline == predmet)
                {
                    //Добавляем картинку
                    PictureBox oblojka = new PictureBox();
                    oblojka.Image = uch.oblojka.Image;
                    oblojka.Location = new Point(x, 150);
                    oblojka.Size = new Size(120, 138);
                    oblojka.SizeMode = PictureBoxSizeMode.Zoom;
                    oblojka.Click += new EventHandler(OpenUchebnik);
                    Controls.Add(oblojka);
                    x = x + 150;
                    if (x + 120 > Width)
                    {
                        //y = y + 180;
                        //x = 10;
                    }
                }
            }

            /*label1.Text = File.ReadAllText("../../Resources/" + predmet1 + ".txt");
            pictureBox1.Load("../../Resources/" + predmet1 + ".png");
            pictureBox1.Tag = predmet;
            */
        }
        void translate(Dictionary<string, string> Words)
        {
            buttonDa.Text = Words["Вернуться к списку предметов"];
            Text = Words["Учебники"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Открываем учебник
        /// </summary>
        public static void OpenUchebnik(object sender, EventArgs e)
        {
            foreach (Uchebniki uch in Form1.spisok)
            {
                /// Ищем нужный учебник
                if (((PictureBox)sender).Image == uch.oblojka.Image)
                {
                    UchebnikForm fisica2 = new UchebnikForm(uch.discipline, uch.schoolClass.ToString(), uch.Author);
                    fisica2.Show();
                    break;
                }                
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void PredmetForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);
        }
    }
}
