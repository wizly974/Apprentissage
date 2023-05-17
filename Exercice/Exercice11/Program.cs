using System;


namespace Exercice11
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your name: ");
            var input = System.Console.ReadLine();
            var name = input.ToCharArray();
            Array.Reverse(name);
            var reverseName = new string(name);
            System.Console.WriteLine(reverseName);
        }
    }
}