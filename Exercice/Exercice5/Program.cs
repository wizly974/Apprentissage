using System;

namespace Exercice5
{
    class Program
    {
        public static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    count++;
                }
            }
            System.Console.WriteLine("total number between 1 to 100 divisible by 3 are: {0}" ,count);
        }
    }
}