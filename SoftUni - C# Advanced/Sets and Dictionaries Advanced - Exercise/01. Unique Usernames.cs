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
            var names = new HashSet<string>();
            for(int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}