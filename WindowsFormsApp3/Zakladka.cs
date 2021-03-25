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
            int x = 10;
            foreach (Uchebniki uch in Form1.zakladka)
            {
                //Добавляем картинку
                PictureBox oblojka = new PictureBox();
                oblojka.Image = uch.oblojka.Image;
                oblojka.Location = new Point(x, 150);
                oblojka.Size = new Size(120, 138);
                oblojka.SizeMode = PictureBoxSizeMode.Zoom;
                oblojka.Click += new EventHandler(PredmetForm.OpenUchebnik);//надо вывести табличку с надписью "добавлено"
                Controls.Add(oblojka);
                x = x + 150;
                if (x + 120 > Width)
                {
                    //y = y + 180;
                    //x = 10;
                }
            }
        }
    }
}

