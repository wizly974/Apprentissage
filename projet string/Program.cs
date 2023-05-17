using System;

namespace projet_string
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstName =  "Wesley";
            var lastName = "Benard";
           
            var fullName = firstName + " " + lastName;
           
            var myFullName = String.Format("My name is {0} {1}", firstName, lastName);

            var names = new string [4] { "Wesley", "Benard", "Rudy", "Joseph" };
            
            var formattedNames = string.Join(",", names);

            var text = "hi Wesley\nLook into the followin paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
           
           
            var textverbatim = @"hi Wesley
            Look into the followin paths
            c:\folder1\folder2
            c:\folder3\folder4";
            
            var result = string.Compare(firstName, lastName);
            if(result == 0)
            {
            System.Console.WriteLine("identique");
            }
            else if (result < 0)
            {   
            System.Console.WriteLine("1 inférieur a 2");
            }
            else if(result > 0)
            {
            System.Console.WriteLine("1 supérieur a 2");
            }
            Console.WriteLine(fullName);
            Console.WriteLine(myFullName);
            Console.WriteLine(formattedNames);
            Console.WriteLine(text);
            Console.WriteLine(textverbatim);
        }
    }
}
