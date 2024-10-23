﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjQuiz
{
    public partial class pergunta7 : Form
    {
        Pontuacao pt = new Pontuacao();
        pergunta8 p8 = new pergunta8();
        private static int aux = 0;
        public pergunta7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton[] radioGroup =
{
    radioButton1,
    radioButton2,
    radioButton3,
    radioButton4,
    radioButton5
};

            for (int i = 0; i < radioGroup.Length; i++)
            {
                if (radioGroup[i].Checked == true)
                {
                    aux++;
                }
            }

            if (aux == 0)
            {
                MessageBox.Show("Favor, escolha uma dentre as opções da pergunta antes de prosseguir.");
            }
            else
            {
                if (radioButton5.Checked == true)
                {
                    pt.atualizarPontos(1);
                }
                else
                {
                    pt.atualizarPontos(0);
                    for (int i = 0; i < radioGroup.Length; i++)
                    {
                        if (radioGroup[i].Checked == true)
                        {
                            pt.mostrarAcertos("7-) SELECIONADA: " + radioGroup[i].Text + "\nCORRETA: " + radioButton5.Text);
                        }
                    }
                }
                p8.Show();
                this.Hide();
            }
        }
    }
}
