using System.Collections.Generic;


namespace Exercice13
{
    class Program
    {
        public static void Main(string[] args)
        {
          var numbers = new HashSet<int>();
          while (true)
          {
            System.Console.Write("enter a number:");
            var input = System.Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            var number = Convert.ToInt32(input);
            numbers.Add(number);
          }
          
        foreach (var number in numbers)
        {
            System.Console.WriteLine(number);
        }
        }      
    }    
}
/*Pour afficher les numéros uniques saisis par l'utilisateur, 
vous pouvez utiliser une structure de données appelée Set. 
Un Set est une collection qui ne permet pas les doublons, 
donc tous les éléments qu'il contient sont uniques. 
Vous pouvez ajouter chaque nombre saisi par l'utilisateur dans le Set et, 
une fois que la boucle est terminée, 
vous pouvez afficher tous les éléments du Set.

En C#, vous pouvez utiliser la classe HashSet<T> pour implémenter un Set.
Voici comment vous pouvez l'utiliser dans votre code :

    Créez un objet HashSet<int> en dehors de la boucle while.
    Dans la boucle while, ajoutez chaque nombre saisi par l'utilisateur dans le HashSet en utilisant la méthode Add.
    Une fois que la boucle est terminée, itérez sur tous les éléments du HashSet et affichez-les.*/