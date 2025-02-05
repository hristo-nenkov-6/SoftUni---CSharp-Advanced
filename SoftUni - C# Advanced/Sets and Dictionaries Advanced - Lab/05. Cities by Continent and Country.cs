using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var world = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                var inp = Console.ReadLine().Split();
                string continent = inp[0];
                string country = inp[1];
                string city = inp[2];

                if(world.ContainsKey(continent))
                {
                    if (world[continent].ContainsKey(country))
                    {
                        world[continent][country].Add(city);
                    }
                    else
                    {
                        world[continent].Add(country, new List<string> { city });
                    }
                }
                else
                {
                    world.Add(continent, new Dictionary<string, List<string>>());
                    world[continent].Add(country, new List<string> { city });
                }
            }

            foreach(var continent in world.Keys)
            {
                Console.WriteLine(continent + ":");
                foreach(var country in world[continent].Keys)
                {
                    Console.WriteLine($"  {country} -> {String.Join(", ", world[continent][country])}");
                }
            }
        }
    }
}