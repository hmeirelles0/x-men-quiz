using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjQuiz
{
    public partial class Form2 : Form
    {
        Pontuacao pt = new Pontuacao();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int total = pt.atualizarPontos(0);
            lblPontos.Text = "Pontuação total: " + pt.atualizarPontos(0).ToString() + " de 10\n" + pt.mostrarAcertos("");


            /*
            if (pt.atualizarPontos(0) < 4)
            {
                
                lblPontos.Text = "Pontuação total: " + pt.atualizarPontos(0).ToString() + " de 10\nQue tal acompanhar as aventuras dos mutantes na nova série da Disney+, X-Men '97?";  
            } else if (pt.atualizarPontos(0) < 6)
            {
                lblPontos.Text = "Pontuação total: " + pt.atualizarPontos(0).ToString() + " de 10\nVocê está bem familiarizado(a) com os mutantes!";
            } else
            {
                lblPontos.Text = "Pontuação total: " + pt.atualizarPontos(0).ToString() + " de 10\nVocê conhece os mutantes e suas HQs com a palma da sua mão! Parabéns!";
            }
            */
        }
    }
}
