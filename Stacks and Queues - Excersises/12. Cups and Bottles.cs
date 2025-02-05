using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cupsCapacity = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottlesCapacity = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;

            int cup = 0;
            bool enough = true;
            while(cupsCapacity.Count > 0 && bottlesCapacity.Count > 0) 
            {
                int currCup = cupsCapacity.Peek();
                if(enough)
                {
                    cup = currCup;
                }
                int currBottle = bottlesCapacity.Pop();

                if(cup <= currBottle)
                {
                    cupsCapacity.Dequeue();
                    wastedWater += currBottle - cup;
                    enough = true;
                }
                else
                {
                    cup -= currBottle;
                    enough = false;
                }
            }

            if(cupsCapacity.Count > 0)
            {
                Console.WriteLine("Cups: " + String.Join(" ", cupsCapacity));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else if(bottlesCapacity.Count > 0)
            {
                Console.WriteLine("Bottles: " + String.Join(" ", bottlesCapacity));
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}