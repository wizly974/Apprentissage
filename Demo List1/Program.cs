using System.Collections.Generic;

namespace Demo_List1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>(){1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new List<int>(){5, 6,7});
            numbers.AddRange(new int[3]{5, 6,7});

            foreach (var number in numbers)
            {
                System.Console.Write(number);
            }

            System.Console.WriteLine();
            
            System.Console.WriteLine("Index of 1: " +numbers.IndexOf(1));

            System.Console.WriteLine("Last Index of 1: " +numbers.LastIndexOf(1));

            System.Console.WriteLine("Count: " +numbers.Count);

            numbers.Remove(1);
            // La méthode Remove contient des informations importante dans Demo List2
            
            numbers.Clear();
            System.Console.WriteLine("Count: " +numbers.Count);
        }
    }
}