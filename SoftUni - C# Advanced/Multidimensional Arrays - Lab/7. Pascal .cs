using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrix = new long[n][];
            matrix[0] = new long[1];
            matrix[0][0] = 1;
            for(int i = 1; i < n; i++)
            {
                matrix[i] = new long[i + 1];
                for(int index = 0; index < matrix[i].Length; index++)
                {
                    if(index == 0)
                    {
                        matrix[i][index] = 1;
                    }
                    else if(index == matrix[i].Length - 1)
                    {
                        matrix[i][index] = 1;
                    }
                    else
                    {
                        matrix[i][index] = matrix[i - 1][index] + matrix[i-1][index - 1];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(String.Join(" ", matrix[row]));
            }

        }
    }
}