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
    public partial class UchebnikForm : Form
    {
        Uchebniki uch;
        public UchebnikForm(string predmet, string schoolClass, string author)
        {
            InitializeComponent();


            foreach (Uchebniki uch1 in Form1.spisok)
            {
                /// Ищем нужный учебник
                if (predmet == uch1.discipline &&
                    author == uch1.Author)
                {
                    uch = uch1;
                    break;
                }
            }


            try
            {
                pictureBox1.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - обложка.png");
                pictureBox2.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - темы.png");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - обложка.jpg");
                    pictureBox2.Load("../../Resources/" + predmet + "/" + schoolClass + " класс " + author + " - темы.jpg");
                }
                catch (Exception)
                {
                } 
            }
            //pictureBox2.Load("../../Resources/" + predmet + "/" + picAdress + " - темы.png");
        }

        private void FormFisica_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.zakladka.Add(uch);
            MessageBox.Show("Ha! You gay!");
        }
    }
}
