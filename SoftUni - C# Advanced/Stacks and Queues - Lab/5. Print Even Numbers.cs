namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse);
            var queue = new Queue<int>(arr);
            var list = new List<int>();
            
            while(queue.Count > 0)
            {
                int num = queue.Dequeue();
                if(num % 2 == 0 )
                {
                    list.Add(num);
                }
            }

            Console.WriteLine(String.Join(", ", list));
        }
    }
}