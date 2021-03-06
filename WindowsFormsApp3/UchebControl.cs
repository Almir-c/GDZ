﻿using System;
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
    public partial class UchebControl : UserControl
    {
        Uchebniki uch1;

        public UchebControl(Uchebniki uch)
        {
            uch1 = uch;
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
            pictureBox1.Image = uch.oblojka.Image;
            label1.Text = "Автор: " + uch.Author + " Класс: " + uch.YourIq;
            pictureBox1.Click += new EventHandler(PredmetForm.OpenUchebnik);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.zakladka.Remove(uch1);
            this.Parent = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
