using System.Dynamic;
using System;

namespace Exercice4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the speed limit");
            var speedLimit = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Enter the speed of this car");
            var speedCar = Convert.ToInt32(System.Console.ReadLine());

            if (speedCar < speedLimit)
            {
                System.Console.WriteLine("Ok.");
            }
            else
            {
            const int KmPerDemeritPoint = 5;
            var demeritPoint = (speedCar - speedLimit)/KmPerDemeritPoint;
            if (demeritPoint > 12)
            System.Console.WriteLine("License Supended");

            else
            System.Console.WriteLine("Demerit points " + demeritPoint);
            }        
        }
    }
}