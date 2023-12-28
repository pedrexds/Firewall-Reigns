using System;

namespace FireWall_Reigns
{
    class Program
    {
        static void Main(string[] args) //Priv, Recs, Segu, User
        {
            Cartas ataqueCibernetico = new Cartas(0, "Majestade, seu computador está sendo atacado por invasores cibernéticos!", "Ativar o anti-vírus", 5, 0, 25, 0, "Tirar o pc da tomada", -30, -20, -30, 0, false, false);
            Cartas deepFakeReal = new Cartas(1, "Uma pessoa mal intencionada está se passando pelo senhor usando deep fake e espalhando que o povo poderá usar softwares pagos gratuitamente apenas clicando em um link espalhado pelo WhatsApp.", "Investigar as deep fakes e se retratar para o reino", 0, 0, 10, 5, "O povo ficará feliz em não gastar dinheiro para baixar", 0, -25, -15, 15, false, false);
            Cartas privacidadeReal =  new Cartas(2, "Realeza, devemos implementar novas políticas de privacidade no reino?", "Implementar leis para proteger a privacidade dos cidadãos", 20, 15, 10, 5, "Não supervisionar os dados", -30, -10, -10, 0, false, false);
            Cartas reconhecimentoFacial = new Cartas(3, "Seu reino pode ficar muito mais seguro com a implementação de um sistema de reconhecimento facial. O que acha, majestade?", "Implementar a medida proposta", -15, -20, 10, 0, "Manter métodos tradicionais de segurança", 0, 0, 0, 0, false, false);
            Cartas vazamentoReal = new Cartas(4, "Majestade, alguns dos nossos dados foram vazados na rede, o que devemos fazer?", "Descobrir responsáveis e impor punições", 10, 10, 5, 0, "Divulgar todas as informações publicamente gerando transparência", -25, -20, -20, 0, false, false);
            Cartas ataqueDDoS = new Cartas(5, "Meu rei, recebemos ameaças de ataques DDoS que podem prejudicar os serviços online", "Alocar recursos para proteção contra ataques DDoS", 0, 10, 30, 0, "Distribuir serviços para minimizar impactos", 0, -10, -30, 0, false, false);
            Cartas discursoDeOdio = new Cartas(6, "Seus súditos estão espalhando discurso de ódio pelas redes. Qual medida devemos tomar?", "Lance uma campanha online contra o discurso de ódio", 0, -5, 10, 15, "Mantenha uma abordagem mais livre, mas com observação", 0, 0, -15, -25, false, false);
            Cartas conscientizacaoOnline = new Cartas(7, "Majestade, o que acha de alertarmos os súditos sobre o uso adequado da internet?", "Investir em programas educativos", 0, -5, 15, 5, "Concentrar recursos em outras prioridades", 0, 0, -15, -10, false, false);
            Cartas cyberbullying = new Cartas(8, "Majestade, as crianças vêm sendo zoadas com brincadeiras de mal gosto online nas escolas. como melhoramos isso?", "Reforçar a vigilância online para identificar e interromper casos de cyberbullying", -5, -10, 30, 20, "Ignorar, pois é brincadeira de criança", 0, 0, -20, -20, false, false);
            Cartas influenciaEstrangeira = new Cartas(9, "Alteza, temos rumores de influência estrangeira nas redes sociais que estão causando divisões entre os cidadãos digitais", "Buscar experiências e exportar influência estrangeira", -25, 15, -10, 20, "Minimizar o impacto e continuar governando", -25, -10, -10, -20, false, false);

            GameController gc = new GameController(1);
            Entidades privacidade = new Entidades(50);
            Entidades recursos = new Entidades(50);
            Entidades seguranca =  new Entidades(50);
            Entidades usuarios = new Entidades(50);
            int[] fases = new int[10] {0,1,2,3,4,5,6,7,8,9};
            int[] ordemFases = gc.aleatorizadorDeFases(fases);
            int idCarta = ordemFases[0];
            int i = 0;
            /*Console.WriteLine("Main:\n" + ordemFases[0] + " " + ordemFases[1] + " " + ordemFases[2] + " " + ordemFases[3] + " " + ordemFases[4] + " " + ordemFases[5] + " " + ordemFases[6] + " " + ordemFases[7] + " " + ordemFases[8] + " " + ordemFases[9]);*/
            
            gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
            
            while(gc.gameOver == false)
            {
                switch(idCarta)
                {
                    case 0:
                        Console.WriteLine();
                        ataqueCibernetico.imprimirInfoCarta();

                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            ataqueCibernetico.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            ataqueCibernetico.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 1:
                        Console.WriteLine();
                        deepFakeReal.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            deepFakeReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            deepFakeReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 2: 
                        Console.WriteLine();
                        privacidadeReal.imprimirInfoCarta();

                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            privacidadeReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            privacidadeReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 3:
                        Console.WriteLine();
                        reconhecimentoFacial.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            reconhecimentoFacial.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            reconhecimentoFacial.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;
                    
                    case 4: 
                        Console.WriteLine();
                        vazamentoReal.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            vazamentoReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            vazamentoReal.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 5:
                        Console.WriteLine();
                        ataqueDDoS.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            ataqueDDoS.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            ataqueDDoS.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 6:
                        Console.WriteLine();
                        discursoDeOdio.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            discursoDeOdio.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            discursoDeOdio.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 7:
                        Console.WriteLine();
                        conscientizacaoOnline.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            conscientizacaoOnline.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            conscientizacaoOnline.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;

                    case 8:
                        Console.WriteLine();
                        cyberbullying.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            cyberbullying.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            cyberbullying.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;
                    
                    case 9:
                        Console.WriteLine();
                        influenciaEstrangeira.imprimirInfoCarta();
                    
                        if(Int32.Parse(Console.ReadLine()) == 1)
                        {
                            ataqueCibernetico.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, true, false);
                        }
                        else
                        {
                            ataqueCibernetico.aplicaPontuacao(privacidade, recursos, seguranca, usuarios, false, true);
                        }

                        gc.conferePontuacao(privacidade, recursos, seguranca, usuarios);

                        gc.mostraPontuacao(privacidade, recursos, seguranca, usuarios);
                        break;
                }

                i++;

                if(i>9)
                {
                    break;
                }

                idCarta = ordemFases[i];
            }

            if(gc.gameOver == false)
            {
                Console.WriteLine("Parabéns, seu reinado é um sucesso!");
            }
        }
    }
}
