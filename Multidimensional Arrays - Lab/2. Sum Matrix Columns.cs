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

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for(int i = 0; i <  matrix.GetLength(1); i++)
            {
                int sum = 0;
                for(int j = 0;  j < matrix.GetLength(0); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}