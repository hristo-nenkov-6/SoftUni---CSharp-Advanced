namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split();
            int wanatedTosses = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(list);
            int toss = 0;
            while(queue.Count > 1)
            {
                toss++;
                string name = queue.Dequeue();
                if (toss != wanatedTosses)
                {
                    queue.Enqueue(name);
                }
                else
                {
                    Console.WriteLine("Removed " +  name);
                    toss = 0;
                }
            }
            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}