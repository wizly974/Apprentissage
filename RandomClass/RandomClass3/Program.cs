using System;


namespace Exercice_test
{
    class Program
    {
        public static void Main(string[] args)
        {   
         var random = new Random();

            const int passwordLength = 10;
            
            var buffer = new char[passwordLength];
            for (var i = 0; i < passwordLength; i++)
                if(i%3 == 0)
                {
                buffer[i]=(char)('0' + random.Next(0, 10));
                }
                else
                {
                    buffer[i] = (char)('a' + random.Next(0,26));
                }
                var password = new string(buffer);
                System.Console.WriteLine(password);
        }
    }      
}    
