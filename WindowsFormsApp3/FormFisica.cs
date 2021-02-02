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
    public partial class FormFisica : Form
    {
        public FormFisica(string predmet, string picAdress)
        {
            InitializeComponent();
            pictureBox1.Load("../../Resources/" + picAdress + ".png");
            pictureBox2.Load("../../Resources/" + picAdress + " - темы.png");
        }

        private void FormFisica_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
