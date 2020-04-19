using System;

namespace Wolf_and_Sheep
{
    class Program
    {
        //Titulo do Jogo
        static string titulodojogo = "Wold and Sheep";
        
        //Criação do tabuleiro do jogo
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

       //Definição do lobo e das ovelhas
        static string jogador1 = " W";

        static int linha = 7;
        static int coluna = 5;

        //Codigo Principal
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

            //O jogador escolheu jogar
            if (escolha == "1")
            {
                Console.WriteLine("Esolheste jogar.");
                Console.WriteLine("Jogador 1 será o lobo.");
                Console.WriteLine("Jogador 2 será as ovelhas.");
                Console.WriteLine("B -> Quadrados Brancos");
                Console.WriteLine("P -> Quadrados Pretos");

                //O joagor começa na casa da ultima linha, segundo quadrado negro a começar do fim.
                tabuleiro [7, 4] = jogador1;
                
                //Linha do tabuleiro

                bool derrota = false;
                
                while(!derrota)
                {

                    for (int i = 0; i < 8; i++)
                {
                    //Coluna do tabuleiro
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write(tabuleiro[i,j]);
                    }
                    Console.WriteLine();
                }
                    Console.WriteLine("");
                    Console.WriteLine("Para onde queres ir, lobo?");
                    Console.WriteLine("W - Para cima");
                    Console.WriteLine("A - Para a esquerda");
                    Console.WriteLine("S - Para baixo");
                    Console.WriteLine("D - Para a direita");
                    Console.WriteLine("");
                    Console.WriteLine("O seu comando é: ");

                    string comando = Console.ReadLine().ToUpper();

                    //Movimentos do lobo
                    if (comando == "W")
                    {
                        if (tabuleiro[linha - 2, coluna] == "P")
                        {
                            tabuleiro[linha, coluna] = "P";
                            linha = linha - 2;
                        }
                    }
                    else if (comando == "A")
                    {
                        if (tabuleiro[linha, coluna - 2] == "P")
                        {
                            tabuleiro[linha, coluna] = "P";
                            coluna = coluna - 2;
                        }    
                    }
                    else if (comando == "S")
                    {
                        if (tabuleiro[linha + 2, coluna] == "P")
                        {
                            tabuleiro[linha, coluna] = "P";
                            linha = linha + 2;
                        }    
                    }
                    else if (comando == "D")
                    {
                        if (tabuleiro[linha, coluna + 2] == "P")
                        {
                            tabuleiro[linha, coluna] = "P";
                            coluna = coluna + 2;
                        }
                    }

                    tabuleiro[linha, coluna] = jogador1;
                }
                
            }
            
            //O jogador escolheu ver as regras do jogo
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
            
            //O jogador escolheu sair do jogo
            if (escolha == "3")
            {
                Console.WriteLine("Escolheste sair do jogo.");
                Console.WriteLine("Até para a proxima.");
            }

        }
    }
}
