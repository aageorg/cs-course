using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter two numbers");
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal result1 = a + b;
            decimal result2 = a * b;
            decimal result3 = a / b;
            Console.WriteLine(a + " + " + b + " = " + result1.ToString("N2"));
            Console.WriteLine(String.Format("{0} * {1} = {2:0.##}", a, b, result2));
            Console.WriteLine($"{a} / {b} = {result3:0.##}");
            

            string result1 = "";
            string result2 = "";

            string text = "    lorem    ipsum     dolor   sit     amet    ";
            
            var array = text.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            array[1] = array[1].ToUpper();
            result1 = string.Join(" ", array);
            Console.WriteLine(result1);
            int end = text.TrimEnd().LastIndexOf(" ");
            result2 = text.TrimEnd().Substring(0,end);
            Console.WriteLine(result2);
            */



            string text = "    lorem    ipsum     dolor   sit     amet    ";


            /******************
             * The first task
             ******************/

            StringBuilder firstSB = new StringBuilder(text, text.Length);
            bool notFirstWhiteSpace = false;
            Console.WriteLine("The first task:");
            // removes start whitespaces:
            while (Char.IsWhiteSpace(firstSB[0]))
            {
                firstSB.Remove(0, 1);
            }
            // removes end whitespaces:
            while (Char.IsWhiteSpace(firstSB[firstSB.Length - 1]))
            {
                firstSB.Remove(firstSB.Length - 1, 1);
            }
            //removes duplicate whitespaces in a middle:
            for (int i = firstSB.Length-1; i >0; i--)               
            {                
                if (Char.IsLetterOrDigit(firstSB[i]) || Char.IsPunctuation(firstSB[i]))
                { 
                    notFirstWhiteSpace = false;
                    continue;
                }
                if (Char.IsWhiteSpace(firstSB[i]) && notFirstWhiteSpace)
                {
                   firstSB.Remove(i, 1);
                }
                else
                {
                    notFirstWhiteSpace = true;
                }
            }
            // Uppercase second word:
            for (int i = 0; i < firstSB.Length; i++)
            {
                if (Char.IsWhiteSpace(firstSB[i]))
                {
                    i++;
                    while(!Char.IsWhiteSpace(firstSB[i]))
                    {
                        firstSB.Replace(firstSB[i], char.ToUpper(firstSB[i]), i,1);
                        i++;
                    }
                    break;
                }
            }            
            Console.WriteLine(firstSB.ToString());


            /*****************
             * The second task
             *****************/

            Console.WriteLine("\nThe second task:");
            StringBuilder secondSB = new StringBuilder(text, text.Length*2);

            // Removes last word:
            for (int i = secondSB.Length-1; i >=0; i--)
            {
                if (Char.IsLetterOrDigit(secondSB[i]) || Char.IsPunctuation(secondSB[i]))
                {
                    while (!Char.IsWhiteSpace(secondSB[i]))
                    {
                        secondSB.Remove(i, 1);
                        i--;
                    }
                    break;
                }
            }
            // removes end whitespaces:
            while (Char.IsWhiteSpace(secondSB[secondSB.Length - 1]))
            {
                secondSB.Remove(secondSB.Length - 1, 1);
            }
            Console.WriteLine(secondSB.ToString());

        }
    }
}
