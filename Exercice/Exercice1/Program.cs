using System;

namespace Exercice1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("The number should be between 1 to 10:");
            var input = Convert.ToInt32(System.Console.ReadLine());
            var number = Convert.ToInt32(input);

            if (number >=1 && number <=10)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
    }
}