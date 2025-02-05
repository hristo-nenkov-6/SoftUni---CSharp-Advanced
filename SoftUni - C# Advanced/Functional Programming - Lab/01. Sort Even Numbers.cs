namespace Functioanla_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(", ").
                        Select(int.Parse).
                        ToList();
            nums = nums.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}