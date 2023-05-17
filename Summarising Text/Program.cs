using System;

namespace Summarising_Text
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sentence = "this is going to be a really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            System.Console.WriteLine(summary);
        }
    }
}