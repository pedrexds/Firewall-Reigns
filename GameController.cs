using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireWall_Reigns
{
    public class GameController
    {
        private int fase;

        public GameController(int fase)
        {
            this.fase = fase;
        }

        public void conferePontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios)
        {
            if(privacidade.getPontuacao() <= 0)
            {
                Console.WriteLine("Privacidade Zerada. Game Over!");
            }

            if(privacidade.getPontuacao() >= 100)
            {
                Console.WriteLine("Privacidade Maximizada. Game Over!");
            }

            if(recursos.getPontuacao() <= 0)
            {
                Console.WriteLine("Recursos Zerados. Game Over!");
            }

            if(recursos.getPontuacao() >= 100)
            {
                Console.WriteLine("Recursos Maximizados. Game Over!");
            }

            if(seguranca.getPontuacao() <= 0)
            {
                Console.WriteLine("Usuários Zerados. Game Over!");
            }

            if(usuarios.getPontuacao() <= 0)
            {
                Console.WriteLine("Usuários Zerados. Game Over!");
            }

            if(usuarios.getPontuacao() >= 100)
            {
                Console.WriteLine("Usuários Maximizados. Game Over!");
            }
        }

        public void mostraPontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios)
        {
            Console.WriteLine("Privacidade: " + privacidade.getPontuacao() + "\nRecursos: " + recursos.getPontuacao() + "\nSegurança: " + seguranca.getPontuacao() + "\nUsuários: " + usuarios.getPontuacao());
        }
    }
}
