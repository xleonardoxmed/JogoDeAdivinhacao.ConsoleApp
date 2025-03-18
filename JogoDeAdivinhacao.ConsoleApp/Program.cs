using System.Reflection.Metadata.Ecma335;

namespace JogoDeAdivinhacao.ConsoleApp
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            
           while(true)
            {
                string opcaoDificuldade = ExibirMenu();
                int totalDeTentativas = Escolha(opcaoDificuldade);
                int numeroSecreto = SelecaoNumeroSecreto();
                Logica(totalDeTentativas, numeroSecreto);
                if (!FimdeJogo())
                    break;
            }
        }
       static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Escolha um NÍVEL DE DIFICULDADE");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1 - FÁCIL (1O TENTATIVAS)");
            Console.WriteLine("2 - NORMAL (5 TENTATIVAS)");
            Console.WriteLine("3 - DIFÍCIL (3 TENTATIVAS)");

            Console.Write("DIGITE sua ESCOLHA DE DIFICULDADE: ");
            string opcaoDificuldade = Console.ReadLine()!;
            return opcaoDificuldade;
        }
       static int Escolha(string opcaoDificuldade)
        {
     
            int totalDeTentativas = opcaoDificuldade switch // Alternar entre essas opções de acordo com a opcao selecionada
            {
                "1" => 10,
                "2" => 5,
                "3" => 3,
                _ => 5 // Em caso de erro -> dificuldade normal
            };

            return totalDeTentativas;
        }
       static int SelecaoNumeroSecreto()
        {
            Random geradorNumeros = new Random();
            int numeroSecreto = geradorNumeros.Next(1, 21);
            return numeroSecreto;
        }
       static void Logica(int totalDeTentativas, int numeroSecreto)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("-----------------------------------------------");


            for (int tentativas = 1; tentativas <= totalDeTentativas; tentativas++)
            {
                Console.Write("Digite um Número: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroSecreto == numeroDigitado)
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine(" \nVocê acertou o número SECRETO meu truta!!! Parabéns!");
                    Console.WriteLine("-----------------------------------------------");
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
        }
       static bool FimdeJogo()
        {
            Console.WriteLine("Deseja Continuar? (S/N)");
            string continuar = Console.ReadLine()!.ToLower();
            return continuar == "s";
        }
    }
}
