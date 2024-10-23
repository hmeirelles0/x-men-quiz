using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace prjQuiz
{
    public partial class Form1 : Form
    {
        SoundPlayer song = new SoundPlayer(@"scifi.wav");
        pergunta1 p1 = new pergunta1();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            p1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            song.PlayLooping();
        }

        private void rdoDesliga_Click(object sender, EventArgs e)
        {
            song.Stop();
        }

        private void rdoLiga_Click(object sender, EventArgs e)
        {
            song.PlayLooping();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hmeirelles0?tab=repositories");
        }
    }
}
