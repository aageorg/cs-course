using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Array
            string[] students = new string[3];
            int[] ages = new int[3];
            Console.WriteLine("Please enter names of 3 people:");
            for(int i = 0; i<students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("\nPlease enter ages of 3 people:");
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write(students[i] + "'s age: ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n4 years later (result):");
            for (int i=0; i<students.Length; i++)
            {
                int ageNew = ages[i] + 4;
                Console.WriteLine(students[i] + " " + ageNew);
            }


            //Associative array:
            Console.WriteLine("\n\nEnter names and ages of 3 people:");
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("The name: ");
                string name = Console.ReadLine();
                while (people.ContainsKey(name))
                {
                    Console.WriteLine(name + " already present. ");
                    Console.Write("The name: ");
                    name = Console.ReadLine();
                }
                people.Add(name, 0);
                Console.Write(name + "'s age: ");
                people[name] = int.Parse(Console.ReadLine()) + 4;
                
            }
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, int> keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " " + keyValue.Value + " y.o.");
            }
        }
    }
}
