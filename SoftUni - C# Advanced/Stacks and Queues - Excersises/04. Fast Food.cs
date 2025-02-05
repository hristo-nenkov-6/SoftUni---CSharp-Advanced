namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            var queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int max = queue.Max();

            while(queue.Count > 0)
            {
                int num = queue.Peek();
                if(num <= quantity)
                {
                    quantity -= num;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(max);
            if(queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + String.Join(" ", queue));
            }
        }
    }
}