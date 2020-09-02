using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double doubleA;
            double doubleB;
            byte byteAct;

            try
            {
                Console.WriteLine("Please, enter the first number:");
                doubleA = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!\n\n");
                Console.WriteLine("Please, enter the first number:");
                doubleA = double.Parse(Console.ReadLine());

            }
            try
            {
                Console.WriteLine("Please, enter the second number:");
                doubleB = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong input!\n\n");
                Console.WriteLine("Please, enter the second number:");
                doubleB = double.Parse(Console.ReadLine());

            }


            Console.WriteLine("Please select an operator (1-6):");
            Console.WriteLine("1 (+)           3 (*)          5 (%)");
            Console.WriteLine("2 (-)           4 (/)          6 (^)\n");
            byteAct = byte.Parse(Console.ReadLine());
                   

            double result;
            switch (byteAct)
            {
                case 1:
                    result = doubleA + doubleB;
                    Console.WriteLine(doubleA + "+ " + doubleB + " = " + result);
                    break;
                case 2:
                    result = doubleA - doubleB;
                    Console.WriteLine(doubleA + " - " + doubleB + " = " + result);
                    break;
                case 3:
                    result = doubleA* doubleB;
                    Console.WriteLine(doubleA + " * " + doubleB + " = " + result);
                    break;
                case 4:
                    result = doubleA / doubleB;
                    Console.WriteLine(doubleA + " / " + doubleB + " = " + result);
                    break;
                case 5:
                    result = doubleA % doubleB;
                    Console.WriteLine(doubleA + " % " + doubleB + " = " + result);
                    break;
                case 6:
                    result = Math.Pow(doubleA, doubleB);
                    Console.WriteLine(doubleA + " ^ " + doubleB + " = " + result);
                    break;
            }
        }

    }
}



    
    

