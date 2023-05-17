using System.Collections;
using System.Dynamic;
using System;

namespace Exercice_test
{
    class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("enter a number");
           var number = Convert.ToInt32(System.Console.ReadLine());
           var ligne = "-------";
           for (int i = 1; i <= number; i++)
           {
                System.Console.WriteLine(ligne);
           }
        }
    }
}