using ActHeritagePooLouis_ExForme;
Forme[] mesFormes = new Forme[5];
bool leave = false;

mesFormes[0] = new Carré("Rouge", 10);
mesFormes[1] = new Rectangle("Vert", 2, 1);


do
{
    Console.WriteLine("APPLICATION DE CALCUL DE SURFACE / PERIMETRE");
    Console.WriteLine("Choississez une option: \n [1] Afficher une caractéritique d'une forme au choix\n [2] Calculer la surface d'une forme au choix\n [3] Calculer le périmètre d'une forme au choix\n [4] Quitter")
    ConsoleKeyInfo infoclavier;
    ConsoleKeyInfo infoclavier2;
    do
    {
        infoclavier = Console.ReadKey();
    } while (infoclavier.Key != ConsoleKey.NumPad1 && infoclavier.Key != ConsoleKey.NumPad2 && infoclavier.Key != ConsoleKey.NumPad3 && infoclavier.Key != ConsoleKey.NumPad4);
    Console.Clear();
    if (infoclavier.Key == ConsoleKey.NumPad4)
    {
        leave = true;
    } else if(infoclavier.Key == ConsoleKey.NumPad1)
    {
        Console.WriteLine("Quel forme souhaitez-vous voir?\n [1] Carré\n [2] Rectangle");
        do
        {
            infoclavier2 = Console.ReadKey();
        } while (infoclavier2.Key != ConsoleKey.NumPad1 || infoclavier2.Key != ConsoleKey.NumPad2);
        if(infoclavier2.Key == ConsoleKey.NumPad1)
        {
            Console.WriteLine(mesFormes[0].AfficherCaracteristiques());
        } else
        {
            Console.WriteLine(mesFormes[1].AfficherCaracteristiques());
        }
    } else if(infoclavier.Key == ConsoleKey.NumPad2)
    {

    } else if(infoclavier.Key == ConsoleKey.NumPad3)
    {

    }
} while (leave = false);