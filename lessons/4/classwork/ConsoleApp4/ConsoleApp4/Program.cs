using System;
using System.Text.RegularExpressions;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string h;
            Console.WriteLine("Please enter a:");
            a = Console.ReadLine();
            Console.WriteLine("Please enter H:");
            h = Console.ReadLine();
            if (Regex.IsMatch(a, "^[0-9]*[,]?[0-9]+$") && Regex.IsMatch(h, "^[0-9]*[,]?[0-9]+$"))
            {
                double doubleA = double.Parse(a);
                double doubleH = double.Parse(h);
                var result1 = 3 * doubleA * doubleH;
                Console.WriteLine("S1 = " + result1);
                var result2 = (Math.Sqrt(3) * doubleA + 2 * doubleH) * (3.0d / 2.0d) * doubleA;
                Console.WriteLine("S2 = " + result2);
                var result3 = Math.Sqrt(Math.Pow(doubleH, 2) - (Math.Pow(doubleA, 2) / 12.0d));
                Console.WriteLine("H = " + Math.Round(result3));
                var result4 = Math.Pow(doubleA, 2) / 2.0d * result3 * Math.Sqrt(doubleH);
                Console.WriteLine("V = " + result4);
            }
            else { 
            
            }


        }
    }
}
