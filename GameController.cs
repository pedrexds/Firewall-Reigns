using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FireWall_Reigns
{
    public class GameController
    {
        private int fase;
        public bool gameOver;
        public int diferenca;

        public GameController(int fase)
        {
            this.fase = fase;
            this.gameOver = false;
        }

        public void conferePontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios)
        {
            if(seguranca.getPontuacao() >= 100)
            {
                diferenca = seguranca.getPontuacao() - 100;
                seguranca.setPontuacao(-diferenca);
            }
            if(privacidade.getPontuacao() <= 0)
            {
                Console.WriteLine("Privacidade Zerada. Game Over!");
                this.gameOver = true;
            }

            if(privacidade.getPontuacao() >= 100)
            {
                Console.WriteLine("Privacidade Maximizada. Game Over!");
                this.gameOver = true;
            }

            if(recursos.getPontuacao() <= 0)
            {
                Console.WriteLine("Recursos Zerados. Game Over!");
                this.gameOver = true;
            }

            if(recursos.getPontuacao() >= 100)
            {
                Console.WriteLine("Recursos Maximizados. Game Over!");
                this.gameOver = true;
            }

            if(seguranca.getPontuacao() <= 0)
            {
                Console.WriteLine("Usuários Zerados. Game Over!");
                this.gameOver = true;
            }

            if(usuarios.getPontuacao() <= 0)
            {
                Console.WriteLine("Usuários Zerados. Game Over!");
                this.gameOver = true;
            }

            if(usuarios.getPontuacao() >= 100)
            {
                Console.WriteLine("Usuários Maximizados. Game Over!");
                this.gameOver = true;
            }
        }

        public void mostraPontuacao(Entidades privacidade, Entidades recursos, Entidades seguranca, Entidades usuarios)
        {
            Console.WriteLine("Privacidade: " + privacidade.getPontuacao() + "\nRecursos: " + recursos.getPontuacao() + "\nSegurança: " + seguranca.getPontuacao() + "\nUsuários: " + usuarios.getPontuacao());
        }

        public int[] aleatorizadorDeFases(int[] vet)
        {
            Random rand = new Random();

            for (int i = vet.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(0, i + 1);
                int temp = vet[i];
                vet[i] = vet[j];
                vet[j] = temp;
            }

            return vet;
        }
    }
}
