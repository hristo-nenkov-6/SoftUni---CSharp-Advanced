namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(MinFilter(nums));
        }

        static Func<int[], int> MinFilter = (int[] integers) =>
        {
            int min = int.MaxValue;
            foreach(int i in integers)
            {
                if(i < min)
                {
                    min = i;
                }
            }
            return min;
        };
    }
}