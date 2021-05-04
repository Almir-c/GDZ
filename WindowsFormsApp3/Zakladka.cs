﻿using System;
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
    public partial class Zakladka : Form
    {
        public Zakladka()
        {
            InitializeComponent();

            if (Form1.Language == "Английский")
                translate(Form1.EngWords);
            if (Form1.Language == "Русский")
                translate(Form1.RusWords);

            int x = 10;
            foreach (Uchebniki uch in Form1.zakladka)
            {
                //Добавляем картинку
                UchebControl oblojka = new UchebControl(uch);
                oblojka.Location = new Point(x, 150);
                Controls.Add(oblojka);
                x = x + 150;
                if (x + 120 > Width)
                {
                    //y = y + 180;
                    //x = 10;
                }
            }
        }

        private void translate(Dictionary<string, string> Words)
        {
            Text = Words["Выбранные учебники"];
        }

        private void Zakladka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("mikki.abrams1234567890@gmail.com", "Училка");
            // кому отправляем
            MailAddress to = new MailAddress("beavisabra@yandex.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "Ваши любимые deep dark fantasies";
            File.WriteAllText("Ucheb.csv","Автор,Предмет");
            foreach (Uchebniki uch in Form1.zakladka)
            {
                File.AppendAllText("Ucheb.csv",
                    Environment.NewLine +
                    uch.Author + "," + uch.discipline);
            }

            m.Attachments.Add(new Attachment("Ucheb.csv"));
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(from.Address, "Beavis123");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Прилетело");
        }
    }
}

