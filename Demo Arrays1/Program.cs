using System;

namespace Demo_Arrays1
{
    class Program
    {
        public static void Main(string[] args)
        {
          var numbers = new[] {3, 7, 9, 2, 14, 6};
          // Length
          System.Console.WriteLine("lenght: " + numbers.Length);
          
          // IndexOf()
          var index = Array.IndexOf(numbers, 9);
          System.Console.WriteLine("Index of 9 is " + index);

          // Clear()
          Array.Clear(numbers, 0, 2);
          System.Console.WriteLine("Effect of clear():");
          foreach (var n in numbers)
          {
            System.Console.WriteLine(n);
          }

          // Copy()
          var another = new int[3];
          Array.Copy(numbers, another, 3);
          System.Console.WriteLine("effect of Copy():");
          foreach (var n in another)
          {
            System.Console.WriteLine(n);
          }
          
          // Sort()
          Array.Sort(numbers);
          System.Console.WriteLine("effect of Sort():");
          foreach (var n in numbers)
          {
            System.Console.WriteLine(n);
          }   
          
          // Reverse()
          Array.Reverse(numbers);
          System.Console.WriteLine("effect of Reserve:");

          foreach (var n in numbers)
          {
            System.Console.WriteLine(n);
          }

        }
    }    
}