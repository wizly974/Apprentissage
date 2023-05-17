using System.Collections.Generic;


namespace Exercice12
{
    class Program
    {
        public static void Main(string[] args)
        {
          var numbers = new List<int>();
          while (numbers.Count < 5)
          {
            System.Console.Write("enter a number:");
            var number = Convert.ToInt32(System.Console.ReadLine());
            if (numbers.Contains(number))
            {
                System.Console.WriteLine("previously entered number: " + number);
                continue;
            }
            numbers.Add(number);
          }
            numbers.Sort();
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }      
    }    
}
