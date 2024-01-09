using ActHeritagePooLouis_Ex;

Console.WriteLine("Bienvenue sur le gestionnaire de profil pour vehicule");

Voiture Voiture1 = new Voiture("Moteur Renault", false, "Renault volé", "Mégane RS volé", "Blanche", 44453);
Voiture Voiture3 = new Voiture("Moteur Mercedes", true, "Mercedes-Benz", "300 SLR Uhlenhau", "Grise", 135000000);



Console.WriteLine("Voici la voiture 1\n");
Console.WriteLine(Voiture1.Affichage());

Console.WriteLine("\n\n\nVoici la voiture 3\n");
Console.WriteLine(Voiture3.Affichage());