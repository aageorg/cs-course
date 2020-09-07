using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal result1 = a + b;
            decimal result2 = a * b;
            decimal result3 = a / b;
            Console.WriteLine(a + " + " + b + " = " + result1.ToString("N2"));
            Console.WriteLine(String.Format("{0} * {1} = {2:0.##}", a, b, result2));
            Console.WriteLine($"{a} / {b} = {result3:0.##}");
        }
    }
}
