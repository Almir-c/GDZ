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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
