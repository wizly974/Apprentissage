using System;

namespace Summarising_Text
{
    public class StringUtility
    {
        public static string SummerizeText(string text,int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
            return text;
            }
        
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length +1 ; // on ajoute 1 pour l'espaces qu'il y a après le chaque mot.
                    if (totalCharacters > maxLength)
                    break;
                }

            return string.Join(" ",summaryWords) + "...";
        }
    }
}