﻿using System;

namespace TypeConversion3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }
    }
}