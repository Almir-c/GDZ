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
    public partial class hiForm : Form
    {
        public static string Login = "";
        List<string> Users = new List<string>();
        public hiForm()
        {
            InitializeComponent();
            if (Form1.IsDarkTheme)
            {
                BackColor = Color.FromArgb(45, 45, 48);

                ForeColor = Color.FromArgb(255, 255, 255);

            }
            else
            {
                BackColor = Color.FromArgb(255, 255, 255);
                ForeColor = Color.FromArgb(0, 0, 0);

            }
            Users = new List<string>();
            Users.Add("Admin"); Users.Add("228337");
            Users.Add(""); Users.Add("");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Login = textBox1.Text;
            Form1 forn = new Form1();
            forn.ShowDialog();
            Close();

            bool sl = false;

            for (int i = 0; i < Users.Count; i += 2)
            {
                if (textBox2.Text == Users[i] && 
                    textBox2.Text == Users[i+1])
                {
                    Login = textBox1.Text;
                    Close();
                    sl = true;

                }
            }
            if (!sl)
                MessageBox.Show("Вiйди от сюда");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load("../../Resources/welcom.jpg");
        }
    }
}
