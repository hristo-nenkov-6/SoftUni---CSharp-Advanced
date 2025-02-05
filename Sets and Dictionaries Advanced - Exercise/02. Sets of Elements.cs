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
            var povtorki = new List<int>();

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            for(int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for(int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach(var number in set1)
            {
                if(set2.Contains(number))
                {
                    povtorki.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", povtorki));
        }
    }
}