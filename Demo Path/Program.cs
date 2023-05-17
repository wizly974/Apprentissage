using System;
using System.IO;

namespace Demo_Path
{
    class Program
    {
        public static void Main(string[] args)
        {
            var path = @"/home/wesley/projects/Exercice/Exercice1/Exercice1.csproj";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            System.Console.WriteLine(extension);
            
            System.Console.WriteLine("Extension: " + Path.GetExtension(path));
            
            System.Console.WriteLine("File Name: " + Path.GetFileName(path));
            System.Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));

            System.Console.WriteLine("Directory Name: "+ Path.GetDirectoryName(path));
        }
    }
}