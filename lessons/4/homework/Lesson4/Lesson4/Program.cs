using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;

enum Containers
{
    Little = 1,
    Medium = 5,
    Large = 20,    
}

namespace Lesson4
{
    class Program
    {
        static int MaxContainer()
        {
            int max = 0;
            foreach (int i in Enum.GetValues(typeof(Containers)))
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static dynamic ValidateInput(string input)
        {
            if (!decimal.TryParse(input.Replace(".", ","), out decimal i))
            {
                Console.WriteLine("Недопустимое значение. Введите число.");
                return false;
            }
            if (i > Int32.MaxValue || i < 1)
            {
                Console.WriteLine("Допустимый диапазон значений от 1 до "+ Int32.MaxValue + ". Введите число.");
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            decimal search;
            string liters;
            do
            {
                Console.WriteLine("Введите количество сока в литрах:");
                liters = Console.ReadLine();
            }
            while (!ValidateInput(liters));
            
            search = Math.Ceiling(decimal.Parse(liters.Replace(".",",")));
            Console.WriteLine("You need:");


            for (int i = MaxContainer(); i>0; i--)
            {
                if(Enum.IsDefined(typeof(Containers), i) == true)
                {
                    Console.WriteLine((int)search/i + " " + (Containers)i + " container(s) (" + i + "L)");
                    i = ((int)search % i);
                    search = i;
                    i++;
                }
            }
        }
    }
}
