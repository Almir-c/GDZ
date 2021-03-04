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

            label1.Text = File.ReadAllText("../../Resources/" + predmet + ".txt");
            pictureBox1.Load("../../Resources/" + predmet + ".png");
            pictureBox1.Tag = predmet;

            if (predmet == "Русский язык")
            {
                label1.Text = "Выберите учебник";
                pictureBox2.Load("../../Resources/русский2.png");
                pictureBox2.Tag = "русский2";
            }
            if (predmet == "Физика")
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
                FormFisica fisica2 = new FormFisica(predmet, pictureBox2.Tag.ToString());
                fisica2.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //if (predmet == "Русский язык")
            {
                FormFisica fisica = new FormFisica(predmet, pictureBox1.Tag.ToString());
                fisica.Show();
            }
        }
    }
}
