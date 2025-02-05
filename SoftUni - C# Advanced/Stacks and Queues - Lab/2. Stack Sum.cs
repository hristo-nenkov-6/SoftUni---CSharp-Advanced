namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInp = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>(firstInp);

            string input = string.Empty;
            while((input = Console.ReadLine().ToLower()) != "end")
            {
                var splitted = input.Split();
                var command = splitted[0].ToLower();
                if(command == "add")
                {
                    int num1 = int.Parse(splitted[1]);
                    int num2 = int.Parse(splitted[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if(command == "remove")
                {
                    int num = int.Parse(splitted[1]);
                    if(num > stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for(int i = 0; i < num; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            foreach(int i in stack)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}