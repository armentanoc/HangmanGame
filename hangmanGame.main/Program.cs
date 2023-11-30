using hangmanGame.main.Person;
using hangmanGame.main.Game;

namespace hangmanGame.main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            PrintTitle();
            player.SetName();
            RunGameMenu(player);
        }

        public static void RunGameMenu(Player player)
        {
            int option = 0;

            try
            {
                Console.WriteLine($"\nO que deseja fazer, {player.GetName()}?"
                                  + $"\n\n(1) Iniciar um novo jogo"
                                  + $"\n(2) Sair"
                                  + $"\n\nPontuação atual: {player.GetPoints()}");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    DetermineOption(player, option);
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número.");
                    RunGameMenu(player);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                RunGameMenu(player);
            }
        }

        static void DetermineOption(Player player, int option)
        {
            switch (option)
            {
                case 1:
                    Gameplay.Play(player);
                    break;
                case 2:
                    Console.WriteLine($"\nJogo encerrado! Você fez {player.GetPoints()} pontos nessa partida, {player.GetName()}");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    RunGameMenu(player);
                    break;
            }
        }
        static void PrintTitle()
        {
            Console.WriteLine("-----Jogo da Forca-----");
        }
    }
}
