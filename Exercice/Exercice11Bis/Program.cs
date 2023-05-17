using System;


namespace Exercice11Bis
{
    class Program
    {
        public static void Main(string[] args)
        
        {
          System.Console.WriteLine("what's your name? ");
          var name = System.Console.ReadLine();

          var array = new char[name.Length];
          for ( var i = name.Length; i > 0; i--)
          array[name.Length - i] = name[i - 1];

          var reverse = new string(array);
          System.Console.WriteLine(reverse);
        }
    }    
}
/*Dans ce code, il s'agit d'inverser une chaîne de caractères qui a été saisie
par l'utilisateur en utilisant une boucle for et un tableau de caractères.
La boucle for parcourt chaque caractère de la chaîne de caractères name en partant
de la fin (de la dernière lettre à la première). 
C'est pourquoi la condition i > 0 est utilisée. Si la condition était i >= 0,
la boucle aurait également traité le caractère nul à la fin de la chaîne
(car les tableaux en C# sont indexés à partir de 0).
À chaque itération de la boucle, la lettre courante est stockée dans le tableau array
à l'indice correspondant. 
Comme on parcourt la chaîne de droite à gauche, 
on utilise l'expression name.Length - i pour calculer l'indice correspondant dans le tableau.
Pourquoi décrémenter i dans la boucle for ? 
L'idée est de partir de la fin de la chaîne et de la parcourir de droite à gauche.
En décrémentant i à chaque itération de la boucle, on parcourt la chaîne dans l'ordre inverse.
Enfin, la dernière ligne crée une nouvelle chaîne de caractères en utilisant le tableau array.
Cette nouvelle chaîne est la version inversée de la chaîne name.
*/