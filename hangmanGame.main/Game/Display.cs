using hangmanGame.main.Person;

namespace hangmanGame.main.Game
{
    internal class Display
    {
        public static void HangedMan(Player player)
        {
            string[] hangedMan = makeHangedMan();

            int attempts = player.GetAttempts();

            if (attempts >= 0 && attempts < hangedMan.Length)
            {
                Console.WriteLine(hangedMan[attempts]);
            }
            else
            {
                throw new ArgumentException("Unexpected value: " + attempts);
            }
        }

        static string[] makeHangedMan()
        {
            return [
        "\n\n0000000000000\n" +
        "0           0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0           2\n" +
        "0           2\n" +
        "0           2\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0          32\n" +
        "0         3 2\n" +
        "0        3  2\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0          324\n" +
        "0         3 2 4\n" +
        "0        3  2  4\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0          324\n" +
        "0         3 2 4\n" +
        "0        3  2  4\n" +
        "0          5 \n" +
        "0         5  \n" +
        "0        5   \n" +
        "0       5    \n" +
        "0\n" +
        "0" +
        "0",

        "\n\n0000000000000\n" +
        "0           0\n" +
        "0           1\n" +
        "0          1 1\n" +
        "0           1\n" +
        "0          324\n" +
        "0         3 2 4\n" +
        "0        3  2  4\n" +
        "0          5 6\n" +
        "0         5   6\n" +
        "0        5     6\n" +
        "0       5       6\n" +
        "0\n" +
        "0" +
        "0"
    ];
        }
    }
}
