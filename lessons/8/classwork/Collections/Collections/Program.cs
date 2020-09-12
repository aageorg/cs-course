using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Collections
{
    class Program
    {
        
        //*****************
        // List
        //*****************
        
        static void ListSample()
        {
            List<double> numbers = new List<double> { };
            Console.WriteLine("Please, enter the double value:");
            string input = Console.ReadLine();

            while (input != "stop")
            {
                try
                {
                    double number = double.Parse(input);
                    numbers.Add(number);
                    input = Console.ReadLine();
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    input = Console.ReadLine();
                }
            }
            double sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            double average = sum / (double)numbers.Count;
            Console.WriteLine($"The sum of these numbers is {sum}\nThe average of these numbers is {average}");
        }

        
        //*****************
        // Dictionary
        //*****************
        
        static void DictionarySample()
        {
            int round;

            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                ["Россия"] = "Москва",
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин",
                ["Нидерланды"] = "Амстердам",
                ["Япония"] = "Токио",
                ["США"] = "Вашингтон",
                ["Китай"] = "Пекин",
            };
            string country = "";
            string capital = "";

            do
            {
                round = new Random().Next(1, countries.Count+1);
                int i = 1;
                foreach (var (key, value) in countries)
                {
                    if (i != round)
                    {
                        i++;
                        continue;
                    }
                    Console.WriteLine($"{key}: ");
                    country = key;
                    capital = Console.ReadLine();
                    break;
                }
                if (countries[country].ToLower() == capital.ToLower())
                {
                    Console.WriteLine("Правильно, молодец!");
                }
                else
                {
                    Console.WriteLine("Вы проиграли :(");
                    break;
                }
            }
            while (true);
        }


        //*****************
        // Queue
        //*****************

        static void QueueSample()
        {
            Queue<int> nums = new Queue<int>();
            string val;
            bool status = true;
            int toQueue;
            int n;

            do
            {
                Console.WriteLine("Введите целое число:");
                val = Console.ReadLine();
                switch (val)
                {
                    case "run":
                        while (nums.Count > 0)
                        {
                            n = nums.Dequeue();
                            Console.WriteLine($"Sqtr from {n}: {Math.Sqrt(n)}");
                        }
                        status = false;
                        break;
                    case "exit":
                        Console.WriteLine($"You have {nums.Count} items in queue");
                        status = false;
                        break;
                    default:
                        if (!int.TryParse(val, out toQueue))
                        {
                            Console.WriteLine("Введено некорректное значение. Попробуйте снова.");
                            continue;
                        }
                        nums.Enqueue(toQueue);
                        break;
                }
            }
            while (status == true);
        }

        
        //*****************
        // Stack
        //*****************

        static void StackSample()
        {
            string input;
            Stack<int> plates = new Stack<int>();
            Console.WriteLine("Введите \"wash\", \"dry\" или \"exit\"");
            do
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "wash":
                        plates.Push(1);
                        Console.WriteLine($"В стопке теперь {plates.Count} тарелок");
                        break;
                    case "dry":
                        if (plates.Count > 0)
                        {
                            plates.Pop();
                            Console.WriteLine($"В стопке осталось {plates.Count} тарелок");
                        }
                        else
                        {
                            Console.WriteLine("Стопка тарелок пуста");
                        }
                        break;
                    case "exit":
                        continue;
                    default:
                        Console.WriteLine("Неверная команда. Введите \"wash\", \"dry\" или \"exit\"");
                        break;
                }
            }
            while (input != "exit");
            Console.WriteLine($"Количество тарелок, оставшихся в стопке: {plates.Count}");
        }
        static void Main(string[] args)
        {
            //ListSample();

            DictionarySample();

           // QueueSample();

           // StackSample();

        }
    }
}
