using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicates = new();
            int endRange = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToHashSet();
            int[] numbers = Enumerable.Range(1, endRange).ToArray();

            foreach(int divider in dividers)
            {
                predicates.Add(x => x % divider == 0);
            }

            foreach(int num in numbers)
            {
                bool isDivisable = true;
                foreach(var match in predicates)
                {
                    if(!match(num))
                    {
                        isDivisable = false;
                        break;
                    }
                }

                if(isDivisable)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}