using System.Dynamic;
using System;

namespace Exercice14
{
    class Program
    {
        public static void Main(string[] args)
        {
           string[] elements;
           while (true)
           {
                System.Console.Write("enter comma separeted by number: ");
                var input =  System.Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if(elements.Length >= 5)
                    {
                        break;
                    }
                }
                System.Console.WriteLine("invalid list.");
           }

            var numbers =  new List<int>();
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallests = new List<int>();
            while (smallests.Count() < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number > min)
                    {
                        min = number;
                    }
                }
                smallests.Add(min);
                numbers.Remove(min);               
            }
            System.Console.Write("the 3 smallests numbers are: ");

            foreach (var number in smallests)
            {
                System.Console.Write(number);
            }
            System.Console.WriteLine();
        }
    }      
}    