namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = ReadPeople(n);
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = FilterByCondition(condition, age);
            Action<Person> printer = PrintPeople(format);
            PrintFilteredPeople(people, filter, printer);

        }

        static List<Person> ReadPeople(int n)
        {
            List<Person> list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(", ");
                string name = s[0];
                int age = int.Parse(s[1]);

                Person person = new Person();
                person.age = age;
                person.name = name;

                list.Add(person);
            }
            return list;
        }

        static Func<Person, bool> FilterByCondition(string condition, int age)
        {
            if(condition == "older")
            {
                return person => person.age >= age;
            }
            else
            {
                return person => person.age < age;
            }
        }

        static Action<Person> PrintPeople(string format)
        {
            switch(format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.name}");

                case "age":
                    return person => Console.WriteLine($"{person.age}");

                case "name age":
                    return person => Console.WriteLine($"{person.name} - {person.age}");

                default: throw new ArgumentException(format);
            }
        }
        static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            people = people.Where(x => filter(x)).ToList();
            foreach(Person person in people)
            {
                printer(person);
            }
        }

        class Person
        {
            public int age = 0;
            public string name = "";
        }
    }
}