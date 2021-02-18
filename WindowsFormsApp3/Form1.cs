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
    }

    public partial class Form1 : Form
    {
        Uchebniki[] spisok = new Uchebniki[300];
        public Form1()
        {
            InitializeComponent();

            spisok[0].Author = "Петушков";
            spisok[0].YourIq = 0;

            spisok[1].Author = "Абрамов";
            spisok[1].YourIq = -1;
            

            spisok[2].Author = "Машкова";
            spisok[2].YourIq = 100;

            spisok[2].Author = "Владимиров";
            spisok[2].YourIq = 50;

            spisok[2].Author = "Anonim";
            spisok[2].YourIq = 1000;

            spisok[2].Author = "Верблюдов";
            spisok[2].YourIq = 25;

            int x = 10;
            int y = 20;
            for (int i = 0; i < 8; i++)
            {
                spisok[i].oblojka = new PictureBox();
                spisok[i].soderzanie = new PictureBox();
                spisok[i].soderzanie2 = new PictureBox();

                try
                {
                    spisok[i].oblojka.Load("../../Resources/" + spisok[i].Author + ".jpg");
                    spisok[i].soderzanie.Load("../../Resources/" + spisok[i].Author + " (2).jpg");
                    spisok[i].soderzanie2.Load("../../Resources/" + spisok[i].Author + " (3).jpg");
                }
                catch (Exception)
                {
                    spisok[i].oblojka.Load("../../Resources/какава.png");
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
            for (int i = 0; i < 3; i++) 
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
