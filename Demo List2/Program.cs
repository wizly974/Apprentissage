using System.Collections.Generic;

namespace Demo_List1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>(){1, 2, 3, 4};
            numbers.Add(1);
            numbers.AddRange(new int[3]{5, 6,7});
            
            // La méthode Remove ne fonctionne pas avec les boucles foreach,
            // Quand on souhaite supprimer plusieurs même éléments dans une liste.
            // Comme ici "1".
            // Pour cela on utilise une boucle for comme celle, ci-dessous.

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var number in numbers)
            {
                System.Console.Write(number + " ");
            }
                System.Console.WriteLine();
        
        }
    }
}