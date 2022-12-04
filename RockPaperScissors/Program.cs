
using System.ComponentModel.DataAnnotations;

namespace RockPaperScissors
{
    internal static class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            int total = FirstChallenge(input);

            Console.WriteLine(total);
        }

        public static int SecondChallenge(string[] input)
        {
            return 0;
        }

        public static int FirstChallenge(string[] input)
        {

            int total = 0;

            foreach (string line in input)
            {
                string[] e = line.Split(' ');

                int shapeCount = 0;
                int winCount = 0;

                if (e[1] == "X")
                {
                    shapeCount = 1;

                    if (e[0] == "A")
                    {
                        winCount = 3;
                    }
                    if (e[0] == "C")
                    {
                        winCount = 6;
                    }
                }
                if (e[1] == "Y")
                {
                    shapeCount = 2;
                    if (e[0] == "B")
                    {
                        winCount = 3;
                    }
                    if (e[0] == "A")
                    {
                        winCount = 6;
                    }
                }
                if (e[1] == "Z")
                {
                    shapeCount = 3;
                    if (e[0] == "C")
                    {
                        winCount = 3;
                    }
                    if (e[0] == "B")
                    {
                        winCount = 6;
                    }
                }

                total += shapeCount + winCount;
            }

            return total;

        }
    }
}