using CeUAA14Partie2_dec23_FranckenLouis;
using System.Runtime.Intrinsics.Arm;
using System.Security;
using System.Security.Cryptography.X509Certificates;

bool verif;
int ballreservation;
int capacite;
bool quitter;
string message;
bool go;


verif = false;
quitter = false;
capacite = 0;



Console.WriteLine("Bonjour soldat,\n\nBienvenue sur le terrain d'entraînement militaire. Aujourd'hui, nous allons évaluer tes capacités en terme de gestion de cartouches ou encore de ton aim ainsi que tes mouvements. \n\nAvant de commencer, voici plusieurs armes que tu peux choisir, je te conseille de choisir celle par défaut... (Sélectionnez avec le NumPad) \n  [+] LittleGun (10/chargeur)\n  [+] NormalGun (12/chargeur)\n  [Par défaut] BigGun (16/chargeur)\n\nQue choississez-vous?");
do
{
    ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.NumPad1)
    {
        verif = true;
        capacite = 10;
    } else if (info.Key == ConsoleKey.NumPad2)
    {
        verif = true;
        capacite = 12;
    } else if ( info.Key == ConsoleKey.NumPad3)
    {
        verif = true; 
        capacite = 16;
    } else
    {
        verif = false;
        Console.WriteLine("\nMerci de recommencer en sélectionnant 1-2-3 sur votre NumPad... \n");
    }
} while (verif == false);

verif = false;
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Très bon choix ! \n\nA présent, combien de balle souhaitez-vous acheter pour les mettres dans votre poche (Minimum: 30)");
do
{
    ballreservation = Convert.ToInt32(Console.ReadLine());
    if (ballreservation >= 30)
    {
        verif = true;
    } else
    {
        Console.WriteLine("\nMerci de recommencer correctement en indiquant un chiffre supérieur ou égale à 30");
        verif = false;
    }
} while (verif == false);



Thread.Sleep(2000);
Console.Write("Préparation de votre arme en cours");
    GunFiles Gun1 = new GunFiles(ballreservation, 30, false, capacite, ballreservation);
for (int i = 0; i < 5; i++)
{
    Thread.Sleep(500);
    Console.Write(".");
}
Console.WriteLine("\n\nVotre arme est prête, lancement du combat dans 5 secondes");
Thread.Sleep(5000);
Console.Clear();


do
{
    message = Gun1.AffichageStuff;
    Console.WriteLine(message);
    ConsoleKeyInfo info = Console.ReadKey();
    if (info.Key == ConsoleKey.Q)
    {
        quitter = true;
    } else if (info.Key == ConsoleKey.Spacebar)
    {
        Gun1.Tirer;
        quitter = false;
    } else if (info.Key == ConsoleKey.Spacebar)
    {
        Gun1.Recharger;
        quitter = false;
    }



} while (quitter == false);
Console.Clear();
Console.WriteLine("Merci d'avoir jouer, le programme s'éteint dans 3 secondes");
Thread.Sleep(3000);
