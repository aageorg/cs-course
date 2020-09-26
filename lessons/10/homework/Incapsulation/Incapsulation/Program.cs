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
                do
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
                while (true);

                do
                {
                    try
                    {
                        Console.WriteLine($"Enter {persons[i].Name} age:");
                        persons[i].Age = Console.ReadLine();
                    }
                    catch (ArgumentException aEx)
                    {
                        Console.WriteLine(aEx.Message);
                        continue;
                    }
                    break;
                }
                while (true);
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
                if (string.IsNullOrWhiteSpace(value) 
                    || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Should be not empty");
                }
                _name = value;
            }
        }
        private int _age;
        
        public string Age
        {
            get => _age.ToString();
            set
            {
                if (!int.TryParse(value, out int result))
                {
                    throw new ArgumentException("Value should be a number");
                }
                if (result < 0)
                {
                    throw new ArgumentException("Value should be positive");
                }
                _age = result;
            }
        }

        public string GetPersonInfo(int delta)
        {
            if ((_age + delta) < 0)
            {
                return $"Name {_name}, age in {delta} years: the date before the birth date";
            }

            return $"Name {_name}, age in {delta} years: {_age+delta}";
        }
        
    }
}
