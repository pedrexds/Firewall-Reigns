using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireWall_Reigns
{
    public class Cartas
    {
        private string fato;
        public int ptsPriv;
        public int ptsRecs;
        public int ptsSegu;
        public int ptsUser;

        public Cartas(string acontecimento, int p1, int p2, int p3, int p4)
        {
            this.fato = acontecimento;
            this.ptsPriv = p1;
            this.ptsRecs = p2;
            this.ptsSegu = p3;
            this.ptsUser = p4;
        }

        public void aplicaPontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios)
        {
            privacidade.setPontuacao(ptsPriv);
            recursos.setPontuacao(ptsRecs);
            seguranca.setPontuacao(ptsSegu);
            usuarios.setPontuacao(ptsUser);
        }
    }
}
