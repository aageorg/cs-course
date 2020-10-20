using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fnums = new FiboNumbers(9);
            foreach (int i in fnums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
/* Output:
 * 
 * 0
 * 1
 * 1
 * 2
 * 3
 * 5
 * 8
 * 13
 * 21
 * 
 */