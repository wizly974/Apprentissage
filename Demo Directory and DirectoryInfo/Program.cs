using System;
using System.IO;

namespace Demo_Directory_and_DirectoryInfo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Directory
            Directory.CreateDirectory(@"/home/wesley/temp/folder1");
            var files = Directory.GetFiles(@"/home/wesley/Desktop/projects/CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }

            var files1 = Directory.GetFiles(@"/home/wesley/Desktop/projects/CSharpFundamentals", "*.csproj", SearchOption.AllDirectories);
            foreach (var file in files1)
            {
                System.Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"/home/wesley/Desktop/projects/CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
            }

            var folderExists = Directory.Exists(@"/home/wesley/temp/folder1");
            System.Console.WriteLine(folderExists);

            // DirectoryInfo
            var directoryInfo = new DirectoryInfo(@"/home/wesley/Desktop/projects/Exercice/Exercice1");

            var files2 = directoryInfo.GetFiles(); 
            foreach (var file in files2)
            {
                System.Console.WriteLine(file);
            }

            var directoryInfo1 = new DirectoryInfo(@"/home/wesley/Desktop/projects/Exercice/Exercice1");

            var directories1 = directoryInfo1.GetDirectories();
            foreach (var directory in directories1)
            {
                System.Console.WriteLine(directory);
            }
        }
    }
}