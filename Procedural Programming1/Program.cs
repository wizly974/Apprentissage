using System;


namespace Procedural_Programming1
{
    class Program
    {
        public static void Main(string[] args)
        {   
            System.Console.Write("what's your name: ");
            var name = System.Console.ReadLine();
            var reversed = ReversedName(name);
            System.Console.Write("Reversed name: " + reversed);
        }

        public static string ReversedName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array [name.Length - i] = name[i - 1];

            return new string(array);
        }
    }
}    
