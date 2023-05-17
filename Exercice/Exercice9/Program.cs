using System;

namespace Exercice9
{
    class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter comma separated number: ");
           var input = Console.ReadLine();

           var numbers = input.Split(',');
           var maxNumber = Convert.ToInt32(numbers[0]);

           foreach (var str in numbers)
           {
            var number = Convert.ToInt32(str);
            if (number > maxNumber)
                maxNumber = number;
           }
            System.Console.WriteLine("max is " + maxNumber);

        }
    }
}    