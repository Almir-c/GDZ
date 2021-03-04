using System;
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
        public int YourIq; 

        public Uchebniki(string _Author, int _YourIq)
        {
            Author = _Author;
            YourIq = _YourIq;
            oblojka = new PictureBox();
            soderzanie = new PictureBox();
            soderzanie2 = new PictureBox();
        }
    }

    public partial class Form1 : Form
    {
        List<Uchebniki> spisok = new List<Uchebniki>();
        //Uchebniki[] spisok = new Uchebniki[300];
        public Form1()
        {
            InitializeComponent();

            spisok.Add(new Uchebniki ("Петушков", 0));
            
            spisok.Add(new Uchebniki("Абрамов", -1));
            spisok.Add(new Uchebniki("Машкова", 100));
            spisok.Add(new Uchebniki("Владимиров", 50));
            spisok.Add(new Uchebniki("Anonim", 1000));
            spisok.Add(new Uchebniki("Верблюдов", 25));
            
            int x = 10;
            int y = 20;
            for (int i = 0; i < spisok.Count; i++)
            {
                try
                {
                    spisok[i].oblojka.Load("../../Resources/" + spisok[i].Author + ".jpg");
                }
                catch (Exception)
                {
                    spisok[i].oblojka.Load("../../Resources/какава.png");
                }                                                                                          
                try
                {
                    spisok[i].soderzanie.Load("../../Resources/" + spisok[i].Author + " (2).jpg");
                    spisok[i].soderzanie2.Load("../../Resources/" + spisok[i].Author + " (3).jpg");
                }
                catch (Exception)
                {
                    spisok[i].soderzanie.Load("../../Resources/какава.png");
                }

                spisok[i].oblojka.Location = new Point(x, 10);
                spisok[i].oblojka.Size = new Size(120, 138);
                spisok[i].oblojka.SizeMode = PictureBoxSizeMode.Zoom;

                spisok[i].soderzanie.Location = new Point(x, 150);
                spisok[i].soderzanie.Size = new Size(120, 138);
                spisok[i].soderzanie.SizeMode = PictureBoxSizeMode.Zoom;

                spisok[i].soderzanie2.Location = new Point(x, 150);
                spisok[i].soderzanie2.Size = new Size(120, 138);
                spisok[i].soderzanie2.SizeMode = PictureBoxSizeMode.Zoom;

                panel1.Controls.Add(spisok[i].oblojka);
                panel1.Controls.Add(spisok[i].soderzanie);
                panel1.Controls.Add(spisok[i].soderzanie2);

                x = x + 150;
                if (x  + 120 > Width)
                {
                    y = y + 180;
                    x = 10;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
