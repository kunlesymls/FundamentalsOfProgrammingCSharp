using System;

namespace _1_Exercise9
{
    // A program that prints the square root of 12345
    class Program
    {
        static void Main(string[] args)
        {
            double number = 12345;
            double squareRoot = Math.Sqrt(number);
            Console.WriteLine(squareRoot);

            // Another way of doing thesame is 
            //Console.WriteLine(Math.Sqrt(12345));
        }
    }
}
