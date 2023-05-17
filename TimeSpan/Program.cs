using System;

namespace Laps_de_temps
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("duration: " + duration);

            //properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            //Add 
            System.Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            
            //subtract
            System.Console.WriteLine("subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            System.Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
            
        }
    }
}