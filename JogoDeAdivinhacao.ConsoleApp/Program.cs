namespace JogoDeAdivinhacao.ConsoleApp
{ //HISTORICO
    internal class Program
    {
        static void Main(string[] args)
        {
            //LOOP
           while(true)
            {
                Console.Clear();
                Console.WriteLine( "-----------------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("-----------------------------------------------");

                Console.WriteLine("Escolha um NÍVEL DE DIFICULDADE");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1 - FÁCIL (1O TENTATIVAS)");
                Console.WriteLine("2 - NORMAL (5 TENTATIVAS)");
                Console.WriteLine("3 - DIFÍCIL (3 TENTATIVAS)");

                int totalDeTentativas = 0;

                Console.Write("DIGITE sua ESCOLHA DE DIFICULDADE: ");
                String opcaoDificuldade = Console.ReadLine();

                if (opcaoDificuldade == "1")
                    totalDeTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalDeTentativas = 5;
                else
                    totalDeTentativas = 3;

                Console.Clear();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("-----------------------------------------------");

                //GERAÇÃO ALEATÓRIA DE NÚMERO
                Random geradorNumeros = new Random();

                int numeroSecreto = geradorNumeros.Next(1, 21); //0 - 1 *se atentar ao max ser sempre 1 a mais
                
                //LÓGICA
               
                for (int tentativas = 1; tentativas <= totalDeTentativas; tentativas++)
                {
                    Console.Write("Digite um Número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    if (numeroSecreto == numeroDigitado)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(" \nVocê acertou o número SECRETO meu truta!!! Parabéns!");
                        Console.WriteLine("-----------------------------------------------");
                        Console.ReadLine();
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(" O número informado é MAIOR que o número SECRETO!");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Tentativa {tentativas} de {totalDeTentativas}");
                        
                        
                    
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine(" O número informado é MENOR que o número SECRETO!");
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine($"Tentativa {tentativas} de {totalDeTentativas}");
                       
                       
                    }

                    if (tentativas == totalDeTentativas)
                    {
                        Console.WriteLine("\nQue pena! Você não acertou... O número secreto era: " + numeroSecreto);
                        break;
                    }

                   
                   
                }
                Console.WriteLine("Deseja Continuar? (S/N)");
                string continuar = Console.ReadLine().ToLower();

                if (continuar != "s")
                    break;

            }
        }
    }
}
