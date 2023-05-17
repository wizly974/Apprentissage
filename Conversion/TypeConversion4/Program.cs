using System;

namespace TypeConversion4
{
    class Program
    { 
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);    
            }
            catch (System.Exception)
            {
                Console.WriteLine("the number could'nt be converted to a byte.");
            }
        }
    }
}