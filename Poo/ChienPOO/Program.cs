using ChienPOO;
using System;
using System.Security;
using System.Xml.Serialization;

namespace Chien
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] chienTableau;
            int choicechien;
            int reponse;
            bool sortiedesmodifications;
            bool modif;
            
            ChienClasse chien1 = new ChienClasse("Peter", "Fox Terrier", 5, false, true, "Bisexuel Gay qui demande à ce qu'on dise 'iel' pour le désigner", true, false, true, true, true, false);
            ChienClasse chien2 = new ChienClasse("Moran", "Labrador", 10, false, true, "Homme", false, false, false, false, true, false);
            ChienClasse chien3 = new ChienClasse("Flocon", "Cocker", 15, true, false, "Cheer", true, true, true, false, false, false);



            chienTableau = new string[3];
            chienTableau[0] = chien1.AfficheCaracteristiques();
            chienTableau[1] = chien2.AfficheCaracteristiques();
            chienTableau[2] = chien3.AfficheCaracteristiques();

            Console.WriteLine(chienTableau[0]);
            Console.WriteLine("\n\n");
            Console.WriteLine(chienTableau[1]);
            Console.WriteLine("\n\n");
            Console.WriteLine(chienTableau[2]);

            modif = false;
            do
            {

                Console.WriteLine("\n\nSouhaitez-vous modifier sur le premier chien?\n  [0] Rien\n  [1] Age\n  [2] Vaccin\n  [3] Puce\n  [4] Genre\n  [5] Stérélisation\n  [6] Surdité\n  [7] Aggressivité\n  [8] Aveugle\n  [9] Manque de membres\n  [10] Dressage");
                choicechien = int.Parse(Console.ReadLine());

                sortiedesmodifications = false;
                if (choicechien == 1)
                {
                    modif = true;
                    Console.WriteLine("\nQuel âge a votre chien1 ?");
                    chien1.Age = uint.Parse(Console.ReadLine());
                }
                else if (choicechien == 2)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il vacciné? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Vaccin = false;
                    }
                    else
                    {
                        chien1.Vaccin = true;
                    }
                }
                else if (choicechien == 3)
                {
                    modif = true;
                    Console.WriteLine("\nPossède-t-il un puce électronique? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Puce = false;
                    }
                    else
                    {
                        chien1.Puce = true;
                    }
                }
                else if (choicechien == 4)
                {
                    modif = true;
                    Console.WriteLine("\nDe quel genre est votre chien?");
                    chien1.Genre = Console.ReadLine();
                }
                else if (choicechien == 5)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il stérélisé? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Sterilise = false;
                    }
                    else
                    {
                        chien1.Sterilise = true;
                    }
                }
                else if (choicechien == 6)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il sourd? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Sourd = false;
                    }
                    else
                    {
                        chien1.Sourd = true;
                    }
                }
                else if (choicechien == 7)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il aggressif? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Aggressif = false;
                    }
                    else
                    {
                        chien1.Aggressif = true;
                    }
                }
                else if (choicechien == 8)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il aveugle? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Aveugle = false;
                    }
                    else
                    {
                        chien1.Aveugle = true;
                    }
                }
                else if (choicechien == 9)
                {
                    modif = true;
                    Console.WriteLine("\nEst-ce qu'il lui manque des membres? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.ManqueDeMembres = false;
                    }
                    else
                    {
                        chien1.ManqueDeMembres = true;
                    }
                }
                else if (choicechien == 10)
                {
                    modif = true;
                    Console.WriteLine("\nEst-il dressé? (0 = Non - 1 = Oui)");
                    reponse = int.Parse(Console.ReadLine());
                    if (reponse == 0)
                    {
                        chien1.Dresse = false;
                    }
                    else
                    {
                        chien1.Dresse = true;
                    }
                }
                else if (choicechien == 0)
                {
                    sortiedesmodifications = true;
                }
            } while (sortiedesmodifications == false);




            if (modif == true)
            {
            // Mise à jour
            chienTableau[0] = chien1.AfficheCaracteristiques();
            Console.WriteLine("\n\nMise à jour du chien 1 \n" + chienTableau[0]);
            }

        }
    }
}