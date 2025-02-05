namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var knights = Console.ReadLine().Split(" ").ToList();
            Sir(knights);
        }

        static Action<List<string>> Sir = (List<string> knights) =>
        {
            foreach (var knight in knights)
            {
                Console.WriteLine("Sir " + knight);
            }
        };
    }
}