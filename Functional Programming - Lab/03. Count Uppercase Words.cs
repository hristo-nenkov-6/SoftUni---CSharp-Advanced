namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Where(w => checker(w))
                                          .ToList();
            foreach(var num in input)
            {
                Console.WriteLine(num);
            }
        }
    }
}