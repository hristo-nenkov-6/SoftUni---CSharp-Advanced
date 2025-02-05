namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> VAT = price => price * 1.2;
            var prices = Console.ReadLine()
                                .Split(", ")
                                .Select(double.Parse)
                                .Select(p => VAT(p))
                                .ToList();

            foreach (var pr in prices)
            {
                Console.WriteLine($"{pr:f2}");
            }
        }
    }
}