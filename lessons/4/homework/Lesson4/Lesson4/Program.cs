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

        static int NumOfContainers()
        {
            int total = 0;
            foreach (int i in Enum.GetValues(typeof(Containers)))
            {
                total++;
            }
            return total;

        }

        static bool ValidateInput(string input)
        {
            if (!decimal.TryParse(input.Replace(".", ","), out decimal i))
            {
                Console.WriteLine("Недопустимое значение.\nВведите число.");
                return false;
            }
            if (i > Int32.MaxValue || i < 1)
            {
                Console.WriteLine("Допустимый диапазон значений от 1 до "+ Int32.MaxValue + ".\nВведите число.");
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

            //Решение с флагами:

            int[] count = new int[MaxContainer()+1];
            int visible = 0;
            for (int i = MaxContainer(); i > 0; i--)
            {
                if (Enum.IsDefined(typeof(Containers), i) == true)
                {
                    count[i] = (int)search / i;
                    if (count[i]!=0)
                    {
                        visible |= (1 << i);
                    }
                    search = (int)search % i;
                }
            }

            foreach (int i in Enum.GetValues(typeof(Containers)))
            {
                if (((1 << i) & visible) != 0)
                {
                    Console.WriteLine(count[i] + " " + (Containers)i + " container(s) (" + i + "L)");
                }
            }


            /* Короткое решение:
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
            */
        }
    }
}
