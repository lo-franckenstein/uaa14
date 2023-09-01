using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ACT00_REVISION
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclaration des variables.... COMPLETER AVEC CE QUI MANQUE

            string rep;

            MethodesDuProjet mp = new MethodesDuProjet();

            
            double c1 = 0;
            double c2 = 0;
            double c3 = 0;
            bool ok = false;

            string triangle;
            string methode;
            string infos;
            double color;
            string question;
            // instanciation de la structure
            // ...... COMPLETER

            Console.WriteLine("Testez les polygones !");
            //On recommence tant que désiré
            do
            {
                question = "Avant de commencer, quelle couleur souhaitez-vous? \nChoississez ces options\n 1 - Rouge \n 2 - Bleu \n 3 - Vert";
                verifDouble(question, out color);


                if (color == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                } else if (color == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }

                //lecture des 3 côtés
                // ...
                // ...
                // ...

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        c1 = lireDouble(i + 1);
                    } else if (i == 1) {
                        c2 = lireDouble(i + 1);
                    } else {
                        c3 = lireDouble(i + 1);
                    }
                }

                // ordonner les côtés => APPEL ORDONNECOTES
                mp.OrdonneCotes(ref c1, ref c2, ref c3);
                // ...
                // série de test (voir consignes)



                ok = mp.Triangle(c1, c2, c3);

                if (ok == true)
                {

                    methode = "triangle";
                    mp.Affiche(ok, methode, out triangle);


                    // vérification équilatéral
                    ok = mp.Equi(c1, c2, c3);
                    if (ok == true)
                    {
                        methode = "equilateral";
                        mp.Affiche(ok, methode, out infos);
                        Console.WriteLine(infos);

                        // préparation et affichage du résultat du test 'equilateral' avec la procédure 'Affiche'
                        // ...
                        // ...

                    }
                    else
                    {
                        // vérification triangle rectangle
                        ok = mp.Triangle(c1, c2, c3);
                        if (ok == true)
                        {

                            methode = "rectangle";
                            mp.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);

                            // préparation et affichage du résultat positif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                        }
                        else
                        {
                            ok = mp.Triangle(c1, c2, c3);
                            methode = "rectangle";
                            mp.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);

                            // préparation et affichage du résultat négatif du test 'rectangle' avec la procédure 'Affiche'
                            // ...
                            // ...
                        }


                        // vérification du cas isocèle et affichage dans le cas positif
                        mp.Isocele(c1, c2, c3, out ok);
                        //...
                        //...
                        //... A vous de voir en combien de lignes...
                        if (ok == true)
                        {
                            mp.Isocele(c1, c2, c3, out ok);
                            methode = "isocele";
                            mp.Affiche(ok, methode, out infos);
                            Console.WriteLine(infos);
                        }

                    }
                }
                else // si ce n'est pas un triangle
                {

                    ok = mp.Triangle(c1, c2, c3);
                    methode = "triangle";
                    mp.Affiche(ok, methode, out infos);
                    Console.WriteLine(infos);


                    // préparation et affichage du résultat négataif du test 'triangle' avec la procédure 'Affiche'
                    // ...
                    // ...
                }
                // reprise ?
                Console.WriteLine("Voulez-vous tester un autre polygône ? (Tapez espace)");
                rep = Console.ReadLine();
            } while (rep == " ");
        }
        //Récupération d'une donnée fournie par l'utilisateur en 'double' : on suppose qu'il ne se trompe pas !
        static double lireDouble(int numeroCote)
        {
            double cote;
            Console.Write("Tapez la valeur du côté " + numeroCote + " : ");
            cote = double.Parse(Console.ReadLine());
            return cote;
        }

        static void verifDouble(string question, out double color)
        {
                bool verif;
            do
            {
                verif = false;
                do
                {
                    Console.WriteLine(question);
                } while (!double.TryParse(Console.ReadLine(), out color)

                if (color == 1 || color == 2 || color == 3)
                {
                    verif = true;
                }

            } while (verif == false);
        }
    }
}
