using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> list = Console.ReadLine().Split().ToList();
            string foundName =  getFirstName(list, sum, checkEqualOrLargerNameSum);
            Console.WriteLine(foundName);
        }

        static Func<string, int, bool> checkEqualOrLargerNameSum = (currName, sum) =>
        {
            var charredName = currName.ToCharArray();
            int nameSum = 0;
            foreach(char c in charredName)
            {
                nameSum += c;
            }

            return nameSum >= sum;
        };

        static Func<List<string>, int, Func<string, int, bool>, string> getFirstName =
        (names, sum, match) => //names.FirstOrDefault(name => match(name, sum));
        {
            foreach (var name in names)
            {
                if(match(name, sum))
                {
                    return name;
                }
            }
            return default;
        };
    }
}