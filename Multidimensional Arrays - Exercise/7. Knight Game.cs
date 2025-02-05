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
            char[,] matrix = new char[n, n];
            int inDanger = 0;
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] nums = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            for (int maxToKill = 8; maxToKill > 0; maxToKill--)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int row1 = row - 2;
                            int col1 = col - 1;
                            if (row1 >= 0 && row1 < n && col1 >= 0 && col1 < n)
                            {
                                if (matrix[row1, col1] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row1, col1] = '0';
                                }
                            }

                            int row2 = row - 2;
                            int col2 = col + 1;
                            if (row2 >= 0 && row2 < n && col2 >= 0 && col2 < n)
                            {
                                if (matrix[row2, col2] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row2, col2] = '0';
                                }
                            }

                            int row3 = row + 2;
                            int col3 = col - 1;
                            if (row3 >= 0 && row3 < n && col3 >= 0 && col3 < n)
                            {
                                if (matrix[row3, col3] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row3, col3] = '0';
                                }
                            }

                            int row4 = row + 2;
                            int col4 = col + 1;
                            if (row4 >= 0 && row4 < n && col4 >= 0 && col4 < n)
                            {
                                if (matrix[row4, col4] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row4, col4] = '0';
                                }
                            }

                            //---------------------------------//

                            int row5 = row - 1;
                            int col5 = col + 2;
                            if (row5 >= 0 && row5 < n && col5 >= 0 && col5 < n)
                            {
                                if (matrix[row5, col5] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row5, col5] = '0';
                                }
                            }

                            int row6 = row + 1;
                            int col6 = col + 2;
                            if (row6 >= 0 && row6 < n && col6 >= 0 && col6 < n)
                            {
                                if (matrix[row6, col6] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row6, col6] = '0';
                                }
                            }

                            int row7 = row + 1;
                            int col7 = col - 2;
                            if (row7 >= 0 && row7 < n && col7 >= 0 && col7 < n)
                            {
                                if (matrix[row7, col7] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row7, col7] = '0';
                                }
                            }

                            int row8 = row - 1;
                            int col8 = col - 2;
                            if (row8 >= 0 && row8 < n && col8 >= 0 && col8 < n)
                            {
                                if (matrix[row8, col8] == 'K')
                                {
                                    inDanger++;
                                    //matrix[row8, col8] = '0';
                                }
                            }

                            if (inDanger == maxToKill)
                            {
                                matrix[row, col] = '0';
                                count++;
                            }
                            inDanger = 0;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}