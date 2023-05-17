using System;

namespace Exercice18
{
    class Program
    {
       public static void Main(string[] args)
       {
          System.Console.WriteLine("Enter a few words:");
          var input = System.Console.ReadLine();
          var capitalizedWord = StringUtility.camelCaseText(input);
          System.Console.WriteLine(capitalizedWord);
       }
    }   

    class StringUtility
    {
      public static string camelCaseText(string text)
      {
         if (text == null)
        {
            return "";
        }
        var capitalizedWord = "";

        foreach (var word in text.Split(' '))
        {
            if(!string.IsNullOrWhiteSpace(word))
          capitalizedWord += char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }
        return capitalizedWord;
      }
    } 
}    
