using System;

namespace Exercice2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the first number:");
            var number1 = Convert.ToInt32(System.Console.ReadLine());
            
            System.Console.WriteLine("Enter the second number:");
            var number2 = Convert.ToInt32(System.Console.ReadLine());

            var maxNumber = (number1 > number2) ? number1 : number2;
            System.Console.WriteLine("Max number is " + maxNumber);
        }
    }
}