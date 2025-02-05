using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, r];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int sum = 0;
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}