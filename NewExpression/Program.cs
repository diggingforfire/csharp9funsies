using System;
using System.Collections.Generic;

namespace NewExpression
{
    class Program
    {
        private List<string> _names = new();
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Method("Peter", new());

            Book b = new()
            {
                Title = "I am legend",
                Author = "Richard Matheson",
                Genre = "Dystopian"
            };
        }

        static void Method(string name, List<string> names)
        {
            if (names != null)
            {
                Console.WriteLine(name);
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

    }
}
