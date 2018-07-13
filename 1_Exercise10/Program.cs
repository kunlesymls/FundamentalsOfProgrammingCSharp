using System;

namespace _1_Exercise10
{

    // a program that prints the first 100 members of the sequence 2, -
    // 3, 4, -5, 6, -7, 8
    class Program
    {
        static void Main(string[] args)
        {
            // Iterating from 2 to 100
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0) // Checking if the current value is divisible by zero
                {
                    Console.WriteLine(i); // Dont add minus if its divisible by zero
                }
                else
                {
                    Console.WriteLine("-" + i); //  add minus if its not divisible by zero
                }
            }
        }
    }
}
