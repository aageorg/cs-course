using System;
using System.Transactions;

namespace Incapsulation
{
    class Program
    {

        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the name:");
                        persons[i].Name = Console.ReadLine();
                    }
                    catch (ArgumentException aEx)
                    {
                        Console.WriteLine(aEx.Message);
                        continue;
                    }
                    break;
                }
                

                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter {persons[i].Name} age:");
                        if (!int.TryParse(Console.ReadLine(), out int result))
                        {
                            Console.WriteLine("Age should be a number");
                            continue;
                        }
                        persons[i].Age = result;
                    }
                    catch (ArgumentException aEx)
                    {
                        Console.WriteLine(aEx.Message);
                        continue;
                    }
                    break;
                }
            }

            foreach (Person somebody in persons)
            {
                Console.WriteLine(somebody.GetPersonInfo(4));
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }

    class Person
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Should be not empty");
                }
                _name = value;
            }
        }
        private int _age;
        
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value should be positive");
                }
                _age = value;
            }
        }

        public string GetPersonInfo(int delta)
        {
            if ((Age + delta) < 0)
            {
                return $"Name {Name}, age in {delta} years: the date before the birth date";
            }

            return $"Name {Name}, age in {delta} years: {Age+delta}";
        }
        
    }
}
