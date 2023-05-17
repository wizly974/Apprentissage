using System;


namespace Data_time
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dateTime = new DateTime(2023,04,15);
            var now = DateTime.Now;
            var today = DateTime.Today;

            // System.Console.WriteLine("hour: " + now.Hour);
            // System.Console.WriteLine("minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine("tomorrow is: " + tomorrow);
            System.Console.WriteLine("yesterday is: " + yesterday);

            System.Console.WriteLine();

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());

            System.Console.WriteLine();

            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());

            System.Console.WriteLine();

            System.Console.WriteLine(now.ToString("yyyy-MM-dd"));
            System.Console.WriteLine(now.ToString("HH:mm:ss"));
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));

            // Aller regarder sur google les datime format specifier.
        }
    }
}
