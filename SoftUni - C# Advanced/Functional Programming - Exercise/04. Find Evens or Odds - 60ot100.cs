using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] borders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int minBorder = borders[0];
            int maxBorder = borders[1];

            string filter = Console.ReadLine();

            var list = generateNums(minBorder, maxBorder);
            Filter(list, filter);
        }

        static Func<int, int, List<int>> generateNums = (int min, int max) =>
        {
            var list = new List<int>();
            for (int i = min; i <= max; i++)
            {
                list.Add(i);
            }
            return list;
        };

        static void Filter(List<int> nums, string filter)
            {
                foreach(var item in nums)
                {
                    if(filter == "odd")
                {
                    if (item % 2 == 1)
                    {
                        Console.Write(item + " ");
                    }
                }
                    else
                {
                    if (item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
                }
            }
    }
}