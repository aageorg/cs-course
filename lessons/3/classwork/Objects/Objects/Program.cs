using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 5;
            Console.WriteLine((int)a+5);

            string[] array = new string[5];
            for (int i = 0; i < array.Length; i++) {
                Console.Write("Введите " + i + "-й элемент: ");
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}