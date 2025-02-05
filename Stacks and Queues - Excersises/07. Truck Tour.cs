namespace Stacks_and_queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrol = new Queue<int>();
            var travel = new Queue<int>();
            int nowLiters = 0;
            bool canDoIt = false;
            int br = 0;

            for(int i = 0; i < n; i++)
            {
                var litersKilometers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int liters = litersKilometers[0];
                int kilometers = litersKilometers[1];

                petrol.Enqueue(liters);
                travel.Enqueue(kilometers);
            }

            for(br = 0; br < n; br++)
            {
                canDoIt = true;
                for(int i = 0; i < n; i++)
                {
                    int nowPetrol = petrol.Dequeue();
                    int nowKilometers = travel.Dequeue();

                    nowLiters += nowPetrol;
                    nowLiters -= nowKilometers;

                    petrol.Enqueue(nowPetrol);
                    travel.Enqueue(nowKilometers);

                    if (nowLiters < 0)
                    {
                        canDoIt = false;    
                    }
                }

                if(canDoIt)
                {
                    break;
                }
                else
                {
                    int nowPetrol = petrol.Dequeue();
                    int nowKilometers = travel.Dequeue();
                    petrol.Enqueue(nowPetrol);
                    travel.Enqueue(nowKilometers);
                }
                nowLiters = 0;
            }

            Console.WriteLine(br);
        }
    }
}