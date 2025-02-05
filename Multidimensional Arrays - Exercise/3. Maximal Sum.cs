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
            int[,] matrix = new int[r, c];

            if (r <= 1 || c <= 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int maxSum = 0;
            int maxX = 0;
            int maxY = 0;
            int br = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currSum = 0;
                    for(int row = i; row < i + 3; row++)
                    {
                        for(int col = j; col < j + 3; col++)
                        {
                            currSum += matrix[row, col];
                        }
                    }
                    br++;
                    if(currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxX = i;
                        maxY = j;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);
            for (int row = maxX; row < maxX + 3; row++)
            {
                for (int col = maxY; col < maxY + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}