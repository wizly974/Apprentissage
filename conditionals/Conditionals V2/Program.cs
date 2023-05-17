using System;

namespace Conditionals_V2
{
    class Program
    {
        static void Main(string[]args)
        {
            bool isGoldcustumer = true;

            // float price;
            // if (isGoldcustumer)
            //     price = 19.95f;
            
            // else
            //     price = 29.95f;  

            float price = (isGoldcustumer) ? 19.95f : 29.95f;
            System.Console.WriteLine(price);

        }
    }
}