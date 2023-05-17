using System.Collections.Generic;


namespace Exercice10
{
    class Program
    {
        public static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                System.Console.WriteLine("Enter a name (or hit enter to exit):");

                var input = System.Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if(names.Count > 2)
            {
            System.Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1],names.Count - 2);
            }

            else if (names.Count == 2)
            {
                System.Console.WriteLine("{0} and {1} like yours post", names[0], names[1]);
            }

            else if (names.Count == 1)
            {
                System.Console.WriteLine("{0} likes your post", names[0]);
            }
        }
    }    
}