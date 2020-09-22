using System;

namespace PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object b = 25;

            Console.WriteLine(IsByte(b));
        }


        // and, or and not
        // precedence with parantheses
        // type matching
        // relational
        static bool IsByte(object b)
        {
            return b is byte and (>= 0 and <= 127 or >= 127 and <= 255) or (1337) and not (2000);
        }
    }
}
