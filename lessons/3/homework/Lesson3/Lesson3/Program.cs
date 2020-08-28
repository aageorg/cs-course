using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Associative array:
            Console.WriteLine("Ener names and ages of 3 people:");
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i<3; i++)
            {
                Console.Write("The name: ");
                string name = Console.ReadLine();
                people.Add(name, 0);
                Console.Write(name + "'s age: ");
                people[name] = int.Parse(Console.ReadLine()) + 4;
            }
            Console.WriteLine("/n");
            foreach (KeyValuePair<string, int> keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value + " y.o.");
            }
        }
    }
}
