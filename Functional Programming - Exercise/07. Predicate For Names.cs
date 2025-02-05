using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().ToList();
            Predicate<string> filter = number => number.Length <= n;
            var list = FilterByLenght(input, filter);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static Func<List<string>, Predicate<string>, List<string>> FilterByLenght =
            (names, match) =>
            {
                List<string> list = new List<string>();
                foreach (string name in names)
                {
                    if(match(name))
                    {
                        list.Add(name);
                    }
                }

                return list;
            };
    }
}