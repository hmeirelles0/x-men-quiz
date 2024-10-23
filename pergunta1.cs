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
    public partial class pergunta1 : Form
    {
        Pontuacao pt = new Pontuacao();
        pergunta2 p2 = new pergunta2();
        private static int aux = 0;
        public pergunta1()
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
            } else
            {
                /*
             Se a resposta correta estiver selecionada no momento do clique do botão,
            através do objeto instanciado o método "atualizarPontos irá receber o inteiro '1', do contrário o inteiro 0.
            Este números serão acrescidos à pontuação total
             */
                if (radioButton3.Checked == true)
                {

                    pt.atualizarPontos(1);
                }
                else
                {
                    pt.atualizarPontos(0);
                    for (int i = 0; i < radioGroup.Length; i++)
                    {
                        if (radioGroup[i].Checked == true) {
                            pt.mostrarAcertos("1-) SELECIONADA: " + radioGroup[i].Text + "\nCORRETA: " + radioButton3.Text);
                        }
                    }
                }
                p2.Show();
                this.Hide();
            }
        } // Fim do evento de button1_click
    }
}
