using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rows = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int r = rows[0];
            int c = rows[1];
            char[,] matrix = new char[r, c];

            if (r <= 1 || c <= 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int count = 0;

            for(int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for(int j = 0; j  < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}