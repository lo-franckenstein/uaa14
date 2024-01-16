using ActHeritagePooLouis_ExAnimaux;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

Animal[] mesAnimaux = new Animal[5];
bool leave = false;


mesAnimaux[0] = new Chien("Nestor", DateTime.Parse("12/02/2024"), 4068684, 132, false);
mesAnimaux[1] = new Chien("Milou", DateTime.Parse("28/12/2008"), 6516581, 85, true);
mesAnimaux[2] = new Chat("Pitch", DateTime.Parse("20/03/2020"), 165146988, 10, true);
mesAnimaux[3] = new Chat("Sherman", DateTime.Parse("15/05/2015"), 365418, 95, false);
mesAnimaux[4] = new Lapin(30, "Flocon", DateTime.Parse("11/11/2012"), 9846546, 60, false);


do
{
    Console.WriteLine("APPLICATION DE L'ASSISTANCE D'ANIMATION DE VOS ANIMAUX");
    Console.WriteLine("Choississez une option: \n  [1] Afficher l'identité d'un animal de votre choix\n [2] Lancer une musique pour chien\n  [3] Lancer une croquette aux chats\n  [4] Lancer la musique de relaxation de vos chats\n [5] Libérez le lapin de la cage\n [6] Quitter l'application");
    ConsoleKeyInfo info;
    do
    {
        info = Console.ReadKey();
    } while (info.Key != ConsoleKey.NumPad1 && info.Key != ConsoleKey.NumPad2 && info.Key != ConsoleKey.NumPad3 && info.Key != ConsoleKey.NumPad4 && info.Key != ConsoleKey.NumPad5 && info.Key != ConsoleKey.NumPad6);
    Console.Clear();
    if (info.Key == ConsoleKey.NumPad1)
    {
        Console.WriteLine("\n\nVous souhaitez voir l'identité de quel animal? (1 - Chiens, 2 - Chats, 3 - Lapin");
        do
        {
            info = Console.ReadKey();
        } while (info.Key != ConsoleKey.NumPad1 && info.Key != ConsoleKey.NumPad2 && info.Key != ConsoleKey.NumPad3);
        if(info.Key == ConsoleKey.NumPad1)
        {
            for (int i = 0; i < 5; i++)
            {
                if (mesAnimaux[i] is Chien chien)
                {
                    Console.WriteLine(chien.AffichageCaractéristiques());
                }
            }
        } else if(info.Key == ConsoleKey.NumPad2)
        {
            for (int i = 0; i < 5; i++)
            {
                if (mesAnimaux[i] is Chat chat)
                {
                    Console.WriteLine(chat.AffichageCaractéristiques());
                }
            }
        } else
        {
            for (int i = 0; i < 5; i++)
            {
                if (mesAnimaux[i] is Lapin lapin)
                {
                    Console.WriteLine(lapin.AffichageCaractéristiques());
                }
            }
        }
    } else if(info.Key == ConsoleKey.NumPad2)
    {
        for (int i = 0; i < 5; i++)
        {
            if (mesAnimaux[i] is Chien chien)
            {
                Console.WriteLine(chien.Aboyer());
            }
        }
    } else if( info.Key == ConsoleKey.NumPad3)
    {
        for (int i = 0; i < 5; i++)
        {
            if (mesAnimaux[i] is Chat chat)
            {
                Console.WriteLine(chat.miauler());
            }
        }
    } else if ( info.Key == ConsoleKey.NumPad4)
    {
        for (int i = 0; i < 5; i++)
        {
            if (mesAnimaux[i] is Chat chat)
            {
                Console.WriteLine(chat.ronronner());
            }
        }
    } else if (info.Key == ConsoleKey.NumPad5)
    {
        for (int i = 0; i < 5; i++)
        {
            if (mesAnimaux[i] is Lapin lapin)
            {
                Console.WriteLine(lapin.Sauter());
            }
        }
    } else
    {
        leave = true;
    }

    if(leave == false)
    {
        Console.WriteLine("\n\n\n\n");
    }

} while (leave == false);

