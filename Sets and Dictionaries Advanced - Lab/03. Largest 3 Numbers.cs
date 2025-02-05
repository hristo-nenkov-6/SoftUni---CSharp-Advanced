using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            if(input.Length >= 3)
            {
                Console.WriteLine(input[0] + " " + input[1] + " " + input[2]);
            }
            else if(input.Length == 2)
            {
                Console.WriteLine(input[0] + " " + input[1]);
            }
            else if(input.Length == 1)
            {
                Console.WriteLine(input[0]);
            }
        }
    }
}