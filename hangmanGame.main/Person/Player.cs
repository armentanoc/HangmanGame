using System;

namespace hangmanGame.main.Person
{
    public class Player
    {
        private string name = "";
        private int points = 0;
        private int attempts = 0;

        public void SetName()
        {
            do
            {
                name = AskForName();
                if (!IsNameValid(name))
                {
                    Console.WriteLine("Nome inválido. Por favor, digite um nome sem dígitos.\n");
                }
            } while (!IsNameValid(name));
        }

        bool IsNameValid(string? name)
        {
            return !string.IsNullOrWhiteSpace(name) && !ContainsDigits(name);
            //if name is null, contain whitspace or digits returns false else true
        }

        bool ContainsDigits(string input)
        {
            return input.Any(char.IsDigit);
        }

        string AskForName()
        {
            Console.WriteLine("-----Jogo da Forca-----");
            Console.WriteLine("\nInforme o seu nome: ");
            return Console.ReadLine();
        }

        public string GetName() => name;
        public int GetPoints() => points;
        public void IncreasePoints() => points++;
        public int GetAttempts() => attempts;
        public void IncreaseAttempts() => attempts++;
        public void SetAttempts(int i) => attempts = i;
    }
}
