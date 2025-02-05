namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            var items = new Stack<string>(inp.Split());
            var stack2 = new Stack<string>();
            foreach (var item in items)
            {
                stack2.Push(item);
            }

            int sum = int.Parse(stack2.Pop());
            while (stack2.Count > 0)
            {
                string expr = stack2.Pop();
                if(expr == "+")
                {
                    sum += int.Parse(stack2.Pop());
                }
                else
                {
                    sum -= int.Parse(stack2.Pop());
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}