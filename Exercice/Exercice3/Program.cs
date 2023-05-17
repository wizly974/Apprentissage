using System;

namespace Exercice4
{
    class Program
    {
        public enum ImageOrientation
        {
            landscape,
            portrait,
        }
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the width:");
            var width = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the height");
            var height = Convert.ToInt32(System.Console.ReadLine());

            var Orientation = width > height ? ImageOrientation.landscape : ImageOrientation.portrait;
            System.Console.WriteLine(Orientation);
        }
    }
}