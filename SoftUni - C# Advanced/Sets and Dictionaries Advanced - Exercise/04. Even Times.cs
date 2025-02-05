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
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<int, int>();

            for(int i = 0; i < n; i++)
            {
                var inp = int.Parse(Console.ReadLine());
                if(dict.ContainsKey(inp))
                {
                    dict[inp]++;
                }
                else
                {
                    dict.Add(inp, 1);
                }    
            }

            var answer = dict.First(x => x.Value % 2 == 0).Key;
            Console.WriteLine(answer);
        }
    }
}