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
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            var bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i <  bombs.Length; i++)
            {
                int x = int.Parse(bombs[i].Split(",")[0]);
                int y = int.Parse(bombs[i].Split(",")[1]);

                if (matrix[x, y] > 0)
                {

                    if (x - 1 >= 0 && x - 1 < n && y - 1 >= 0 && y - 1 < n && matrix[x - 1, y - 1] > 0)
                    {
                        matrix[x - 1, y - 1] -= matrix[x, y];
                    }
                    if (x >= 0 && x < n && y - 1 >= 0 && y - 1 < n && matrix[x, y - 1] > 0)
                    {
                        matrix[x, y - 1] -= matrix[x, y];
                    }
                    if (x + 1 >= 0 && x + 1 < n && y - 1 >= 0 && y - 1 < n && matrix[x + 1, y - 1] > 0)
                    {
                        matrix[x + 1, y - 1] -= matrix[x, y];
                    }
                    //---------
                    if (x - 1 >= 0 && x - 1 < n && y >= 0 && y < n && matrix[x - 1, y] > 0)
                    {
                        matrix[x - 1, y] -= matrix[x, y];

                    }
                    if (x + 1 >= 0 && x + 1 < n && y >= 0 && y < n && matrix[x + 1, y] > 0)
                    {
                        matrix[x + 1, y] -= matrix[x, y];

                    }
                    //-------------
                    if (x - 1 >= 0 && x - 1 < n && y + 1 >= 0 && y + 1 < n && matrix[x - 1, y + 1] > 0)
                    {
                        matrix[x - 1, y + 1] -= matrix[x, y];

                    }
                    if (x >= 0 && x < n && y + 1 >= 0 && y + 1 < n && matrix[x, y + 1] > 0)
                    {
                        matrix[x, y + 1] -= matrix[x, y];

                    }
                    if (x + 1 >= 0 && x + 1 < n && y + 1 >= 0 && y + 1 < n && matrix[x + 1, y + 1] > 0)
                    {
                        matrix[x + 1, y + 1] -= matrix[x, y];

                    }
                    matrix[x, y] = 0;
                }
            }

            int count = 0;
            int sum = 0;
            for(int row = 0; row < n; row++)
            {
                for(int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}