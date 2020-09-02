using System;
using System.Net;


enum Figures
{
    круг = 1,
    треугольник = 2,
    прямоугольник = 3
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
            int figureNum;

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
            while (!int.TryParse(figure, out figureNum) || !Enum.IsDefined(typeof(Figures), figureNum));
            double s;
            double p;
            dynamic input;
            switch (figureNum)
            {
                case 1:
                    Console.Write("Введите диаметр круга: ");
                    input = Console.ReadLine();
                    input = DoubleValid(input);
                    s = Math.PI * Math.Pow(input / 2d, 2);
                    p = Math.PI * input;
                    break;
                case 2:
                    Console.Write("Введите длину стороны треугольника: ");
                    input = Console.ReadLine();
                    input = DoubleValid(input);
                    s = (Math.Pow(input, 2) * Math.Sqrt(3))/4d;
                    p = input * 3;
                    break;
                case 3:
                    Console.Write("Введите длину прямоугольника: ");
                    input = Console.ReadLine();
                    double x = DoubleValid(input);
                    Console.Write("Введите высоту прямоугольника: ");
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
            Console.WriteLine("\nПлощадь " + (Figures) figureNum + "а: " + (decimal)s);
            Console.WriteLine("Периметр " + (Figures) figureNum + "а: " + (decimal)p);
        }
    }
}
