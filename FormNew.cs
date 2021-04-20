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
                textBox1.Text + ", 0, 1, " + comboBox1.Text + ", 7");
            MessageBox.Show("Вы добавили новый учебник");

            if (adress != "")
                File.Copy(adress, "../../Resources/" +
                    comboBox1.Text + "/7 класс " +
                    textBox1.Text + " - обложка.jpg");
            if (adress2 != "")
                File.Copy(adress2, "../../Resources/" +
                    comboBox1.Text + "/7 класс " +
                   textBox1.Text + " - темы.jpg");
        }

        string adress = "";
        string adress2 = "";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
               if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox2.Load(adress);       
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress2 = openFileDialog1.FileName;
                pictureBox3.Load(adress2);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
