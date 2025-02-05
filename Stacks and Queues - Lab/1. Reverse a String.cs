namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>(input);

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}