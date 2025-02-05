namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var openingBrackets = new Stack<int>();

            for(int i = 0; i < input.Length; i++)
            { 
                char item = input[i];
                if(item == '(')
                {
                    openingBrackets.Push(i);
                }
                else if(item == ')')
                {
                    int starting  = openingBrackets.Pop();
                    Console.WriteLine(input.ToString().Substring(starting, i - starting + 1));
                }
            }
        }
    }//1+(2-(2+3)*4/(3+1))*5
}