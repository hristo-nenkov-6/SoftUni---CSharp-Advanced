using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dims = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            int br = 0;

            var matrix = new char[dims[0], dims[1]];
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                if(row % 2 == 0) 
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if(br == snake.Length) { br = 0; }
                        matrix[row, col] = snake[br];
                        br++;
                    }
                }
                else
                {
                    for(int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (br == snake.Length) { br = 0; }
                        matrix[row, col] = snake[br];
                        br++;
                    }
                }
            }

            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for(int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}