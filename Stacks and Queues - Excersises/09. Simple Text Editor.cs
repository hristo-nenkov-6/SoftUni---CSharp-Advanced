using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            var stack = new Stack<string>();
            var lastCommand = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                var inp = Console.ReadLine().Split().ToArray();
                int command = int.Parse(inp[0]);

                switch (command)
                {
                    case 1:
                        {
                            var someString = inp[1];
                            text += someString;

                            stack.Push(someString);
                            lastCommand.Push(command);

                            break;
                        }

                    case 2:
                        {
                            int count = int.Parse(inp[1]);
                            string text1 = text.Substring(text.Length - count);
                            text = text.Remove(text.Length - count);

                            stack.Push(text1);
                            lastCommand.Push(command);

                            break;
                        }

                    case 3:
                        {
                            var smallStack = new Stack<char>();
                            int index = int.Parse(inp[1]);

                            Console.WriteLine(text[index - 1]);
                            break;
                        }

                    case 4:
                        {
                            int currCommand = lastCommand.Pop();
                            string currText = stack.Pop();

                            if(currCommand == 1)
                            {
                                text = text.Remove(text.Length - currText.Length);
                            }
                            else if(currCommand == 2)
                            {
                                text += currText;
                            }
                            break;
                        }
                }
            }
        }
    }
}