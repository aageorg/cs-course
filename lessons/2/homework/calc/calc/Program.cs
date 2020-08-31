using System;

namespace calc
{
    class Program
    {
        static void Main()
        {
            string a;
            string b;
            string act;
            double doubleA;
            double doubleB;
            byte byteAct;

            do
            {
                Console.WriteLine("Please, enter the first number:");
                a = Console.ReadLine();
                Console.WriteLine("Please, enter the second number:");
                b = Console.ReadLine();
            }
            while (!double.TryParse(a, out doubleA) || !double.TryParse(b, out doubleB));

            do
            {
                Console.WriteLine("Please select an operator (1-6):");
                Console.WriteLine("1 (+)           3 (*)          5 (%)");
                Console.WriteLine("2 (-)           4 (/)          6 (^)\n");
                act = Console.ReadLine();
            }
            while (!byte.TryParse(act, out byteAct));
         
            calc.Program.Calculate(doubleA, doubleB, byteAct);
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
                    Console.WriteLine(a + " ^ " + b + " = " + result);
                    break;
            }
        }
    }
}
