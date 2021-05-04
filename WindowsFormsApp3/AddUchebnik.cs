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
    public partial class AddUchebnik : Form
    {
        public AddUchebnik()
        {
            InitializeComponent();
        }

        private void AddUchebnik_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("../../../Учебники.txt", 
                Environment.NewLine + 
                textBox1.Text + ", 0, " + comboBox1.Text + ", 7");
            MessageBox.Show("О да");

            if (address != "")
                File.Copy(address, "../../Resources/" +
                        comboBox1.Text + "/7 класс " +
                        textBox1.Text + " - обложка.jpg");
        }

        string address = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }
    }
}
