using System;

namespace Exercice7
{
    class Program
    {
        public static void Main(string[] args)
        {
          System.Console.WriteLine("Enter a number: ");
          var number = Convert.ToInt32(System.Console.ReadLine());
            
        var fac = 1;

        for(var i = 1; i <= number; i++)
        {
            fac *=i;
        }
        System.Console.WriteLine("La factorielle du nombre: {0}! = {1} ",number,  fac);
        }
    }
}    