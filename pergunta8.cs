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
    public partial class pergunta8 : Form
    {
        Pontuacao pt = new Pontuacao();
        pergunta9 p9 = new pergunta9();
        private static int aux = 0;
        public pergunta8()
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
                if (radioButton1.Checked == true)
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
                            pt.mostrarAcertos("8-) SELECIONADA: " + radioGroup[i].Text + "\nCORRETA: " + radioButton1.Text);
                        }
                    }
                }
                p9.Show();
                this.Hide();
            }
        }
    }
}
