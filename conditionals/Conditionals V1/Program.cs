using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
        int hour = 10;
        
        if (hour > 0 && hour < 12)
        {
        System.Console.WriteLine("it's mornig.");
        }
        
        else if (hour >= 12 && hour < 18)
        {
        System.Console.WriteLine("it's afternoon.");
        }
            
        else
        {
        System.Console.WriteLine("it's evening.");         
        } 
        
        }    
    }
}