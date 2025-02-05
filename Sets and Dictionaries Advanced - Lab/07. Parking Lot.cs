using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new HashSet<string>();
            string inp = string.Empty;
            while((inp = Console.ReadLine()) != "END")
            {
                string command = inp.Split(", ")[0];
                string plate = inp.Split(", ")[1];

                if(command == "IN")
                {
                    parkingLot.Add(plate);
                }
                else
                {
                    parkingLot.Remove(plate);
                }
            }

            if(parkingLot.Count > 0)
            {
                foreach(string plate in parkingLot)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}