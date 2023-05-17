using System;

namespace Conditionals_V3
{
            class Program
        {
                static void Main(string[] args)
                {
                    var season = Season.Autumn;
                    switch(season)
                    {
                        case Season.Autumn:
                        case Season.Spring:
                        System.Console.WriteLine("We've got promotion.");
                        break;

                        default:
                        System.Console.WriteLine("I don't understand that season.");
                        break;
                    }

                }
        }
}