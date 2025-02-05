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
            var wardrobe = new Dictionary<string, List<string>>();
            for(int i = 0; i < n;  i++)
            {
                var colorClothes = Console.ReadLine().Split(" -> ");
                string color = colorClothes[0];
                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new List<string>());
                }
                var clothes = colorClothes[1].Split(",");
                foreach (var cloth in clothes)
                {
                    wardrobe[color].Add(cloth);
                }
            }

            var searched = Console.ReadLine().Split();
            var searchColor = searched[0];
            var searchItem = searched[1];

            foreach(var color in wardrobe.Keys)
            {
                var dict = new Dictionary<string, int>();
                Console.WriteLine($"{color} clothes:");
                foreach(var item in wardrobe[color])
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

                foreach(var item in dict)
                {
                    if(searchColor == color && searchItem == item.Key)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}