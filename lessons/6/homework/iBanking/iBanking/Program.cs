using System;

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
            if (i <= 0)
            {
                Console.WriteLine("Значение не может быть равно нулю");
                return false;
            }
            if (i > maxValue || i < minValue)
            {
                Console.WriteLine("Допустимый диапазон значений от 1 до " + maxValue + ". Введите число.");
                return false;
            }

            return true;
        }
        static void Main(string[] args)
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
            while (!ValidateInput(input, 100, 0));
            dailyPercent = decimal.Parse(input.Replace(".",","));
            do
            {
                Console.WriteLine("Введите желаемую сумму накопления в рублях:");
                input = Console.ReadLine();
            }
            while (!ValidateInput(input, decimal.MaxValue/2, amount+1));
            awaiting = decimal.Parse(input.Replace(".", ","));

            int dayX = 0;
            while (amount < awaiting)
            {
                amount += amount * dailyPercent;
                dayX++;
            }
            Console.WriteLine("Необходимое количество дней для накопления желаемой суммы: " + dayX);
        }
    }
}
