using ActHeritagePooLouis_ExEntreprise;
using System.IO.IsolatedStorage;

Employe[] mesEmployes = new Employe[10];
generateurInformation fonction = new generateurInformation();
bool leave = false;
int pourcentageOfficiel = fonction.GetRandomPourcentage();



for (int i = 0; i < 2; i++)
{
    mesEmployes[i] = new Directeur(fonction.GetRandomMatricule(), fonction.GetRandomName(), fonction.GetRandomSurName(), fonction.GetRandomDate(), 0, fonction.GetRandomCA(), pourcentageOfficiel);
}

for (int i = 2;i < 5;i++)
{
    Random random = new Random();
    int IndiceRandom = random.Next(1, 4);
    mesEmployes[i] = new Cadre(fonction.GetRandomMatricule(), fonction.GetRandomName(), fonction.GetRandomSurName(), fonction.GetRandomDate(), 0, IndiceRandom);
    mesEmployes[i].CalculSalaire();
}

for (int i = 5; i < 10; i++)
{
    DateTime dateEmploiTemp;
    DateTime dateNaissanceTemp;
    do
    {
        dateNaissanceTemp = fonction.GetRandomDate();
        dateEmploiTemp = fonction.GetRandomDate();
    } while (dateNaissanceTemp < dateEmploiTemp);

    mesEmployes[i] = new Ouvrier(fonction.GetRandomMatricule(), fonction.GetRandomName(), fonction.GetRandomSurName(), dateNaissanceTemp, 0, dateEmploiTemp);
    mesEmployes[i].CalculSalaire();
}

do
{
    Console.WriteLine("Bienvenue sur l'application de gestion de l'entreprise " + mesEmployes[0].Prenom + " Industry & CO\n\nPour voir la carte d'identité d'une personne, tapez:");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("[" + (i + 1) + "] " + mesEmployes[i].Nom + " " + mesEmployes[i].Prenom);
    }
    Console.WriteLine("[Enter] Quitter l'application");
    ConsoleKeyInfo info;
    do
    {
        info = Console.ReadKey();
    } while (info.Key != ConsoleKey.NumPad1 && info.Key != ConsoleKey.NumPad2 && info.Key != ConsoleKey.NumPad3 && info.Key!= ConsoleKey.NumPad4 && info.Key != ConsoleKey.NumPad5 && info.Key != ConsoleKey.NumPad6 && info.Key != ConsoleKey.NumPad7 && info.Key != ConsoleKey.NumPad8 && info.Key != ConsoleKey.NumPad9 && info.Key != ConsoleKey.NumPad0 && info.Key != ConsoleKey.Enter);
    Console.Clear();
    Thread.Sleep(1000);
    switch (info.Key)
    {
        case ConsoleKey.NumPad1:
            Console.WriteLine(mesEmployes[0].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad2:
            Console.WriteLine(mesEmployes[1].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad3:
            Console.WriteLine(mesEmployes[2].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad4:
            Console.WriteLine(mesEmployes[3].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad5:
            Console.WriteLine(mesEmployes[4].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad6:
            Console.WriteLine(mesEmployes[5].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad7:
            Console.WriteLine(mesEmployes[6].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad8:
            Console.WriteLine(mesEmployes[7].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad9:
            Console.WriteLine(mesEmployes[8].AfficherCaracteristiques());
            break;
        case ConsoleKey.NumPad0:
            Console.WriteLine(mesEmployes[9].AfficherCaracteristiques());
            break;
        case ConsoleKey.Enter:
            leave = true;
            Console.WriteLine("Mise en suspens du traitement en cours...");
            break;
        default:
            Console.WriteLine("Une erreur est arrivé lors du traitement");
            break;
    }
    Thread.Sleep(1000);
    Console.WriteLine("\n\n\n\nAppuyez sur 'A' pour continuer");
    ConsoleKeyInfo info2;
    do
    {
        info2 = Console.ReadKey();
    } while (info2.Key != ConsoleKey.A);
    Console.Clear();
    Thread.Sleep(500);
} while (leave == false);


