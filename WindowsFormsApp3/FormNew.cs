using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("../../../Учебники.txt",
                Environment.NewLine +
                textBox1.Text + ", 0, " + comboBox1.Text + ", 7");
            MessageBox.Show("Вы добавили новый учебник");

            if (adress != "")
                File.Copy(adress, "../../Resources/" +
                    comboBox1.Text + "/7 класс" +
                    textBox1.Text + " - обложка.jpg");
        }

        string adress = "";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox2.Load(adress);       
            }
        }

        
    }
}
