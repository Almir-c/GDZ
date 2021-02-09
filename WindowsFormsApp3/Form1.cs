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
        public string Author;
        public int YourIq; 
    }

    public partial class Form1 : Form
    {
        Uchebniki[] spisok = new Uchebniki[3];
        public Form1()
        {
            InitializeComponent();

            spisok[0].oblojka = pictureBox2; 
            spisok[0].Author = "Петушков";
            spisok[0].YourIq = 0;

            spisok[1].oblojka = pictureBox3;
            spisok[1].Author = "Абрамов";
            spisok[1].YourIq = -1;

            spisok[2].oblojka = pictureBox2;
            spisok[2].Author = "Машкова";
            spisok[2].YourIq = 100;
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
                if (!spisok[i].Author.Contains(textBoxForm1.Text))
                    spisok[i].oblojka.Visible = false;

            }
        }
    }
}
