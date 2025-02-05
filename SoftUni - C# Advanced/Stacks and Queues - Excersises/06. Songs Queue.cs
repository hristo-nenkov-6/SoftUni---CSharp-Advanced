namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>(Console.ReadLine().Split(", ").ToList());
            while(queue.Count > 0)
            {
                var input = Console.ReadLine().Split(" ", 2);
                if (input[0] == "Play")
                {
                    queue.Dequeue();
                }
                else if (input[0] == "Add")
                {
                    if (queue.Contains(input[1]))
                    {
                        Console.WriteLine($"{input[1]} is already contained!");
                        continue;
                    }
                    queue.Enqueue(input[1]);
                }
                else if (input[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}