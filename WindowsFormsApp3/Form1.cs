﻿using System;
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
   
    public struct Uchebniki
    {
        public PictureBox oblojka;
        public PictureBox soderzanie;
        public PictureBox soderzanie2;
        public string Author;
        public string discipline;
        public int schoolClass;
        public int YourIq; 

        public Uchebniki(string _Author, int _YourIq, string _discipline, int _schoolClass)
        {
            Author = _Author;
            YourIq = _YourIq;
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


            EngWords.Add("Темная тема", "Dark theme");
            EngWords.Add("Я выбрал предмет!", "I chose a lesson!");

            RusWords.Add("Темная тема", "Темная тема");
            RusWords.Add("Я выбрал предмет!", "Я выбрал предмет!");




            spisok.Add(new Uchebniki("Перышкин", 0, "Физика", 7));
            spisok.Add(new Uchebniki("Машкова", 0, "Русский язык", 7));
            spisok.Add(new Uchebniki("Каленчук", 0, "Русский язык", 4));
            spisok.Add(new Uchebniki("Гав", 0, "Мемология", 7));
            spisok.Add(new Uchebniki("Мур", 0, "Мемология", 7));
            spisok.Add(new Uchebniki("Виктор", 0, "Мемология", 7));
            /*
            spisok.Add(new Uchebniki("Абрамов", -1));
            spisok.Add(new Uchebniki("Машкова", 100));
            spisok.Add(new Uchebniki("Владимиров", 50));
            spisok.Add(new Uchebniki("Anonim", 1000));
            spisok.Add(new Uchebniki("Верблюдов", 25));
            */
            int x = 10;
            int y = 20;
            foreach (Uchebniki uch in spisok)
            {
                try
                {
                    uch.oblojka.Load("../../Resources/" + uch.discipline + "/" + uch.schoolClass.ToString() + " класс " + uch.Author + " - обложка.jpg");

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

        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();

        void translate(Dictionary<string, string> Words)
        {
            button1.Text = Words["Я выбрал предмет!"];
            button2.Text = Words["Темная тема"];
        }
        private void RuButton_Click(object sender, EventArgs e)
        {
             translate(RusWords);
        }
        
        private void EnButton_Click_1(object sender, EventArgs e)
        {
             translate(EngWords);
        }


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
                button1.BackColor = Color.FromArgb(45, 45, 48);
                button2.BackColor = Color.FromArgb(45, 45, 48);
                buttonForm1.BackColor = Color.FromArgb(45, 45, 48);
              
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.FromArgb(255, 255, 255);
                button2.Text = "Светлая тема";
            }
            else
            {
                button1.BackColor = Color.FromArgb(255, 255, 255);
                button2.BackColor = Color.FromArgb(255, 255, 255);
                buttonForm1.BackColor = Color.FromArgb(255, 255, 255);
               
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);
                button2.Text = "Темная тема";
            }
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
            pictureBox1.Load("../../Resources/гдз.png");
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
    }
}



