using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<char, int>();
            var inp = Console.ReadLine().ToCharArray();
            foreach(var symbol in inp)
            {
                if(dict.ContainsKey(symbol))
                {
                    dict[symbol]++;
                }
                else
                {
                    dict.Add(symbol, 1);
                }
            }

            foreach (var symbol in dict.Keys)
            {
                Console.WriteLine($"{symbol}: {dict[symbol]} time/s");
            }
        }
    }
}