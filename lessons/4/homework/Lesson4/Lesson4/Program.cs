using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

enum Containers
{
    Little = 1,
    Medium = 5,
    Large = 20   
    
}

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int search;
            Console.WriteLine("Введите количество сока в литрах:");
            decimal liters = Math.Ceiling(decimal.Parse(Console.ReadLine()));
            search = (int)liters;
            Console.WriteLine("You need:");

            for (int i = search; i>0; i--)
            {
                if(Enum.IsDefined(typeof(Containers), i) == true)
                {
                    Console.WriteLine(search/i + " " + (Containers)i + " container(s) (" + i + "L)");
                    i = ((int)liters % i);
                    search = i;
                }
            }
        }
    }
}
