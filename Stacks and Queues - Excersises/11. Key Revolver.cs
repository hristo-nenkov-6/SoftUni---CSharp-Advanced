using System.Runtime.CompilerServices;

namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int prize = int.Parse(Console.ReadLine());

            int currGunBarrel = sizeOfGunBarrel;
            while(locks.Count > 0 && bullets.Count > 0)
            {
                int currBullet = bullets.Pop();
                int currLock = locks.Peek();

                if(currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    prize -= priceOfBullet;
                    currGunBarrel--;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    prize -= priceOfBullet;
                    currGunBarrel--;
                }

                if(currGunBarrel == 0 && bullets.Count > 0 && bullets.Count >= sizeOfGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    currGunBarrel = sizeOfGunBarrel;
                }
                else if(currGunBarrel == 0 && bullets.Count > 0 && bullets.Count < sizeOfGunBarrel)
                {
                    Console.WriteLine("Reloading!");
                    currGunBarrel = bullets.Count;
                }
                else if(currGunBarrel == 0 && bullets.Count == 0 && locks.Count > 0)
                {
                    break;
                }
            }

            if(locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${prize}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}