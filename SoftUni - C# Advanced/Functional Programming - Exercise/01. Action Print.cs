namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            foreach (var line in input)
            {
                var printer = Print(line);
                printer(line);
            }
        }
        static Action<string> Print(string name)
        {
            return x => Console.WriteLine(name);
        }
    }
}