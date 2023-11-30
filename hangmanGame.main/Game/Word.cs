using System;
using System.Linq;
using System.Threading;
using hangmanGame.main.Person;

namespace hangmanGame.main.Game
{
    public class Word
    {
        private Dictionary<string, string> options = WordOptions.Dict(); 
        //class with word options

        private string drawnWord;

        private string[] wordAttempts;

        private string[] informedLetters = new string[6];
        // max number of tries

        public Dictionary<string, string> GetOptions() => options;

        public string GetDrawnWord() => drawnWord;

        public string DrawWord()
        {
            Random rd = new Random();
            drawnWord = options.Keys.ElementAt(rd.Next(options.Count));
            SetWordAttempts();
            return drawnWord;
        }

        public void SetWordAttempts() => wordAttempts = drawnWord.Select(_ => "_").ToArray();

        public bool EditWord(string letter, Player player)
        {
            bool containsLetter = false;

            for (int i = 0; i < drawnWord.Length; i++)
            {
                if (drawnWord[i].ToString() == letter)
                {
                    wordAttempts[i] = letter;
                    containsLetter = true;
                }
            }

            if (informedLetters.Contains(letter))
            {
                containsLetter = true;
                Console.WriteLine($"\nA letra {letter} já foi informada. ");
                Thread.Sleep(2000);
            }

            return containsLetter;
        }

        public void CheckInformedLetter(bool containsLetter, string letter, Player player)
        {
            if (!containsLetter)
            {
                informedLetters[player.GetAttempts()] = letter;
                player.IncreaseAttempts();
                Console.WriteLine("\nA letra digitada não existe na palavra-chave");
                Thread.Sleep(2000);
            }
        }

        public void PrintWordAttempts() => Console.WriteLine($"\nTema: {options[drawnWord]}\nPalavra: {string.Join(" ", wordAttempts)}");

        public void PrintInformedLetters()
        {

            if (informedLetters.Any(l => l != null))
            {
                Console.WriteLine("\n\nNão tem: ");
            }

            foreach (var informedLetter in informedLetters.Where(l => l != null))
            {
                Console.Write($"'{informedLetter}';");
            }
        }

        public string[] GetWordAttempts() => wordAttempts;
    }
}
