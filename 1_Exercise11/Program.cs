using System;

namespace _1_Exercise11
{
    // a program that reads your age from the console and prints your
    // age after 10 years
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user his current age
            Console.WriteLine("Please type is your current Age");
            int currentAge = Convert.ToInt16(Console.ReadLine());
            int ageAfterTenYears = currentAge + 10;
            Console.WriteLine("Your Age after 10 years is " + ageAfterTenYears + " Years");
        }
    }
}
