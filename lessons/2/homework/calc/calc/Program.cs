using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace calc
{
    class Program
    {
        static void Main()
        {

            string a;
            string b;

            Console.WriteLine("Please, enter the first number:");
            a = Console.ReadLine();
            Console.WriteLine("Please, enter the second number:");
            b = Console.ReadLine();
            if (Regex.IsMatch(a, "^(-)?[0-9]*[.]?[0-9]+$") && Regex.IsMatch(b, "^(-)?[0-9]*[.]?[0-9]+$"))
            {
                Console.WriteLine("Please select an operand (1-6):");
                Console.WriteLine("1 (+)           3 (*)          5(%)");
                Console.WriteLine("2 (-)           4 (/)          6(^)\n");
                string act = Console.ReadLine();

                if (Regex.IsMatch(act, "^[1-6]{1}$"))
                {
                    calc.Program.Calculate(double.Parse(a), double.Parse(b), byte.Parse(act));
                }
                else
                {
                    Console.WriteLine("Wrong input. ");
                    calc.Program.Main();
                }


             }
            else {
                Console.WriteLine("Wrong input. ");
                calc.Program.Main();
            }
            

        }
  
        static void Calculate(double a, double b, byte act) {
      
            double result;
            switch (act)
            {
                case 1:
                    result = a + b;
                    Console.WriteLine(a + "+ " + b + " = " + result);
                    
                    break;
                case 2:
                    result = a - b;
                    Console.WriteLine(a + " - " + b + " = " + result);
                    break;
                case 3:
                    result = a * b;
                    Console.WriteLine(a + " * " + b + " = " + result);
                    break;
                case 4:
                    result = a / b;
                    Console.WriteLine(a + " / " + b + " = " + result);
                    break;
                case 5:
                    result = a % b;
                    Console.WriteLine(a + " % " + b + " = " + result);
                    break;
                case 6:
                    result = Math.Pow(a, b);
                    Console.WriteLine(a+" ^ "+b+" = "+ result);
                    break;
            }

        }

    }
}
