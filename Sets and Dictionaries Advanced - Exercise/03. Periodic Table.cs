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
            var set = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                var inp = Console.ReadLine().Split();
                foreach(string s in inp)
                {
                    set.Add(s);
                }
            }

            Console.WriteLine(String.Join(" ", set.OrderBy(x => x)));
        }
    }
}