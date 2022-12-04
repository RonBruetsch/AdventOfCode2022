
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace RucksackReorganisation
{
    internal static class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("../../../input.txt");

            int first = FirstPart(input);

            Console.WriteLine(first);

            int second = SecondPart(input);

            Console.WriteLine(second);
        }

        public static int FirstPart(string[] input)
        {
            int total = 0;
            foreach (string line in input)
            {
                string compartment2 = line.Substring(line.Length / 2);
                string compartment1 = line.Replace(compartment2, "");

                string duplicate = "";
                foreach (char item in compartment1)
                {
                    if (compartment2.Contains(item) && !duplicate.Contains(item))
                    {
                        duplicate += item;
                    }
                }

                total += MapPriority(duplicate);
            }
            return total;
        }

        public static int SecondPart(string[] input)
        {
            string duplicate = "";
            for (int i = 0; i < input.Length - 2; i += 3)
            {
                // How can i find all the letter with is present in all three strings 
                foreach (char item in input[i])
                {
                    if (input[i + 1].Contains(item) && input[i + 2].Contains(item))
                    {
                        duplicate += item;
                        break;
                    }
                }
            }

            return MapPriority(duplicate);
        }

        public static int MapPriority(string duplicate)
        {
            Dictionary<char, int> priorities = new Dictionary<char, int>()
            {
                { 'a', 1 },
                { 'b', 2 },
                { 'c', 3 },
                { 'd', 4 },
                { 'e', 5 },
                { 'f', 6 },
                { 'g', 7 },
                { 'h', 8 },
                { 'i', 9 },
                { 'j', 10 },
                { 'k', 11 },
                { 'l', 12 },
                { 'm', 13 },
                { 'n', 14 },
                { 'o', 15 },
                { 'p', 16 },
                { 'q', 17 },
                { 'r', 18 },
                { 's', 19 },
                { 't', 20 },
                { 'u', 21 },
                { 'v', 22 },
                { 'w', 23 },
                { 'x', 24 },
                { 'y', 25 },
                { 'z', 26 },
                { 'A', 27 },
                { 'B', 28 },
                { 'C', 29 },
                { 'D', 30 },
                { 'E', 31 },
                { 'F', 32 },
                { 'G', 33 },
                { 'H', 34 },
                { 'I', 35 },
                { 'J', 36 },
                { 'K', 37 },
                { 'L', 38 },
                { 'M', 39 },
                { 'N', 40 },
                { 'O', 41 },
                { 'P', 42 },
                { 'Q', 43 },
                { 'R', 44 },
                { 'S', 45 },
                { 'T', 46 },
                { 'U', 47 },
                { 'V', 48 },
                { 'W', 49 },
                { 'X', 50 },
                { 'Y', 51 },
                { 'Z', 52 }
            };

            int total = 0;
            foreach (char d in duplicate)
            {
                total += priorities[d];
            }
            return total;
        }
    }
}