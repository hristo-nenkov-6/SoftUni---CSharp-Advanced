using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            var reversed = reverser(input);
            var checkDivide = checker(reversed, divider);

            printer(checkDivide);
        }

        static List<int> checker(List<int> n, int d)
        {
            var list = new List<int>();
            foreach(int i in n)
            {
                if (i % d != 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }

        static void printer(List<int> list)
        {
            foreach (var x in list)
            {
                Console.Write(x + " ");
            }
        }

        static List<int> reverser(List<int> list)
        {
            List<int> reversed = new List<int>();
            for(int i = list.Count - 1; i >= 0; i--)
            {
                reversed.Add(list[i]);
            }
            return reversed;
        }
    }
}