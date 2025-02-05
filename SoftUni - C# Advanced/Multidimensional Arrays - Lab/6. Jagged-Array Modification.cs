using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int[][] matrix = new int[r][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = nums;
            }

            string input = string.Empty;
            while((input = Console.ReadLine()) != "END")
            {
                var splittedInp = input.Split().ToArray();
                string command = splittedInp[0];
                int row = int.Parse(splittedInp[1]);
                int col = int.Parse(splittedInp[2]);
                int value = int.Parse(splittedInp[3]);

                if(row >= matrix.GetLength(0) || row < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                else
                {
                    if (col >= matrix[row].Length || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                }  
                
                if(command == "Add")
                {
                    matrix[row][col] += value;
                }
                else
                {
                    matrix[row][col] -= value;
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(String.Join(" ", matrix[row]));
            }
        
        }
    }
}