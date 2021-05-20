using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ZvyazForm : Form
    {
        public ZvyazForm()
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
        }

        private void TemBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otprbutton_Click(object sender, EventArgs e)
        {
            if (TemBox.Text == "")
            {
                MessageBox.Show("Укажите тему");
                return;
            }
            if (NumberBox2.Text == "")
            {
                MessageBox.Show("Укажите почту / номер");
                return;
            }
            MailAddress from = new MailAddress("mikki.abrams1234567890@gmail.com", "Пользователь");
            MailAddress to = new MailAddress("beavisabra@yandex.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Сообщение" + TemBox.Text;
            m.Body = textBox1.Text + 
                Environment.NewLine +
                Environment.NewLine + "Контакт:" + NumberBox2.Text;
            if (adress != "")
            {
                Attachment att = new Attachment(adress);
                att.Name = "GDZpicture.jpg";
                m.Attachments.Add(att);
            }

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(from.Address, "Beavis123");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Письмо отправлено");


        }

        string adress = "";

        private void NumberBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
