
namespace CalorieCounting
{
    internal static class Program
    {
        public static void Main()
        {
            var input = File.ReadAllLines("../../../input.txt");

            IEnumerable<int> calCounts = GetCalCounts(input);

            int highestCals = calCounts.Max();
            Console.WriteLine(highestCals);

            int total = GetTotal(calCounts);
            Console.WriteLine(total);
        }

        public static int GetTotal(IEnumerable<int> calCounts)
        {
            int total = 0;
            List<int> ordered = calCounts.OrderByDescending(x => x).ToList();
            for (int i = 0; i < 3; i++)
            {
                total += ordered[i];
            }
            return total;
        }

        public static IEnumerable<int> GetCalCounts(string[] input)
        {
            List<int> calCounts = new List<int>();
            int count = 0;
            foreach (var line in input)
            {
                if (int.TryParse(line, out int result))
                {
                    count += result;
                }
                else
                {
                    calCounts.Add(count);
                    count = 0;
                }
            }

            return calCounts;
        }
    }
}