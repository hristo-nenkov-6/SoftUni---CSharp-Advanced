using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split().ToList();
            Dictionary<string, Predicate<string>> filters = new();
            string command = string.Empty;
            while((command = Console.ReadLine()) != "Print")
            {
                string firstCommand = command.Split(";")[0];
                string secondCommand = command.Split(";")[1];
                string value = command.Split(";")[2];

                if(firstCommand == "Add filter")
                {
                    if(!filters.ContainsKey(secondCommand + value))
                    {
                        filters.Add(secondCommand + value, Predicates(secondCommand, value));
                    }
                }
                else
                {
                    filters.Remove(secondCommand + value);
                }
            }

            foreach(var filter in filters)
            {
                guests.RemoveAll(filter.Value);
            }

            Console.WriteLine(string.Join(" ", guests));
        }
        static Predicate<string> Predicates(string command, string value)
        {
            switch (command)
            {
                case "Starts with":
                    {
                        return x => x.StartsWith(value);
                    }
                case "Ends with":
                    {
                        return x => x.EndsWith(value);
                    }
                case "Length":
                    {
                        return x => x.Length == int.Parse(value);
                    }
                case "Contains":
                    {
                        return x => x.Contains(value);
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}