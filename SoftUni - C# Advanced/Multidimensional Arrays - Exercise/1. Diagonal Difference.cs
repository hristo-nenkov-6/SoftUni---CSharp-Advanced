namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] sums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = sums[j];
                }
            }

            //primary
            int primSum = 0;
            for (int i = 0; i < n; i++)
            {
                primSum += matrix[i, i];
            }

            //secondary
            int secSum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                secSum += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(primSum - secSum));
        }
    }
}