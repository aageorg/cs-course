using System;
using System.Text;
using System.Threading;

namespace textString
{
    class Program
    {
        static bool IsNormalText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            if (text.Split(" ").Length <2)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input;
            int erCount = 0;
            do
            {
                if (erCount>0)
                {
                    Console.WriteLine("There should be at least 2 words in a string!");
                }
                Console.WriteLine("Please, enter the text:\n");
                input = Console.ReadLine();
                erCount++;
            }
            while (!IsNormalText(input));
            //Console.WriteLine(input.Length);
            var words = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int countFromA = 0;
            foreach (string word in words)
            {
                
                if (word.StartsWith("а", StringComparison.CurrentCultureIgnoreCase) ||
                    word.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
                {
                    countFromA++;
                }
            }
            Console.WriteLine("\nThe first task:");
            Console.WriteLine($"The string contains {countFromA} word(s) starts form A");
            Console.WriteLine("\nThe second task:");
            for (int i = input.Length-1; i>=0; i--)
            {
                Console.Write(input.Substring(i,1));
            }
            Console.WriteLine("\n");
        } 
    }
}
