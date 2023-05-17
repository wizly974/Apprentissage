using System.Collections.Generic;


namespace Exercice13bis
{
    class Program
    {
        public static void Main(string[] args)
        {
          var numbers = new List<int>();
          while (true)
          {
            System.Console.Write("enter a number:");
            var input = System.Console.ReadLine();
            if (input.ToLower() == "quit")
            {
              break;
            }
            var number = Convert.ToInt32(input);
            numbers.Add(number);
          }

          var unique = new List<int>();
          foreach (var number in numbers)
          {
            if(!unique.Contains(number))
            unique.Add(number);
          }
          System.Console.WriteLine("unique numbers:");
          foreach (var number in unique)
        {
            System.Console.WriteLine(number);
        }
        }      
    }    
}
