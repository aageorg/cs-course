using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //*****************
            // List
            //*****************


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
            double average = sum / (double) numbers.Count;
            Console.WriteLine($"The sum of these numbers is {sum}\nThe average of these numbers is {average}");


            //*****************
            // Dictionary
            //*****************


            int round;

            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries["Россия"] = "Москва";
            countries["Франция"] = "Париж";
            countries["Германия"] = "Берлин";
            countries["Нидерланды"] = "Амстердам";
            countries["Япония"] = "Токио";
            countries["США"] = "Вашингтон";
            countries["Китай"] = "Пекин";

            string country = "";
            string capital = "";

            do
            {
                round = new Random().Next(1, countries.Count);
                int i = 0;
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


            //*****************
            // Queue
            //*****************


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


            //*****************
            // Stack
            //*****************

        }
    }
}
