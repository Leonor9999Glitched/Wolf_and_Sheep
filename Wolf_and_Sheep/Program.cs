using System;

namespace Wolf_and_Sheep
{
    class Program
    {
        //Titulo do Jogo
        static string titulodojogo = "Wold and Sheep";
        
        static string[,] tabuleiro = new string [8,8]
        {
           {"B", " P", " B", " P", " B", " P", " B", " P"},
           {"P", " B", " P", " B", " P", " B", " P", " B"},
           {"B", " P", " B", " P", " B", " P", " B", " P"},
           {"P", " B", " P", " B", " P", " B", " P", " B"},
           {"B", " P", " B", " P", " B", " P", " B", " P"},
           {"P", " B", " P", " B", " P", " B", " P", " B"},
           {"B", " P", " B", " P", " B", " P", " B", " P"},
           {"P", " B", " P", " B", " P", " B", " P", " B"},
        };

        static string jogador1 = " W";

        static void Main(string[] args)
        {
            string escolha = "Sou uma string";
            
            Console.Title = titulodojogo;
            Console.WriteLine("Bem-vindos ao jogo Wolf and Sheep!");
            Console.WriteLine("São precisos 2 jogadores para jogar este jogo.");
            Console.WriteLine("O computador não irá jogar com ninguém.");
            Console.WriteLine("O que desejas fazer?");
            Console.WriteLine("1 - Jogar uma partida");
            Console.WriteLine("2 - Regras");
            Console.WriteLine("3 - Sair");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.WriteLine("Esolheste jogar.");
                Console.WriteLine("Jogador 1 será o lobo.");
                Console.WriteLine("Jogador 2 será as ovelhas.");
                Console.WriteLine("B -> Quadrados Brancos");
                Console.WriteLine("P -> Quadrados Pretos");

                //O joagor começa na casa da ultima linha, segundo quadrado negro a começar do fim.
                tabuleiro [7, 5] = jogador1;
                
                //Linha do tabuleiro
                for (int i = 0; i < 8; i++)
                {
                    //Coluna do tabuleiro
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(tabuleiro[i,j]);
                    }
                    Console.WriteLine();
                }
            }
            
            if (escolha == "2")
            {
                Console.WriteLine("Escolheste ver as regras.");
                Console.WriteLine("1 - São precisos dois jogadores.");
                Console.WriteLine("2 - Um jogador será o lobo e o outro será as ovelhas.");
                Console.WriteLine("3 - O lobo move-se primeiro.");
                Console.WriteLine("4 - No turno a seguir ao lobo, o jogador das ovelhas pode mover uma, e só uma, ovelha.");
                Console.WriteLine("5 - O objectivo do lobo é chegar a uma das casas onde estavam as ovelhas.");
                Console.WriteLine("6 - O objectivo das ovelhas é bloquear o lobo.");
                Console.WriteLine("7 - O lobo ganha se conseguir às casa das ovelhas.");
                Console.WriteLine("8 - As ovelhas ganham se conseguirem bloquear o lobo.");
                Console.WriteLine("9 - As ovelhas só podem mover-se para a frente e nas diagonais, uma casa. As ovelhas não podem recuar.");
                Console.WriteLine("10 - O lobo pode mexer para a frente, para trás e nas diagonais, uma casa. O lobo pode recuar.");
                Console.WriteLine("11 - A partida acaba quando se declarar um vencedor");
            }
            
            if (escolha == "3")
            {
                Console.WriteLine("Escolheste sair do jogo.");
                Console.WriteLine("Até para a proxima.");
            }

        }
    }
}
