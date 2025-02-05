using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var commands = new Queue<string>(Console.ReadLine().Split(" "));
            char[,] matrix = new char[n, n];
            int startX = 0, startY = 0;
            int countOfCoals = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                    if (matrix[row, col] == 's')
                    {
                        startX = row;
                        startY = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        countOfCoals++;
                    }
                }
            }

            while(commands.Count > 0 && countOfCoals > 0)
            {
                string command = commands.Dequeue();
                switch(command)
                {
                    case "up":
                        {
                            if (startX - 1 >= 0)
                            {                               
                                if (matrix[startX - 1, startY] == 'c')
                                {
                                    countOfCoals--;
                                }
                                else if (matrix[startX - 1, startY] == 'e')
                                {
                                    Console.WriteLine($"Game over! ({startX - 1}, {startY})");
                                    return;
                                }

                                matrix[startX - 1, startY] = 's';
                                matrix[startX, startY] = '*';
                                startX = startX - 1;
                            }
                            break;
                        }

                    case "down":
                        {
                            if (startX + 1 < n)
                            {
                                if (matrix[startX + 1, startY] == 'c')
                                {
                                    countOfCoals--;
                                }
                                else if (matrix[startX + 1, startY] == 'e')
                                {
                                    Console.WriteLine($"Game over! ({startX + 1}, {startY})");
                                    return;
                                }

                                matrix[startX + 1, startY] = 's';
                                matrix[startX, startY] = '*';
                                startX = startX + 1;

                            }
                            break;
                        }

                    case "left":
                        {
                            if (startY - 1 >= 0)
                            {
                                if (matrix[startX, startY - 1] == 'c')
                                {
                                    countOfCoals--;
                                }
                                else if (matrix[startX, startY - 1] == 'e')
                                {
                                    Console.WriteLine($"Game over! ({startX}, {startY - 1})");
                                    return;
                                }

                                matrix[startX, startY - 1] = 's';
                                matrix[startX, startY] = '*';
                                startY = startY - 1;

                            }
                            break;
                        }

                    case "right":
                        {
                            if (startY + 1 < n)
                            {
                                if (matrix[startX, startY + 1] == 'c')
                                {
                                    countOfCoals--;
                                }
                                else if (matrix[startX, startY + 1] == 'e')
                                {
                                    Console.WriteLine($"Game over! ({startX}, {startY + 1})");
                                    return;
                                }

                                matrix[startX, startY + 1] = 's';
                                matrix[startX, startY] = '*';
                                startY = startY + 1;

                            }
                            break;
                        }
                }
            }

            if(countOfCoals == 0)
            {
                Console.WriteLine($"You collected all coals! ({startX}, {startY})");
            }
            else
            {
                Console.WriteLine($"{countOfCoals} coals left. ({startX}, {startY})");
            }
        }
    }
}