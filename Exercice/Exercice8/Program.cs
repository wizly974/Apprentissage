using System;

namespace Exercice8
{
    class Program
    {
        public static void Main(string[] args)
        {
            var number = new Random().Next(1,10);
            System.Console.WriteLine("Secret is " + number);
            

            for (var i = 0; i < 4; i++)
            {
                System.Console.Write("Guess the number: ");
                var guess = Convert.ToInt32(System.Console.ReadLine());

            
                if (guess == number)
                {
                    System.Console.WriteLine("you won!");
                    return;                    
                }
            }
            System.Console.WriteLine("You lost!");
        }
    }
}    