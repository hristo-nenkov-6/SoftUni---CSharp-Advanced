namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var openingBrackets = new Stack<char>();
            var input = Console.ReadLine().ToCharArray();
            bool balanced = true;

            for(int i = 0; i < input.Length; i++)
            {
                char now = input[i];
                if(now.Equals('{') || now.Equals('[') || now.Equals('('))
                {
                    openingBrackets.Push(now);
                }
                else if(now.Equals(' '))
                {
                    if (!(input[i] == input[input.Length - 1 - i]))
                    {
                        balanced = false;
                        break;
                    }
                }
                else
                {
                    if(openingBrackets.Count == 0)
                    {
                        balanced = false;
                        break;
                    }

                    char c = openingBrackets.Pop();
                    switch (c)
                    {
                        case '{':
                            {
                                if(now != '}')
                                {
                                    balanced = false;
                                    break;
                                }
                                break;
                            }
                        case '(':
                            {
                                if (now != ')')
                                {
                                    balanced = false;
                                    break;
                                }
                                break;
                            }
                        case '[':
                            {
                                if (now != ']')
                                {
                                    balanced = false;
                                    break;
                                }
                                break;
                            }
                    }
                }
            }

            if(balanced == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}