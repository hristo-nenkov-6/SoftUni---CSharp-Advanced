namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < times; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToList();
                int command = input[0];
                switch(command)
                {
                    case 1:
                        {
                            stack.Push(input[1]); 
                            break;
                        }

                    case 2:
                        {
                            stack.Pop();
                            break;
                        }

                    case 3:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Max());
                            }
                            break;
                        }

                    case 4:
                        {
                            if (stack.Count > 0)
                            {
                                Console.WriteLine(stack.Min());
                            }
                            break;
                        }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}