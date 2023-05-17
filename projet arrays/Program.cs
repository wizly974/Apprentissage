using System;

namespace pojet_arrays
    {
        class Program
        {
            static void Main(string[] args)
            {
                var numbers = new int[3] {1, 0, 0} ;
                Console.WriteLine( numbers[0]);
                Console.WriteLine( numbers[1]);
                Console.WriteLine( numbers[2]);
                 
                var flags = new bool [3] {true, false, false};
                Console.WriteLine( flags[0]);
                Console.WriteLine( flags[1]);
                Console.WriteLine( flags[2]);

                var names = new string [3] {"jack", "john","wesley"};
                Console.WriteLine(names[0]);
                Console.WriteLine(names[1]);
                Console.WriteLine(names[2]);

                var name = "wes";
                char fC = name[0];
                System.Console.WriteLine(fC);
           }
        }
    }