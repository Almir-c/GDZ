using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
   
    public struct Uchebniki
    {
        public PictureBox oblojka;
        public PictureBox soderzanie;
        public PictureBox soderzanie2;
        public string Author;
        public string discipline;
        public int schoolClass;
        public int YourIq; 
        public int Rating; 

        public Uchebniki(string _Author, int _YourIq, int _Rating, string _discipline, int _schoolClass)
        {
            Author = _Author;
            YourIq = _YourIq;
            Rating = _Rating;
            oblojka = new PictureBox();
            soderzanie = new PictureBox();
            soderzanie2 = new PictureBox();
            discipline = _discipline;
            schoolClass = _schoolClass;
            
        }
    }

    public partial class Form1 : Form
    {
        public static bool IsDarkTheme = false;

        

        /// <summary>
        /// Все учебники
        /// </summary>
        public static List<Uchebniki> spisok = new List<Uchebniki>();

        public static List<Uchebniki> zakladka = new List<Uchebniki>();
        //Uchebniki[] spisok = new Uchebniki[300];
        public Form1()
        {

            InitializeComponent();


            IsDarkTheme = Properties.Settings.Default.IsDarkTheme;
            ApplyTheme();

            EngWords.Add("Вернуться к списку предметов", "Go back to the list of lesson");
            EngWords.Add("Учебники", "TextBooks");
            EngWords.Add("Выбранные учебники", "Selected TextBooks ");
            EngWords.Add("Обложка и содержание", "Cover and content");
            EngWords.Add("Светлая тема", "Light theme");
            EngWords.Add("Темная тема", "Dark theme");
            EngWords.Add("Я выбрал предмет!", "I chose a lesson!");

            RusWords.Add("Вернуться к списку предметов", "Вернуться к списку предметов");
            RusWords.Add("Учебники", "Учебники");
            RusWords.Add("Выбранные учебники", "Выбранные учебники");
            RusWords.Add("Обложка и содержание", "Обложка и содержание");
            RusWords.Add("Светлая тема", "Светлая тема");
            RusWords.Add("Темная тема", "Темная тема");
            RusWords.Add("Я выбрал предмет!", "Я выбрал предмет!");



            string[] lines = File.ReadAllLines("../../../Учебники.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None); //
                spisok.Add(new Uchebniki(parts[0], Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), 
                    parts[3], Convert.ToInt32(parts[4])));
            }

            int x = 10;
            int y = 20;
            foreach (Uchebniki uch in spisok)
            {
                try
                {
                    uch.oblojka.Load("../../Resources/" + uch.discipline + "/" +
                        uch.schoolClass.ToString() + " класс " + 
                        uch.Author + " - обложка.jpg");

                    uch.oblojka.Location = new Point(x, y);
                    uch.oblojka.Size = new Size(120, 138);
                    uch.oblojka.SizeMode = PictureBoxSizeMode.Zoom;

                    panel1.Controls.Add(uch.oblojka);
                    x = x + 150;
                    if (x + 120 > Width)
                    {
                        y = y + 180;
                        x = 10;
                    }
                }
                catch (Exception)
                {
                    uch.oblojka.Load("../../Resources/какава.png");
                }
                /*try
                {
                    spisok[i].soderzanie.Load("../../Resources/" + spisok[i].Author + " (2).jpg");
                    spisok[i].soderzanie2.Load("../../Resources/" + spisok[i].Author + " (3).jpg");
                }
                catch (Exception)
                {
                    spisok[i].soderzanie.Load("../../Resources/какава.png");
                }*/

                /*
                spisok[i].soderzanie.Location = new Point(x, 150);
                spisok[i].soderzanie.Size = new Size(120, 138);
                spisok[i].soderzanie.SizeMode = PictureBoxSizeMode.Zoom;

                spisok[i].soderzanie2.Location = new Point(x, 150);
                spisok[i].soderzanie2.Size = new Size(120, 138);
                spisok[i].soderzanie2.SizeMode = PictureBoxSizeMode.Zoom;
                */
                //panel1.Controls.Add(spisok[i].soderzanie);
                //panel1.Controls.Add(spisok[i].soderzanie2);

            }
        }


        #region Переводы
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        public static string Language = "Русский";

        void translate(Dictionary<string, string> Words)
        {
            button1.Text = Words["Я выбрал предмет!"];
            if (IsDarkTheme)
                button2.Text = Words["Темная тема"];
            else
                button2.Text = Words["Светлая тема"];
        }
        private void RuButton_Click(object sender, EventArgs e)
        {
            Language = "Русский";
            translate(RusWords);
        }
        
        private void EnButton_Click_1(object sender, EventArgs e)
        {
            Language = "Английский";
            translate(EngWords);
        }
        #endregion


        /*
         Пример перевода для других классов:

        void translate(Dictionary<string, string> Words)
        {
            button1.Text = Words["Поиск тем"];
            Text = Words["Поиск тем"];
        }

        public AllThemes()
        {
            InitializeComponent();

            if (MainForm.Language == "Английский")
                translate(MainForm.EngWords);
            if (MainForm.Language == "Русский")
                translate(MainForm.RusWords);
        }
         
          
         */







        void ApplyTheme()
        {
            if (IsDarkTheme)
            {
                BackColor = Color.FromArgb(45, 45, 48);
              
                ForeColor = Color.FromArgb(255, 255, 255);
                button2.Text = "Светлая тема";
            }
            else
            {
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);
                button2.Text = "Темная тема";
            }

            buttonForm1.BackColor = BackColor;
            button1.BackColor = BackColor;
            button2.BackColor = BackColor;
            RuButton.BackColor = BackColor;
            EnButton.BackColor = BackColor;
            pictureBox1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonMeme.Checked)
            {
                PredmetForm f = new PredmetForm("Мемология");
                f.Show();
            }
            if (radioButtonAlgebra.Checked)
            {
                PredmetForm f = new PredmetForm("Алгебра");
                f.Show();
            }
            if (radioButton2.Checked)
            {
                PredmetForm f = new PredmetForm("Физика");
                f.Show();
            }
            if (radioButton3.Checked)
            {
                PredmetForm f = new PredmetForm("Русский язык");
                f.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (IsDarkTheme)
            {
                pictureBox1.Load("../../Resources/гдзdark.png");
            }
            else
            {
            pictureBox1.Load("../../Resources/гдз.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxForm1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonForm1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < spisok.Count; i++) 
            {
                spisok[i].oblojka.Visible = true;
                spisok[i].soderzanie.Visible = true;
                spisok[i].soderzanie2.Visible = true;
                if (!spisok[i].Author.Contains(textBoxForm1.Text))
                {
                    spisok[i].oblojka.Visible = false;
                    spisok[i].soderzanie.Visible = false;
                    spisok[i].soderzanie2.Visible = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Zakladka().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsDarkTheme = !IsDarkTheme;
            ApplyTheme();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.IsDarkTheme = IsDarkTheme;
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNew neww = new FormNew();
            neww.Show();
        }
    }
}



