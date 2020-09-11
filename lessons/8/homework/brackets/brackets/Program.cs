using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Brackets
{
    class Program
    {
        static bool BracketsValidator(string line)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>(4);
            brackets['['] = ']';
            brackets['('] = ')';
            brackets['{'] = '}';
            brackets['<'] = '>';

            Stack<char> bracketStack = new Stack<char>();
                  
            foreach (char i in line)
            {
                if(brackets.ContainsKey(i))
                {
                    bracketStack.Push(i); 
                }
                else
                {
                    if (!bracketStack.TryPeek(out char open) || brackets[open] != i)
                    {
                        return false;
                    }
                    bracketStack.Pop();
                }
            }
            if (bracketStack.Count>0)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string[] lines = {"()", "[]()", "[[]()]", "([([])])()[]", "(", "[][)", "[(])", "(()[]]", "[<{}>]{()}", "[<{}>]{()" };

            foreach (string line in lines)
            {
                Console.WriteLine($"{ line}  {BracketsValidator(line)}");
            }
        }
    }
}
