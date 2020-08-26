using System;

namespace colors
{
    class Program
    {
        enum Colors
        {
            Black = 1,
            Blue,
            Cyan,
            Grey,
            Green,
            Magenta,
            Red,
            White,
            Yellow
        };
        static void Main(string[] args)
        {

            foreach (int i in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(i + ". " + (Colors) i);
            }
            Console.WriteLine("\nPlease enter 4 your favorite colors:");
            int favorite = 0;

            for (int f = 0; f < 4; f++)
            {
                int colorNum = int.Parse(Console.ReadLine());
                favorite |= (1 << colorNum);
            }
            Console.WriteLine("\nYour favorite colors:");

            foreach (int i in Enum.GetValues(typeof(Colors)))
            {
                if (((1 << i) & favorite) != 0)
                {
                    Console.WriteLine((Colors)i);
                }
            }

            Console.WriteLine("\nOther colors:");
            foreach (int i in Enum.GetValues(typeof(Colors)))
            {
                if (((1 << i) & favorite) == 0)
                {
                    Console.WriteLine((Colors)i);
                }
            }
        }
    }
}
