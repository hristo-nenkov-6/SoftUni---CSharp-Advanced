namespace Functioanla_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parser = n => int.Parse(n);
            int[] nums = input.Split(", ").Select(parser).ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}