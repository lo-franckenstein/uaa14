using ChienPOO;
using System;

namespace Chien
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Première méthode");
            ChienClasse chien1 = new ChienClasse("Peter", "Fox Terrier", 5, false, true, "Bisexuel Gay qui demande à ce qu'on dise 'iel' pour le désigner", true, false, true, true, true, false);
            ChienClasse chien2 = new ChienClasse("Moran", "Labrador", 10, false, true, "Homme", false, false, false, false, true, false);
            ChienClasse chien3 = new ChienClasse("Flocon", "Cocker", 15, true, false, "Cheer", true, true, true, false, false, false);


            Console.WriteLine(chien1.AfficheCaracteristiques());
            Console.WriteLine("\n\n");
            Console.WriteLine(chien2.AfficheCaracteristiques());
            Console.WriteLine("\n\n");
            Console.WriteLine(chien3.AfficheCaracteristiques());

        }
    }
}