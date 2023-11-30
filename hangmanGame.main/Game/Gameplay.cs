using hangmanGame.main.Person;

namespace hangmanGame.main.Game
{
    public class Gameplay
    {
        public static void Play(Player player)
        {
            Word wordManager = new Word();
            wordManager.DrawWord();
            RunGame(player, wordManager);
            DisplayResult(player, wordManager);
        }

        static void RunGame(Player player, Word wordManager)
        {
            string letter, discoveredWord = "";

            do
            {
                DisplayInterface(player, wordManager);
                letter = ReceiveLetter();

                if (IsValidLetter(letter))
                {
                    discoveredWord = CheckLetter(wordManager, player, letter, discoveredWord);

                    if (wordManager.GetDrawnWord().Equals(discoveredWord))
                    {
                        player.IncreasePoints();
                        break;
                    }
                    else
                    {
                        discoveredWord = "";
                    }
                }
                else
                {
                    Console.WriteLine("\nVocê deve digitar um único caractere do tipo letra (a-z ou A-Z). ");
                    Thread.Sleep(2000);
                }

            } while (player.GetAttempts() < 6);
        }

        static string CheckLetter(Word wordManager, Player player, string letter, string discoveredWord)
        {
            wordManager.CheckInformedLetter(wordManager.EditWord(letter, player), letter, player);
            discoveredWord = string.Join("", wordManager.GetWordAttempts());
            return discoveredWord;
        }

        static void DisplayInterface(Player player, Word wordManager)
        {
            Display.HangedMan(player);
            wordManager.PrintWordAttempts();
            wordManager.PrintInformedLetters();
        }

        static string ReceiveLetter()
        {
            Console.WriteLine("\n\nTente uma letra: ");
            return Console.ReadLine().ToUpper();
        }

        static bool IsValidLetter(string letter)
        {
            return letter.Length == 1 && System.Text.RegularExpressions.Regex.IsMatch(letter, "[a-zA-Z]");
        }

        static void DisplayResult(Player player, Word wordManager)
        {
            DisplayInterface(player, wordManager);

            if (player.GetAttempts() == 6)
            {
                Console.WriteLine($"\n\nPerdeu! Você digitou {player.GetAttempts()} letras incorretas. " +
                                  $"A palavra sorteada era: {wordManager.GetDrawnWord()}");
            }
            else
            {
                Console.WriteLine($"\n\nAcertou! Você errou apenas {player.GetAttempts()} letras e o seu total " +
                                  $"atual de pontos é: {player.GetPoints()}");
            }

            player.SetAttempts(0);
            Program.RunGameMenu(player);
        }
    }
}
