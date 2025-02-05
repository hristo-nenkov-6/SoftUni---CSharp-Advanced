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
            var dict = new Dictionary<string, List<decimal>>();
            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (dict.ContainsKey(name))
                {
                    dict[name].Add(grade);
                }
                else
                {
                    dict.Add(name, new List<decimal>());
                    dict[name].Add(grade);
                }
            }

            foreach(var student in dict)
            {
                Console.Write(student.Key + " -> ");
                foreach(var grade in  student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}