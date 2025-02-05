using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for(int row = 0; row < n; row++)
            {
                var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[nums.Length];
                for (int col = 0; col < nums.Length; col++)
                {
                    jagged[row][col] = nums[col];
                }
            }

            for(int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for(int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                var splitted = input.Split().ToArray();
                string command = splitted[0];
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);
                if (command == "Add")
                {
                    if(row >= 0 && row < n)
                    {
                        if(col >= 0 && col < jagged[row].Length)
                        {
                            jagged[row][col] += value;
                        }
                    }
                }
                else
                {
                    if (row >= 0 && row < n)
                    {
                        if (col >= 0 && col < jagged[row].Length)
                        {
                            jagged[row][col] -= value;
                        }
                    }
                }
            }

            for(int  row = 0; row < n; row++)
            {
                Console.WriteLine(String.Join(" ", jagged[row]));
            }
        }
    }
}