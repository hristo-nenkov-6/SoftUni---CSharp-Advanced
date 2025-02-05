using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string inp = string.Empty;
            while ((inp = Console.ReadLine()) != "Revision")
            {
                var input = inp.Split(", ");
                string shop = input[0];
                string prod = input[1];
                double price = double.Parse(input[2]);

                if (shops.ContainsKey(shop))
                {
                    shops[shop].Add(prod, price);
                }
                else
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(prod, price);
                }
            }

            foreach(var s in shops.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{s}->");
                foreach(var v in shops[s])
                {
                    Console.WriteLine($"Product: {v.Key}, Price: {v.Value}");
                }
            }
        }
    }
}