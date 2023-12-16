using System;

namespace FireWall_Reigns
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta1;
            Cartas instagramRealOp1 = new Cartas("Perfil Público", -5, -5, -10, 0);
            Cartas instagramRealOp2 = new Cartas("Perfil Privado", 5, -5, 0, -20);
            GameController gc = new GameController(1);
            Entidades privacidade = new Entidades(50);
            Entidades recursos = new Entidades(50);
            Entidades seguranca =  new Entidades(50);
            Entidades usuarios = new Entidades(50);
            
            gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
            
            Console.WriteLine("Instagram Real: Opção 1 ou 2?");
            resposta1 = Int32.Parse(Console.ReadLine());
            if(resposta1 == 1)
            {
                instagramRealOp1.aplicaPontuacao(privacidade, recursos, seguranca, usuarios);
            }
            else
            {
                instagramRealOp2.aplicaPontuacao(privacidade, recursos, seguranca, usuarios);
            }

            gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

            gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
        }
    }
}
