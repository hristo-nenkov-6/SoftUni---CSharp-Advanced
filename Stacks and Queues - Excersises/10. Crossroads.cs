using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            bool crash = false;

            int greenDuration = int.Parse(Console.ReadLine());
            int freeDuration = int.Parse(Console.ReadLine());
            int carsPassed = 0;

            string input = string.Empty;
            int currentGreen = greenDuration;
            int currentFree = freeDuration;

            while((input = Console.ReadLine()) != "END")
            {
                if(input == "green")
                {
                    currentGreen = greenDuration;
                    currentFree = freeDuration;

                    if(currentGreen > 0 && queue.Count > 0 && crash == false)
                    {
                        while (currentGreen > 0 && queue.Count > 0 && crash == false)
                        {
                            string curCar = queue.Dequeue();

                            int carLength = curCar.Length;
                            string nameOfCurrCar = curCar;

                            if (currentGreen >= carLength)
                            {
                                currentGreen -= carLength;
                                carsPassed++;
                            }
                            else
                            {
                                curCar = curCar.Substring(currentGreen);
                                currentGreen = 0;
                                carLength = curCar.Length;

                                if (currentFree >= carLength)
                                {
                                    carsPassed++;
                                    currentFree -= carLength;
                                }
                                else
                                {
                                    curCar = curCar.Substring(currentFree);

                                    crash = true;
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{nameOfCurrCar} was hit at {curCar[0]}.");
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            if(crash == false)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}