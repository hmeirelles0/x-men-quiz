using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjQuiz
{
    public class Pontuacao
    {
        private static int pontuacao = 0;
        private static String questoes;

        public int atualizarPontos (int add)
        {
            pontuacao += add;

            return pontuacao;
            /*
            if (add > 1)
            {
                pontuacao = 0;
            } else
            {
                pontuacao += add;
            }
            return pontuacao;
            */
        }

        public String mostrarAcertos (String questao)
        {
            questoes += questao + "\n\n";
            return questoes;
        }
    }
}
