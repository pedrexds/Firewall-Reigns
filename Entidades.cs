using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireWall_Reigns
{
    public class Entidades
    {
        protected int pontuacao;

        public Entidades(int startPontuacao)
        {
            this.pontuacao = startPontuacao;
        }

        public int getPontuacao()
        {
            return this.pontuacao;
        }

        public void setPontuacao(int pontos)
        {
            this.pontuacao = this.pontuacao + pontos;
        }
    }
}
