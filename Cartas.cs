using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireWall_Reigns
{
    public class Cartas
    {
        private int numeroDaCarta;
        public string fato;
        public string opcao1;
        public string opcao2;
        public int ptsPrivOp1;
        public int ptsRecsOp1;
        public int ptsSeguOp1;
        public int ptsUserOp1;
        public int ptsPrivOp2;
        public int ptsRecsOp2;
        public int ptsSeguOp2;
        public int ptsUserOp2;
        public bool escolhido1;
        public bool escolhido2;

        public Cartas(int numCarta, string acontecimento, string opt1, int priv1, int recs1, int segu1, int user1, string opt2, int priv2, int recs2, int segu2, int user2, bool choice1, bool choice2)
        {
            this.numeroDaCarta = numCarta;
            this.fato = acontecimento;
            this.opcao1 = opt1;
            this.ptsPrivOp1 = priv1;
            this.ptsRecsOp1 = recs1;
            this.ptsSeguOp1 = segu1;
            this.ptsUserOp1 = user1;
            this.opcao2 = opt2;
            this.ptsPrivOp2 = priv2;
            this.ptsRecsOp2 = recs2;
            this.ptsSeguOp2 = segu2;
            this.ptsUserOp2 = user2;
            this.escolhido1 = choice1;
            this.escolhido2 = choice2;
        }

        public void aplicaPontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios, bool option1, bool option2)
        {
            if(option1)
            {
                privacidade.setPontuacao(this.ptsPrivOp1);
                recursos.setPontuacao(this.ptsRecsOp1);
                seguranca.setPontuacao(this.ptsSeguOp1);
                usuarios.setPontuacao(this.ptsUserOp1);
            }
            else if(option2)
            {
                privacidade.setPontuacao(this.ptsPrivOp2);
                recursos.setPontuacao(this.ptsRecsOp2);
                seguranca.setPontuacao(this.ptsSeguOp2);
                usuarios.setPontuacao(this.ptsUserOp2);        
            }
        }

        public void imprimirInfoCarta()
        {
            Console.WriteLine(this.fato + "\n\n1 - " + this.opcao1 + "\n\n2 - " + this.opcao2 + "\n\n");
        }
    }
}
