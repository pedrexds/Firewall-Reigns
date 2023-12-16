using System;

namespace FireWall_Reigns
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gc = new GameController(1);
            Entidades privacidade = new Entidades(50);
            Entidades recursos = new Entidades(50);
            Entidades seguranca =  new Entidades(50);
            Entidades usuarios = new Entidades(50);
            
            gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
            Console.WriteLine();

            privacidade.setPontuacao(-5);
            recursos.setPontuacao(50);
            seguranca.setPontuacao(-25);
            usuarios.setPontuacao(12);

            gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

            gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
        }
    }
}
