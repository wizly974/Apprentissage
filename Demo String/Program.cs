using System;

namespace Demo_String
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fullName = "Wesley Benard Rudy Joseph";
            System.Console.WriteLine("Trim: '{0}'", fullName.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Indexof and Substring methode
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("Firstname: " + firstName);
            System.Console.WriteLine("Lastname: "+ lastName);

            // Split methode
            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName : " + names[1]);
            System.Console.WriteLine("LastName2: " + names[2]);
            System.Console.WriteLine("LastName3: " + names[3]);


            //Replace methode
            System.Console.WriteLine(fullName.Replace("Wesley", "Wes"));
            System.Console.WriteLine(fullName.Replace('e','E'));
            System.Console.WriteLine(fullName.Replace(" ",""));

            if(string.IsNullOrEmpty(null))
            System.Console.WriteLine("invalid");
            if(string.IsNullOrEmpty(""))
            System.Console.WriteLine("invalid");

            if(string.IsNullOrEmpty(" "))
            System.Console.WriteLine("invalid");
            if(string.IsNullOrEmpty(" ".Trim()))
            System.Console.WriteLine("invalid");

            if(string.IsNullOrWhiteSpace(" "));
            System.Console.WriteLine("invalid");

            var str ="25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);

            float price = 29.95f;
            System.Console.WriteLine(price.ToString());
            System.Console.WriteLine(price.ToString("C"));
            System.Console.WriteLine(price.ToString("C0"));
            System.Console.WriteLine(price.ToString("C1"));

            // indexOf() + substring methode ex:
            var fullName1 = "Wesley Benard Rudy Joseph";
            var firstSpaceIndex = fullName1.IndexOf(' ');
            var firstName1 =  fullName1.Substring(0,firstSpaceIndex);
            var remainingName = fullName1.Substring(firstSpaceIndex + 1);

            var secondSpaceIndex = remainingName.IndexOf(' ');
            var lastName1 = remainingName.Substring(0,secondSpaceIndex);
            var remainingName2 = remainingName.Substring(secondSpaceIndex + 1);

            var ThirdSpaceIndex = remainingName2.IndexOf(' ');
            var lastName2 = remainingName2.Substring(0,ThirdSpaceIndex );
            var remainingName3 = remainingName2.Substring(ThirdSpaceIndex + 1);

            var fourSpaceIndex = remainingName3.IndexOf(' ');
            var lastName3 = remainingName3.Substring(fourSpaceIndex + 1);
            
            System.Console.WriteLine(firstName1);
            System.Console.WriteLine(lastName1);
            System.Console.WriteLine(lastName2);
            System.Console.WriteLine(lastName3);

        }
    }
}