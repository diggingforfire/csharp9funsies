using System;

namespace SkipLocalsInit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        [System.Runtime.CompilerServices.SkipLocalsInit]
        public static int Method()
        {
            int p;
            int q;

            p = 5;
            q = 10;

            return p * q;
        }

        public static int Method2()
        {
            int p;
            int q;

            p = 5;
            q = 10;

            return p * q;
        }
    }
}

