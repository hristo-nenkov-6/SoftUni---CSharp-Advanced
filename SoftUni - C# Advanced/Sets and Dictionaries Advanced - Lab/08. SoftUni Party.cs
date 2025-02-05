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
            string inp = string.Empty;
            var party = new HashSet<string>();
            while ((inp = Console.ReadLine()) != "PARTY")
            {
                party.Add(inp);
            }

            while((inp = Console.ReadLine()) != "END")
            {
                party.Remove(inp);
            }

            Console.WriteLine(party.Count);
            foreach (var guest in party.Where(x => x[0] == '0' || x[0] == '1' || x[0] == '2' 
            || x[0] == '3' || x[0] == '4' || x[0] == '5' || x[0] == '6' || x[0] == '7' || x[0] == '8' || x[0] == '9'))
            {
                Console.WriteLine(guest);
                party.Remove(guest);
            }

            foreach(var guest in party)
            {
                Console.WriteLine(guest);
            }
        }
    }
}