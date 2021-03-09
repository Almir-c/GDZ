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
        public UchebnikForm(string predmet, string picAdress)
        {
            InitializeComponent();
            try
            {
                pictureBox1.Load("../../Resources/" + predmet + "/" + picAdress + " - обложка.png");
                pictureBox2.Load("../../Resources/" + predmet + "/" + picAdress + " - темы.png");
            }
            catch (Exception)
            {
                try
                {
                    pictureBox1.Load("../../Resources/" + predmet + "/" + picAdress + " - обложка.jpg");
                    pictureBox2.Load("../../Resources/" + predmet + "/" + picAdress + " - темы.jpg");
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
    }
}
