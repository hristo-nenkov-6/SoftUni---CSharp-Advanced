namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var NSX = Console.ReadLine().Split();
            int N = int.Parse(NSX[0]);
            int S = int.Parse(NSX[1]);
            int X = int.Parse(NSX[2]);

            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>(input);

            for(int i = 0; i < S; i++)
            {
                stack.Pop();
            }

            if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if(stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}