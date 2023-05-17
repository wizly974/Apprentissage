using System;

namespace RandomClass1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next(1,10));
                System.Console.WriteLine();
            }
        }
    }
}