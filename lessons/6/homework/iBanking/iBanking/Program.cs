using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace iBanking
{
    class Program
    {
        static bool ValidateInput(string input, decimal maxValue, decimal minValue = 1)
        {
            if (!decimal.TryParse(input.Replace(".", ","), out decimal i))
            {
                Console.WriteLine("Нечисловое значение. Введите число.");
                return false;
            }
            if (i == 0)
            {
                Console.WriteLine("Число не может быть равно нулю");
                return false;
            }
            if (i > maxValue || i < minValue)
            {
                Console.WriteLine("Допустимый диапазон значений от " + minValue + " до " + maxValue + ". Введите число.");
                return false;
            }

            return true;
        }
        static void IBanking()
        {
            decimal amount;
            decimal dailyPercent;
            decimal awaiting;
            string input;
            do
            {
                Console.WriteLine("Введите сумму первоначального взноса в рублях:");
                input = Console.ReadLine();
            }
            while (!ValidateInput(input, int.MaxValue));
            amount = decimal.Parse(input.Replace(".", ","));
            do
            {
                Console.WriteLine("Введите ежедневный процент дохода в виде десятичной дроби (1% = 0.01):");
                input = Console.ReadLine();
            }
            while (!ValidateInput(input, 1, 0));
            dailyPercent = decimal.Parse(input.Replace(".", ","));
            do
            {
                Console.WriteLine("Введите желаемую сумму накопления в рублях:");
                input = Console.ReadLine();
            }
            while (!ValidateInput(input, decimal.MaxValue - (2 * amount), amount + 1));
            awaiting = decimal.Parse(input.Replace(".", ","));

            int dayX = 0;
            while (amount < awaiting)
            {
                amount += amount * dailyPercent;
                dayX++;
            }
            Console.WriteLine("Необходимое количество дней для накопления желаемой суммы: " + dayX);
        }

        static void EvenCalc()
        {
            string input;
            int number;
            do
            {
                Console.WriteLine("Введите положительное натуральное число:");
                input = Console.ReadLine();
            }
            while (!ValidateInput(input, 2000000000, 1) || !int.TryParse(input, out number));
            int even = 0;
 
            foreach (Char i in number.ToString()) 
            {
                if (((int)i&1) == 0 ) // эксперимент
                {
                    even++;
                }
            }
            Console.WriteLine("В числе " + number + " содержится следующее количество четных цифр: " + even);
        }
        static void Main(string[] args)
        {
            EvenCalc();
            IBanking();
            

        }
    }
}
