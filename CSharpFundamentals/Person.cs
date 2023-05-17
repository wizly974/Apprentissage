using System;

namespace CSharpFundamentals
{
public class Person
        {
            public string FirstName;
            public string LastName;
            public void Introduce()
            {
                Console.WriteLine("my name is " + FirstName + " " + LastName);
            }
        }
}