using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<double, int>();
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            foreach (var item in input)
            {
                if(dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}