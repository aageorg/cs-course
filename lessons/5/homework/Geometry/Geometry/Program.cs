using System;
using System.Net;


enum Figures
{
    Circle = 1,
    Triangle = 2,
    Rectange = 3
}

namespace Geometry
{
    class Program
    {
        static double DoubleValid(string a)
        {
            double result;
            while (!double.TryParse(a.Replace(".", ","), out result))
            {
                Console.Write("\nНедопустимое значение.\nПопробуйте снова: ");
                a = Console.ReadLine();
            }
            return result;
        }
        static void Main(string[] args)
        {
            int wrongCount = 0;
            string figure;
            Figures figureNum;

            do
            {
                if (wrongCount > 0)
                {
                    Console.WriteLine("Неверное значение. Попробуйте снова\n");
                }
                Console.WriteLine("Введите тип фигуры:\n\n1 - круг\n2 - равносторонний треугольник\n3 - прямоугольник\n");
                figure = Console.ReadLine();
                wrongCount++;
            }
            while (!Figures.TryParse(figure, out figureNum) || !Enum.IsDefined(typeof(Figures), figureNum));
            double s;
            double p;
            string outString = "";
            dynamic input;
            switch (figureNum)
            {
                case Figures.Circle:
                    outString = "круга";
                    Console.Write("Введите диаметр " + outString + ": ");
                    input = Console.ReadLine();
                    input = DoubleValid(input);
                    s = Math.PI * Math.Pow(input / 2d, 2);
                    p = Math.PI * input;
                    break;
                case Figures.Triangle:
                    outString = "треугольника";
                    Console.Write("Введите длину стороны " + outString + ": ");
                    input = Console.ReadLine();
                    input = DoubleValid(input);
                    s = (Math.Pow(input, 2) * Math.Sqrt(3))/4d;
                    p = input * 3;
                    break;
                case Figures.Rectange:
                    outString = "прямоугольника";
                    Console.Write("Введите длину " + outString + ": ");
                    input = Console.ReadLine();
                    double x = DoubleValid(input);
                    Console.Write("Введите высоту " + outString + ": ");
                    input = Console.ReadLine();
                    double y = DoubleValid(input);
                    s = x*y;
                    p = (x+y)*2;
                    break;
                default:
                    s = 0;
                    p = 0;
                    break;
            }
            Console.WriteLine("\nПлощадь " + outString + " " + (decimal)s);
            Console.WriteLine("Периметр " + outString + " " + (decimal)p);
        }
    }
}
