using System;
using System.Globalization;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guest = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string command = input.Split()[0];
                string typeOfCommand = input.Split()[1];
                string value = input.Split()[2];

                if(command == "Remove")
                {
                    guest.RemoveAll(filterByTypeOfCommand(typeOfCommand, value));
                }
                else
                {
                    List<string> peopleToDouble = guest.FindAll(filterByTypeOfCommand(typeOfCommand, value));
                    foreach(var person in peopleToDouble)
                    {
                        int index = guest.FindIndex(p => p == person);
                        guest.Insert(index, person);
                    }
                }
            }

            if(!guest.Any())
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(String.Join(", ", guest) + " are going to the party!");
            }
        }

        static Predicate<string> filterByTypeOfCommand(string typeOfCommand, string value)
        {
            switch (typeOfCommand)
            {
                case "StartsWith":
                    {
                        return p => p.StartsWith(value);
                    }
                case "EndsWith":
                    {
                        return p => p.EndsWith(value);
                    }
                case "Length":
                    {
                        return p => p.Length == int.Parse(value);
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}