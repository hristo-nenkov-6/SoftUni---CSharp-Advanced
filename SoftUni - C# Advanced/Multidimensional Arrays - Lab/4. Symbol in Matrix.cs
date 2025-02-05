using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            char[,] matrix = new char[r, r];
            bool found = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] nums = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            char specialSymbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].Equals(specialSymbol))
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = true;
                        return;
                    }
                }
            }

            if(!found)
            {
                Console.WriteLine($"{specialSymbol} does not occur in the matrix");
            }
        }
    }
}