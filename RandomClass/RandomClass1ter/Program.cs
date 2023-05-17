using System;

namespace RandomClass1ter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            
                System.Console.Write((char)('a' + random.Next(0, 26)));
                System.Console.WriteLine();
            
        }
    }
}