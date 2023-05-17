using System;

namespace Iterations2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var name = "Wesley Benard";

            // for (var i = 0; i< name.Length; i++)
            // {
            //     System.Console.WriteLine(name[i]);
            // }

            foreach (var character in name)
            {
                System.Console.WriteLine(character);
            }
        }
    }
}