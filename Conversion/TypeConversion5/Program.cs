using System;

namespace TypeConversion5
{
    class Program
    {
        static void Main(string[] args)
        {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
        }
    }
}