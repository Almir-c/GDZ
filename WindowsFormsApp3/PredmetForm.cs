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
    public partial class PredmetForm : Form
    {
        string predmet;
        public PredmetForm(string predmet1)
        {
            predmet = predmet1;
            InitializeComponent();

            if (predmet == "Алгебра")
            {
                label1.Text = "Гдз по алгебре стырили";
                pictureBox1.Load("../../Resources/Вор.png");
            }

            if (predmet == "Физика")
            {
                label1.Text = "Остальные ответы на номера в других учебниках \n можно плоучить за 100 рублей";
                pictureBox1.Load("../../Resources/фызика.jpg");
            }

            if (predmet == "Русский язык")
            {
                label1.Text = "Выберите учебник";
                pictureBox1.Load("../../Resources/русский1.jpg");
                pictureBox2.Load("../../Resources/русский2.jpg");
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
            if (predmet == "Русский язык")
            {
                FormFisica fisica2 = new FormFisica("Русский язык", "русский2");
                fisica2.Show();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (predmet == "Русский язык")
            {
                FormFisica fisica = new FormFisica("Русский язык", "русский1");
                fisica.Show();
            }
        }
    }
}
