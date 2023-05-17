using System;

namespace Exercice6
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                System.Console.Write("Enter a number or 'ok' to exit: ");
                var input = System.Console.ReadLine();
                
                if(input.ToLower() == "ok")
                {
                break;
                }
                else
                {
                sum += Convert.ToInt32(input);
                }  

                System.Console.WriteLine("sum of all numbers is:" + sum);
            }
        }
    }
}