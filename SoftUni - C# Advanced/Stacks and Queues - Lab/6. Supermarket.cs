namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var queue = new Queue<string>();
            while((input = Console.ReadLine()) != "End")
            {
                if(input == "Paid")
                {
                    
                    while(queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine(queue.Count + " people remaining.");
        }
    }
}