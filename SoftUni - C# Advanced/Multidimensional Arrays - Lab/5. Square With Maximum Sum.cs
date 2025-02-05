using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rows = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int r = rows[0];
            int c = rows[1];
            int[,] matrix = new int[r, c];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int maxSum = 0;
            int maxCordX = 0, maxCordY = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if(currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxCordX = row;
                        maxCordY = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxCordX, maxCordY] + " " + matrix[maxCordX, maxCordY + 1]);
            Console.WriteLine(matrix[maxCordX + 1, maxCordY] + " " + matrix[maxCordX + 1, maxCordY + 1]);
            Console.WriteLine(maxSum);
        }
    }
}