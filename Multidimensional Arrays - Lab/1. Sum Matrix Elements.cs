using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsColumns = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int r = rowsColumns[0];
            int c = rowsColumns[1];

            int sum = 0;

            int[,] matrix = new int[r, c];

            for(int row = 0; row < r; row++)
            {
                int[] currRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int col = 0; col < c; col++)
                {
                    sum += currRow[col];
                    matrix[row, col] = currRow[col];
                }
            }

            Console.WriteLine(r);
            Console.WriteLine(c);
            Console.WriteLine(sum);
        }
    }
}