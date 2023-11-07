using Act3PooLouis_Ex;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        // Création des deux éléphants

        Elephant elephant1 = new Elephant("Zazou", 82);
        Elephant elephant2 = new Elephant("Titi", 100);
        int[,] tableau;


        do
        {
            Console.WriteLine("Bienvenue dans cet échange d'éléphants");
            Console.WriteLine("Tapez :");
            Console.WriteLine("1 pour afficher les informations de Zazou,\n2 pour Titi,\n3 pour les échanger,\n4 pour voir le transfert d'un message de Zazou à Titi\n5 pour réviser la notion de tableaux et l'appliquer à des objets");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (choice == 1)
            {
                elephant1.affichequisuisje();
            }
            else if (choice == 2)
            {
                elephant2.affichequisuisje();
            }
            else if (choice == 3)
            {
                Echange(ref elephant1, ref elephant2);
                elephant1.affichequisuisje();
                elephant2.affichequisuisje();
            } else if (choice == 4)
            {
                elephant1.EnvoieMessage("Coucou Titi !", elephant2);
                elephant2.EcouteMessage("Perlinpinpin", elephant1);
            } else if (choice == 5)
            {
                tableau = new int[7, 3];
                Elephant elephant3 = new Elephant("Titi", 35);
                Elephant elephant4 = new Elephant("Titi", 33);
                Elephant elephant5 = new Elephant("Titi", 10);
                Elephant elephant6 = new Elephant("Titi", 47);
                Elephant elephant7 = new Elephant("Bill", 156);
            }

            Console.WriteLine("\n");
        } while (true);



        static void Echange(ref Elephant elephant1, ref Elephant elephant2)
        {
            Elephant xxx;
            xxx = elephant1;
            elephant1 = elephant2;
            elephant2 = xxx;
        }




    }
}