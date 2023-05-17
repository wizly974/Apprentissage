using System;

namespace Iterations3bis
{
    class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
            System.Console.Write("Type your name:");
            var input = System.Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            break;

            System.Console.WriteLine("@Echo: " + input);
            }        
        }
    }
}