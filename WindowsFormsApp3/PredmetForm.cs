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

            label1.Text = File.ReadAllText("../../Resources/" + predmet1 + ".txt");
            pictureBox1.Load("../../Resources/" + predmet1 + ".png");
            pictureBox1.Tag = predmet;

            if (predmet1 == "Русский язык")
            {
                label1.Text = "Выберите учебник";
                pictureBox1.Load("../../Resources/Русский язык/4 класс Каленчук - обложка.jpg");
                pictureBox1.Tag = "4 класс Каленчук";
                pictureBox2.Load("../../Resources/Русский язык/7 класс Машкова - обложка.png");
                pictureBox2.Tag = "7 класс Машкова";
            }
            if (predmet1 == "Физика")
            {
                label1.Text = "Выберите учебник";
                pictureBox2.Load("../../Resources/Физика.png");
                pictureBox2.Tag = "Физика";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //if (predmet == "Русский язык")
            {
                UchebnikForm fisica2 = new UchebnikForm(predmet, pictureBox2.Tag.ToString());
                fisica2.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //if (predmet == "Русский язык")
            {
                UchebnikForm fisica = new UchebnikForm(predmet, pictureBox1.Tag.ToString());
                fisica.Show();
            }
        }

        private void PredmetForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Form1.zakladka.Add(like);

        }
    }
}
