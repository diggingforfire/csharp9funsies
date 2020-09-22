using System;
using System.Runtime.CompilerServices;

namespace LocalFunctionAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            unsafe
            {
                Console.WriteLine(Add(1, 3));

                [SkipLocalsInit]
                static int Add(int a, int b)
                {
                    return a + b;
                }
            }

        }
    }
}
