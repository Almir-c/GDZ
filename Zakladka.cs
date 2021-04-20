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
    public partial class Zakladka : Form
    {
        public Zakladka()
        {
            InitializeComponent();

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);

            int x = 10;
            foreach (Uchebniki uch in Form1.zakladka)
            {
                //Добавляем картинку
                UchebControl oblojka = new UchebControl(uch);
                oblojka.Location = new Point(x, 150);
                Controls.Add(oblojka);
                x = x + 150;
                if (x + 120 > Width)
                {
                    //y = y + 180;
                    //x = 10;
                }
            }
        }

        private void translate(Dictionary<string, string> Words)
        {
            Text = Words["Выбранные учебники"];
        }

        private void Zakladka_Load(object sender, EventArgs e)
        {

        }
    }
}

