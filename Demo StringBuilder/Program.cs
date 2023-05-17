using System.Text;
using System;

namespace Demo_StringBuilder
{
    class Program
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello,World");
            
            builder
                    .Append('-',10)
                    .AppendLine()
                    .AppendLine("Header")
                    .AppendLine()
                    .Append('-',10)
                    .Replace('-','+')
                    .Remove(0,10)
                    .Insert(0,new string('-',10));

            System.Console.WriteLine(builder);
            System.Console.WriteLine("First char: "+ builder[0]);
        }
    }
}