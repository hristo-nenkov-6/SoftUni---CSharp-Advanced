namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;

            int startingCapacity = capacity;
            while(stack.Count > 0)
            {
                int cloth = stack.Pop();
                if(cloth <= capacity)
                {
                    capacity-=cloth;
                }
                else
                {
                    numberOfRacks++;
                    capacity = startingCapacity;
                    capacity -= cloth;
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}