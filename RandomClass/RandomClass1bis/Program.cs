using System;

namespace RandomClass1bis
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            
                System.Console.Write((char)random.Next(97,122));
                System.Console.WriteLine();
            
        }
    }
}