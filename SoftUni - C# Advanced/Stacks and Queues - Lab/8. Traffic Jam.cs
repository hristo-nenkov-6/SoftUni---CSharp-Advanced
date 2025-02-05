namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            int lenght = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int br = 0;

            while((input = Console.ReadLine()) != "end")
            {
                if(input == "green")
                {
                    int numberOfCars = Math.Min(queue.Count, lenght);
                    for(int i = 0; i < numberOfCars; i++)
                    {
                        string model = queue.Dequeue();
                        Console.WriteLine($"{model} passed!");
                        br++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{br} cars passed the crossroads.");
        }
    }
}