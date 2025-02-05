using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int r = rows[0];
            int c = rows[1];
            char[,] matrix = new char[r, c];
            int playerX = 0, playerY = 0;
            bool killed = false, won = false;
            int deadPlaceX = 0, deadPlaceY = 0;

            List<int[]> bunnies = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] nums = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerX = row;
                        playerY = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        bunnies.Add(new int[2] {row, col});
                    }
                }
            }

            var commands = Console.ReadLine().ToCharArray();
            for(int i = 0; i < commands.Length; i++)
            {
                switch(commands[i])
                {
                    case 'U':
                        {
                            int nextMoveX = playerX - 1;
                            int nextMoveY = playerY;

                            if(nextMoveX < 0)
                            {
                                matrix[playerX, playerY] = '.';
                                won = true;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == '.')
                            {
                                matrix[nextMoveX, nextMoveY] = 'P';
                                matrix[playerX, playerY] = '.';

                                playerX = nextMoveX;
                                playerY = nextMoveY;
                            }
                            else if(matrix[nextMoveX, nextMoveY] == 'B')
                            {
                                killed = true;
                                deadPlaceX = nextMoveX;
                                deadPlaceY = nextMoveY;

                                matrix[playerX, playerY] = '.';
                            }

                            break;
                        }

                    case 'D':
                        {
                            int nextMoveX = playerX + 1;
                            int nextMoveY = playerY;

                            if (nextMoveX >= r)
                            {
                                matrix[playerX, playerY] = '.';
                                won = true;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == '.')
                            {
                                matrix[nextMoveX, nextMoveY] = 'P';
                                matrix[playerX, playerY] = '.';

                                playerX = nextMoveX;
                                playerY = nextMoveY;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == 'B')
                            {
                                killed = true;
                                deadPlaceX = nextMoveX;
                                deadPlaceY = nextMoveY;

                                matrix[playerX, playerY] = '.';
                            }

                            break;
                        }

                    case 'L':
                        {
                            int nextMoveX = playerX;
                            int nextMoveY = playerY - 1;

                            if (nextMoveY < 0)
                            {
                                matrix[playerX, playerY] = '.';
                                won = true;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == '.')
                            {
                                matrix[nextMoveX, nextMoveY] = 'P';
                                matrix[playerX, playerY] = '.';

                                playerX = nextMoveX;
                                playerY = nextMoveY;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == 'B')
                            {
                                killed = true;
                                deadPlaceX = nextMoveX;
                                deadPlaceY = nextMoveY;

                                matrix[playerX, playerY] = '.';
                            }

                            break;
                        }

                    case 'R':
                        {
                            int nextMoveX = playerX;
                            int nextMoveY = playerY + 1;

                            if (nextMoveY >= c)
                            {
                                matrix[playerX, playerY] = '.';
                                won = true;

                            }
                            else if (matrix[nextMoveX, nextMoveY] == '.')
                            {
                                matrix[nextMoveX, nextMoveY] = 'P';
                                matrix[playerX, playerY] = '.';

                                playerX = nextMoveX;
                                playerY = nextMoveY;
                            }
                            else if (matrix[nextMoveX, nextMoveY] == 'B')
                            {
                                killed = true;
                                deadPlaceX = nextMoveX;
                                deadPlaceY = nextMoveY;

                                matrix[playerX, playerY] = '.';
                            }

                            break;
                        }
                }

                int currBunnies = bunnies.Count;
                for(int bun = 0; bun < currBunnies; bun++)
                {
                    var bunny = bunnies[bun];
                    int x = bunny[0];
                    int y = bunny[1];

                    if (matrix[x, y] == 'P')
                    {
                        killed = true;
                        deadPlaceX = x;
                        deadPlaceY = y;
                        matrix[x - 1, y] = 'B';
                    }

                    if (x - 1 >= 0)
                    {
                        if (matrix[x - 1, y] == 'P')
                        {
                            killed = true;
                            deadPlaceX = x - 1;
                            deadPlaceY = y;
                            matrix[x - 1, y] = 'B';

                        }
                        if (matrix[x - 1, y] != 'B')
                        {
                            matrix[x - 1, y] = 'B';
                            bunnies.Add(new int[2] { x - 1, y });
                        }
                    }

                    if (x + 1 < r)
                    {
                        if (matrix[x + 1, y] == 'P')
                        {
                            killed = true;
                            deadPlaceX = x + 1;
                            deadPlaceY = y;
                            matrix[x + 1, y] = 'B';

                        }
                        if (matrix[x + 1, y] != 'B')
                        {
                            matrix[x + 1, y] = 'B';
                            bunnies.Add(new int[2] { x + 1, y });
                        }

                    }

                    if (y - 1 >= 0)
                    {
                        if (matrix[x, y - 1] == 'P')
                        {
                            killed = true;
                            deadPlaceX = x;
                            deadPlaceY = y - 1;
                            matrix[x , y - 1] = 'B';

                        }
                        if (matrix[x, y - 1] != 'B')
                        {
                            matrix[x, y - 1] = 'B';
                            bunnies.Add(new int[2] { x, y - 1 });
                        }

                    }

                    if (y + 1 < c)
                    {
                        if (matrix[x, y + 1] == 'P')
                        {
                            killed = true;
                            deadPlaceX = x;
                            deadPlaceY = y + 1;
                            matrix[x, y + 1] = 'B';
                        }
                        if (matrix[x, y + 1] != 'B')
                        {
                            matrix[x, y + 1] = 'B';
                            bunnies.Add(new int[2] { x, y + 1 });
                        }

                    }

                }


                    if(won)
                    {
                        PrintMatrix(r, c, matrix);
                        Console.WriteLine($"won: {playerX} {playerY}");
                        break;
                    }
                    else if (killed)
                    {
                        PrintMatrix(r, c, matrix);
                        Console.WriteLine($"dead: {deadPlaceX} {deadPlaceY}");
                        break;
                    }
            }
        }

        static void PrintMatrix(int r, int c, char[,] matrix)
        {
            for(int  i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

/*
4 5
..... 
..... 
.B... 
...P. 
LLLLLLLL

 * */
